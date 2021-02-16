using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;


namespace AdvancedCalculatorGUI
{
    public partial class FunctionPlotWindow : Form
    {
        string equation, plot_style;
        double start_t, stop_t, step_t;
        OxyPlot.WindowsForms.PlotView function_graph;
        FunctionSeries function;
        Calculator calculatorSystem;

        public FunctionPlotWindow(string text_box, double start, double stop, double step, string style)
        {
            InitializeComponent();
            equation = text_box;
            start_t = start;
            stop_t = stop;
            step_t = step;
            plot_style = style;
            calculatorSystem =  new Calculator();
        }

        private void FunctionPlotWindow_Load(object sender, EventArgs e)
        {
            function_graph = new PlotView { Location = new Point(25, 25) , Size = new Size(550, 300) };
            function = GetFunction();
            SetGraphStyle();
            function_graph.Model.Series.Add(function);
            this.Controls.Add(function_graph);
        }

        private FunctionSeries GetFunction()
        {
            if (equation.Contains("X"))
                return GetComponents();
            else
            {
                List<double> value_list = new List<double>();
                double operation_result = CalculateEquationResult();
                for (double x = start_t; x < stop_t; x += step_t)
                {
                    value_list.Add(operation_result);
                }
                return ProcessListIntoSeries(value_list);
            }
        }

        private FunctionSeries GetComponents()
        {
            List<List<double>> component_list = new List<List<double>>();
            component_list = AnalyzeFunction(component_list);
            List<double> component_sum = SumComponentsList(component_list);
            FunctionSeries function = ProcessListIntoSeries(component_sum);
            return function;
        }

        private List<List<double>> AnalyzeFunction(List<List<double>> component_list)// 2*X, 5*X^3, -2*√X, 2*sinX, -0.5*logX
        {
            string operation, sign;
            int x_index, x_power;
            double multiplication;
            List<string> components = PreProcessEquation();
            List<double> domain_exceptions = CheckDomain(components);

            for (int i = 0; i < components.Count; i++) 
            {
                x_index = components[i].IndexOf("X");
                x_power = 1;
                multiplication = 1;
                operation = "";
                sign = "+";
                if (x_index + 1 < components[i].Length && components[i].Substring(x_index + 1, 1) == "^")
                {
                    operation = "^";
                    x_power = (int)calculatorSystem.GetOperandValue(components[i], x_index + 2);

                }                

                if (x_index - 1 > -1)
                {
                    if (components[i].Substring(x_index - 1, 1) == "-")
                        sign = "-";
                    else if (components[i].Substring(x_index - 1, 1) == "*")
                    {
                        multiplication = calculatorSystem.GetBasisValue(components[i], x_index - 2);
                        double a = multiplication;
                    }
                    else if (components[i].Substring(x_index - 1, 1) == "√")
                    {
                        operation = "√";
                        if (x_index - 2 > -1)
                        {
                            if (components[i].Substring(x_index - 2, 1) == "-")
                                sign = "-";
                            else if (components[i].Substring(x_index - 2, 1) == "*")
                                multiplication = calculatorSystem.GetBasisValue(components[i], x_index - 3);
                        }
                    }
                }
                if (x_index - 3 > -1)
                {
                    if (components[i].Substring(x_index - 3, 3) == "sin")
                    {
                        operation = "sin";
                        if (x_index - 4 > -1)
                        {
                            if (components[i].Substring(x_index - 4, 1) == "-")
                                sign = "-";
                            else if (components[i].Substring(x_index - 4, 1) == "*")
                                multiplication = calculatorSystem.GetBasisValue(components[i], x_index - 5);
                        }

                    }
                    if (components[i].Substring(x_index - 3, 3) == "log")
                    {
                        operation = "log";
                        if (x_index - 4 > -1)
                        {
                            if (components[i].Substring(x_index - 4, 1) == "-")
                                sign = "-";
                            else if (components[i].Substring(x_index - 4, 1) == "*")
                                multiplication = calculatorSystem.GetBasisValue(components[i], x_index - 5);
                        }
                    }
                }


                List<double> component = new List<double>();
                double value = 1;
                for (double x = start_t; x < stop_t; x += step_t)
                {
                    if (x_index != -1)
                    {
                        value = x;
                        if (operation == "^")
                            value = Math.Pow(value, x_power);
                        if (operation == "√")
                            value = Math.Sqrt(x);
                        if (operation == "sin")
                            value = Math.Sin(x);
                        if (operation == "log")
                            value = Math.Log(x);
                        if (sign == "-")
                            value = -1 * value;
                        value *= multiplication;
                    }
                    else if (components[i].Length != 0 && components[i] != " ")
                    {
                        value = Double.Parse(components[i]);
                    }
                    component.Add(value);
                }
                component_list.Add(component);
            }
            return component_list;
        }

