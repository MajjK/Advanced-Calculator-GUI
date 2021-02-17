using System;
using System.Data;

namespace AdvancedCalculatorGUI
{
    class Calculator
    {
        public string ProcessSpecialSigns(string equation)
        {
            if (equation.Contains("(") && equation.Contains(")"))
                equation = this.CalculateBrackets(equation);
            if (equation.Contains("^"))
                equation = this.CalculateAdvancedMath(equation, "^");
            if (equation.Contains("√"))
                equation = this.CalculateAdvancedMath(equation, "√");
            if (equation.Contains("log"))
                equation = this.CalculateAdvancedMath(equation, "log");
            if (equation.Contains("sin"))
                equation = this.CalculateAdvancedMath(equation, "sin");
            return equation;
        }

        private string CalculateBrackets(string equation)
        {
            int bracket_left_index = equation.IndexOf("("), bracket_right_index = equation.IndexOf(")");
            int left_brackets_counter, right_brackets_counter;
            string bracketed_equation;

            while (bracket_left_index != -1)
            {
                left_brackets_counter = 0;
                right_brackets_counter = 0;
                for (int i = bracket_left_index; i < equation.Length; i++)
                {
                    if (equation.Substring(i, 1) == "(")
                        left_brackets_counter++;
                    if (equation.Substring(i, 1) == ")")
                        right_brackets_counter++;
                    if (left_brackets_counter == right_brackets_counter && equation.Substring(i, 1) == ")")
                        bracket_right_index = i;
                }

                bracketed_equation = equation.Substring(bracket_left_index + 2, bracket_right_index - bracket_left_index - 2);
                bracketed_equation = this.ProcessSpecialSigns(bracketed_equation);
                var value = new DataTable().Compute(bracketed_equation, null);
                equation = equation.Remove(bracket_left_index, bracket_right_index - bracket_left_index + 1);
                equation = equation.Insert(bracket_left_index, Convert.ToString(value));
                bracket_left_index = equation.IndexOf("(");
            }
            return equation;
        }

        private string CalculateAdvancedMath(string equation, string operation)
        {
            int operation_index = equation.IndexOf(operation);
            double basis, operand, value = 0;

            while (operation_index != -1)
            {
                basis = this.GetBasisValue(equation, operation_index - 2);
                operand = this.GetOperandValue(equation, operation_index + operation.Length + 1);

                if (operation == "^")
                    value = Math.Round(Math.Pow(basis, operand), 5);
                else if (operation == "√")
                    value = Math.Round(Math.Sqrt(operand), 5);
                else if (operation == "log" && basis == 1)
                    value = Math.Round(Math.Log(operand), 5);
                else if (operation == "log" && basis != 1)
                    value = Math.Round(Math.Log(operand, basis), 5);
                else if (operation == "sin")
                    value = Math.Round(Math.Sin(operand), 5);

                if (basis == 1)
                {
                    equation = equation.Remove(operation_index, operation.Length + operand.ToString().Length + 1);
                    equation = equation.Insert(operation_index, value.ToString() + " ");
                }
                else
                {
                    equation = equation.Remove(operation_index - 1 - basis.ToString().Length,
                                               basis.ToString().Length + operation.Length + operand.ToString().Length + 2);
                    equation = equation.Insert(operation_index - 1 - basis.ToString().Length,
                                               value.ToString() + " ");
                }
                operation_index = equation.IndexOf(operation);
            }
            return equation.Replace(@",", ".");
        }

        public double GetBasisValue(string operation, int string_index)
        {
            int i = 0;
            string basis;
            if (string_index < 0)
                return 1;
            else if (!double.TryParse(operation.Substring(string_index - i, 1), out _))
                return 1;
            while (true)
            {
                if (string_index - i == 0 || operation.Substring(string_index - i, 1) == " ")
                {
                    basis = operation.Substring(string_index - i, i + 1);
                    return Double.Parse(basis.Replace(@".", ","));
                }
                else
                    i++;
            }
        }

        public double GetOperandValue(string operation, int string_index)
        {
            int i = 0;
            string operand;
            while (true)
            {
                if (string_index + i == operation.Length - 1 || operation.Substring(string_index + i, 1) == " ")
                {
                    operand = operation.Substring(string_index, i + 1);
                    return Double.Parse(operand.Replace(@".", ","));
                }
                else
                    i++;
            }
        }
    }


}
