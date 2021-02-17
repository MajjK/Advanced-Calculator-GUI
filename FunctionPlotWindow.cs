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
        PlotView function_plot_view;
        FunctionSeries function;

        public FunctionPlotWindow(string text_box, double start, double stop, double step, string style)
        {
            InitializeComponent();
            this.equation = text_box;
            this.start_t = start;
            this.stop_t = stop;
            this.step_t = step;
            this.plot_style = style;
        }

        private void FunctionPlotWindow_Load(object sender, EventArgs e)
        {
            this.function_plot_view = new PlotView { Location = new Point(25, 25) , Size = new Size(550, 300) };
            try
            {
                this.function = GetFunction();
                SetGraphStyle();
                function_plot_view.Model.Series.Add(function);
                this.Controls.Add(function_plot_view);
                string a = function_plot_view.Name;
                string b = function_plot_view.Model.Title;
            }
            catch (Exception error)
            {
                MessageBox.Show("Syntax Error ! You Can Draw Only Non-Complex Functions Without Brackets!");
            }
        }

        private FunctionSeries GetFunction()
        {
            if (equation.Contains("X"))
                return GetComponentsSeries(equation);
            else
                return GetResultSeries(equation);         
        }
        
        private FunctionSeries GetComponentsSeries(string function_formula)
        {
            List<List<double>> components_data = AnalyzeFunction(function_formula);
            List<double> summed_data = SumComponentsList(components_data);
            return ProcessListIntoSeries(summed_data);
        }

        private FunctionSeries GetResultSeries(string function_formula)
        {
            List<double> value_list = new List<double>();
            double operation_result = CalculateEquationResult(function_formula);
            for (double x = start_t; x < stop_t; x += step_t)
            {
                value_list.Add(operation_result);
            }
            return ProcessListIntoSeries(value_list);
        }

        private List<List<double>> AnalyzeFunction(string function_formula)
        {
            List<List<double>> components_values = new List<List<double>>();
            Calculator calculator = new Calculator();
            List<string> components = PreProcessFormula(calculator, function_formula);
            List<double> domain_exceptions = CheckDomain(components);
            string operation, sign;
            int x_index, x_power;
            double multiplication;
 
            for (int i = 0; i < components.Count; i++) 
            {
                operation = "";
                sign = "+";
                x_index = components[i].IndexOf("X");
                x_power = 1;
                multiplication = 1;

                if (x_index == -1)
                {
                    components_values.Add(GetConstantComponentData(domain_exceptions, components[i]));
                    continue;
                }

                if (x_index + 1 < components[i].Length)
                {
                    if (components[i].Substring(x_index + 1, 1) == "^")
                    {
                        operation = "^";
                        x_power = (int)calculator.GetOperandValue(components[i], x_index + 2);
                    }
                    else if (components[i].Substring(x_index + 1, 1) == "/")
                    {
                        multiplication /= calculator.GetOperandValue(components[i], x_index + 2);
                    }
                }               

                if (CheckIndexScope(x_index - 1))
                {
                    sign = CheckMinus(components[i], x_index - 1);
                    multiplication *= CheckMultiplication(calculator, components[i], x_index - 1);

                    if (components[i].Substring(x_index - 1, 1) == "/")
                    {
                        operation = "/";
                        multiplication *= calculator.GetBasisValue(components[i], x_index - 2);
                    }
                    else if (components[i].Substring(x_index - 1, 1) == "√")
                    {
                        operation = "√";
                        if (CheckIndexScope(x_index - 2))
                        {
                            sign = CheckMinus(components[i], x_index - 2);
                            multiplication = CheckMultiplication(calculator, components[i], x_index - 2);
                        }
                    }
                }

                if (CheckIndexScope(x_index - 3))
                {
                    if (components[i].Substring(x_index - 3, 3) == "sin")
                    {
                        operation = "sin";
                        if (CheckIndexScope(x_index - 4))
                        {
                            sign = CheckMinus(components[i], x_index - 4);
                            multiplication *= CheckMultiplication(calculator, components[i], x_index - 4);
                        }
                    }
                    else if (components[i].Substring(x_index - 3, 3) == "log")
                    {
                        operation = "log";
                        if (CheckIndexScope(x_index - 4))
                        {
                            sign = CheckMinus(components[i], x_index - 4);
                            multiplication *= CheckMultiplication(calculator, components[i], x_index - 4);
                        }
                    }
                }
                components_values.Add(GetComponentData(domain_exceptions, operation, sign, x_power, multiplication));           
            }
            return components_values;
        }

        private List<double> GetConstantComponentData(List<double> exceptions, string value)
        {
            List<double> data = new List<double>();
            for (double x = start_t; x < stop_t; x += step_t)
            {
                if (exceptions.Contains(Math.Round(x, 5)))
                    continue;
                data.Add(Double.Parse(value));
            }
            return data;
        }

        private List<double> GetComponentData(List<double> exceptions, string operation, string sign, int power, double multiplication)
        {
            List<double> data = new List<double>();

            for (double x = start_t; x < stop_t; x += step_t)
            {
                if (exceptions.Contains(Math.Round(x, 5)))
                    continue;
                double value = x;
                if (operation == "^")
                    value = Math.Pow(value, power);
                if (operation == "√")
                    value = Math.Sqrt(x);
                if (operation == "sin")
                    value = Math.Sin(x);
                if (operation == "log")
                    value = Math.Log(x);
                if (operation == "/")
                    value = 1 / x;
                if (sign == "-")
                    value = -1 * value;
                value *= multiplication;               
                data.Add(value);
            }
            return data;
        }

        private List<string> PreProcessFormula(Calculator calculatorSystem, string formula)
        {
            formula = formula.Replace("-", "+ - ");
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

        private List<double> CheckDomain(List<string> formula_components)
        {
            List<double> exceptions = new List<double>();
            for (int i = 0; i < formula_components.Count; i++)
            {
                if (formula_components[i].Contains("log") || formula_components[i].Contains("√"))
                {
                    start_t = 0;
                }
                if (formula_components[i].Contains("/X") || formula_components[i].Contains("log"))
                {
                    exceptions.Add(0);
                }
            }
            return exceptions;
        }

        private bool CheckIndexScope(int check_index)
        {
            if (check_index > -1)
                return true;
            return false;
        }

        private string CheckMinus(string component, int check_index)
        {
            if (component.Substring(check_index, 1) == "-")
                return "-";
            return "";
        }

        private double CheckMultiplication(Calculator calculator_system,  string component, int check_index)
        {
            if (component.Substring(check_index, 1) == "*")
                return calculator_system.GetBasisValue(component, check_index - 1);
            return 1;
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

        private double CalculateEquationResult(string equation)
        {
            Calculator calculator = new Calculator();
            equation = calculator.ProcessSpecialSigns(equation);
            var result = new DataTable().Compute(equation, null);
            return double.Parse(Convert.ToString(result));
        }

        private void SetGraphStyle()
        {
            function.StrokeThickness = 2;
            function_plot_view.Model = new PlotModel {Title = this.equation, TitleFontSize = 20};
            function_plot_view.Model.Axes.Add(new OxyPlot.Axes.LinearAxis{Title = "Y", TitleFont = "Arial", TitleFontSize = 16,
                                                             TitleFontWeight = FontWeights.Bold,Position = OxyPlot.Axes.AxisPosition.Left});
            function_plot_view.Model.Axes.Add(new OxyPlot.Axes.LinearAxis{Title = "X", TitleFont = "Arial", TitleFontSize = 16,
                                                             TitleFontWeight = FontWeights.Bold, Position = OxyPlot.Axes.AxisPosition.Bottom});
            UpdateGraphStyle(plot_style);
        }

        public void UpdateGraphStyle(string style)
        {
            plot_style = style;
            if (plot_style == "Default Style" && function_plot_view.Model != null)
            {
                function_plot_view.Model.TextColor = OxyColors.Black;
                function_plot_view.Model.PlotAreaBorderColor = OxyColors.Black;
                function.Color = OxyColors.Black;
                this.BackColor = SystemColors.Info;
            }
            else if (plot_style == "Dark Style" && function_plot_view.Model != null)
            {
                function_plot_view.Model.TextColor = OxyColors.White;
                function_plot_view.Model.PlotAreaBorderColor = OxyColors.White;
                function.Color = OxyColors.White;
                this.BackColor = System.Drawing.Color.FromArgb((int)((byte)(64)), (int)((byte)(64)), (int)(byte)(64));
            }
        }

    }
}