        private List<string> PreProcessEquation()
        {
            string formula = equation.Replace("-", "+ - ");
            List<string> components = formula.Split('+').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            for (int i = 0; i < components.Count; i++)
            {
                if (!components[i].Contains("X"))
                {
                    components[i] = calculatorSystem.ProcessSpecialSigns(components[i]);
                    var result = new DataTable().Compute(components[i], null);
                    components[i] = Convert.ToString(result);
                }                
                components[i] = components[i].Replace(" ", "");
            }
            return components;
        }

        private List<double> CheckDomain(List<string> equation_components)
        {
            List<double> exceptions = new List<double>();
            for (int i = 0; i < equation_components.Count; i++)
            {
                if (equation_components[i].Contains("log")|| equation_components[i].Contains("√"))
                {
                    start_t = 0;
                }
            }
            return exceptions;
        }

        private List<double> SumComponentsList(List<List<double>> component_list)
        {
            for (int i = 1; i < component_list.Count; i++)
            {
                component_list[0] = component_list[0].Zip(component_list[i], (a, b) => (a + b)).ToList();
            }
            return component_list[0];
        }

        private FunctionSeries ProcessListIntoSeries(List<double> value_list)
        {
            FunctionSeries serie = new FunctionSeries();
            for (int i = 0; i < value_list.Count; i++)
            {
                double x = start_t + i * step_t;
                DataPoint data = new DataPoint(x, value_list[i]);
                serie.Points.Add(data);
            }
            return serie;
        }

        private double CalculateEquationResult()
        {
            equation = calculatorSystem.ProcessSpecialSigns(equation);
            var result = new DataTable().Compute(equation, null);
            return double.Parse(Convert.ToString(result));
        }

        private void SetGraphStyle()
        {
            function.StrokeThickness = 2;
            function_graph.Model = new PlotModel { Title = equation, TitleFont = "Arial", TitleFontSize = 20 };
            function_graph.Model.Axes.Add(new OxyPlot.Axes.LinearAxis{Title = "Y", TitleFont = "Arial", TitleFontSize = 16,
                                                             TitleFontWeight = FontWeights.Bold,Position = OxyPlot.Axes.AxisPosition.Left});
            function_graph.Model.Axes.Add(new OxyPlot.Axes.LinearAxis{Title = "X", TitleFont = "Arial", TitleFontSize = 16,
                                                             TitleFontWeight = FontWeights.Bold, Position = OxyPlot.Axes.AxisPosition.Bottom});
            UpdateGraphStyle(plot_style);
        }

        public void UpdateGraphStyle(string style)
        {
            plot_style = style;
            if (plot_style == "Default Style")
            {
                function_graph.Model.TextColor = OxyColors.Black;
                function_graph.Model.PlotAreaBorderColor = OxyColors.Black;
                function.Color = OxyColors.Black;
                this.BackColor = SystemColors.Info;
            }
            else if (plot_style == "Dark Style")
            {
                function_graph.Model.TextColor = OxyColors.White;
                function_graph.Model.PlotAreaBorderColor = OxyColors.White;
                function.Color = OxyColors.White;
                this.BackColor = System.Drawing.Color.FromArgb((int)((byte)(64)), (int)((byte)(64)), (int)(byte)(64));
            }
        }

    }
}
