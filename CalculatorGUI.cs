using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace AdvancedCalculatorGUI
{
    public partial class CalculatorGUI : Form
    {
        int clock_width = 100, clock_height = 100, center_x, center_y;
        string current_operation;
        Calculator calculatorSystem;
        FunctionPlotWindow plotWindow;

        public CalculatorGUI()
        {
            InitializeComponent();
            this.calculatorSystem = new Calculator();
            this.current_operation = mainTextBox.Text;
            this.center_x = clock_width / 2;
            this.center_y = clock_height / 2;
            styleComboBoxMenuStrip.SelectedItem = "Default Style";
            clockComboBoxMenuStrip.SelectedItem = "Digital Clock";
        }

        private void ProcessActionButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text_update = button.Text;

            if (int.TryParse(text_update, out _) || text_update == ".")
                UpdateDisplay(text_update);
            else if (mainTextBox.Text.Length > 0 && mainTextBox.Text.Substring(mainTextBox.Text.Length - 1, 1) == " ")
                UpdateDisplay(text_update + " ");
            else
                UpdateDisplay(" " + text_update + " ");           
        }

        private void UpdateDisplay(string update, Boolean replace = false)
        {
            if (mainTextBox.Text == "0" || replace)        
                mainTextBox.Text = update;
            
            else
                mainTextBox.Text += update;
            UpdateCurrentOperation();
        }

        private void UpdateCurrentOperation()
        {
            if (mainTextBox.Text.Contains("="))
                current_operation = mainTextBox.Text.Substring(mainTextBox.Text.LastIndexOf("=") + 2);
            else
                current_operation = mainTextBox.Text;
        }

        private void ProcessBracketButton(object sender, EventArgs e)
        {
            string bracket = "(";
            if (mainTextBox.Text.Length > 1)
            {
                int left_brackets = mainTextBox.Text.Count(x => x == '(');
                int right_brackets = mainTextBox.Text.Count(x => x == ')');
                string previous_char = mainTextBox.Text.Substring(mainTextBox.Text.Length - 1, 1);
                string previous_char2 = mainTextBox.Text.Substring(mainTextBox.Text.Length - 2, 1);
                if (left_brackets > right_brackets && (int.TryParse(previous_char, out _) || previous_char2.Equals(")")))
                    bracket = ")";
            }

            if (mainTextBox.Text.Length == 0 || mainTextBox.Text.Length > 0 && mainTextBox.Text.Substring(mainTextBox.Text.Length - 1, 1) == " ")
                UpdateDisplay(bracket + " ");
            else
                UpdateDisplay(" " + bracket + " ");
        }

        private void ProcessBackButton(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length > 1)
            {
                string char_to_delete = mainTextBox.Text.Substring(mainTextBox.Text.Length - 1, 1);
                string prev_char = mainTextBox.Text.Substring(mainTextBox.Text.Length - 2, 1);
                if (Char.IsLetter(prev_char, 0) && prev_char != "X")
                    mainTextBox.Text = mainTextBox.Text.Substring(0, mainTextBox.Text.Length - 4);
                else if (char_to_delete == " ")
                    mainTextBox.Text = mainTextBox.Text.Substring(0, mainTextBox.Text.Length - 3);
                else
                    mainTextBox.Text = mainTextBox.Text.Substring(0, mainTextBox.Text.Length - 1);

            }
            else
                mainTextBox.Text = ""; 
        }

        private void ProcessClearButton(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
        }

        private void ProcessCalcButton(object sender, EventArgs e)
        {      
            try
            {
                string operation = calculatorSystem.ProcessSpecialSigns(current_operation);
                var result = new DataTable().Compute(operation, null);
                UpdateDisplay(" = " + Convert.ToString(result), false);
            }
            catch (Exception error)
            {
                MessageBox.Show("Syntax Error !");
            }
        }

        private void ProcessDrawButton(object sender, EventArgs e)
        {
            try
            {
                this.plotWindow = new FunctionPlotWindow(current_operation, double.Parse(startTextBoxToolStrip.Text), double.Parse(stopTextBoxToolStrip.Text),
                                                    double.Parse(stepTextBoxToolStrip.Text.Replace(@".", ",")), (string)styleComboBoxMenuStrip.SelectedItem);
                this.plotWindow.Show();
            }
            catch
            {              
                MessageBox.Show("Syntex Error in Plot Settings !");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case Keys.NumPad0:
                    button0.PerformClick();
                    break;
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    break;
                case Keys.NumPad8:
                    button8.PerformClick();
                    break;
                case Keys.NumPad9:
                    button9.PerformClick();
                    break;
                case Keys.Decimal:
                    buttonDot.PerformClick();
                    break;
                case Keys.Multiply:
                    buttonMult.PerformClick();
                    break;
                case Keys.Divide:
                    buttonDiv.PerformClick();
                    break;
                case Keys.Add:
                    buttonAdd.PerformClick();
                    break;
                case Keys.Subtract:
                    buttonSub.PerformClick();
                    break;
                case Keys.D5 | Keys.Shift:
                    buttonMod.PerformClick();
                    break;
                case Keys.Back:
                    buttonBack.PerformClick();
                    break;
                case Keys.Delete:
                    buttonClear.PerformClick();
                    break;
                case Keys.Enter:
                    buttonCalc.PerformClick();
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ClockStyleUpdate(object sender, EventArgs e)
        {
            if ((string)styleComboBoxMenuStrip.SelectedItem == "Default Style")
            {
                AdvancedCalculatorGUI.Properties.Settings.Default.Style = "Default";
                SetStyle(SystemColors.Info, SystemColors.WindowText);
            }
            if ((string)styleComboBoxMenuStrip.SelectedItem == "Dark Style")
            {
                AdvancedCalculatorGUI.Properties.Settings.Default.Style = "Dark";
                SetStyle(System.Drawing.Color.FromArgb((int)((byte)(64)), (int)((byte)(64)), (int)(byte)(64)), SystemColors.MenuBar);
            }
            if ((string)clockComboBoxMenuStrip.SelectedItem == "Digital Clock")
                SetDigitalClock();
            if ((string)clockComboBoxMenuStrip.SelectedItem == "Analog Clock")
                SetAnalogClock();
            if (Application.OpenForms.Count > 1)
                this.plotWindow.UpdateGraphStyle((string)styleComboBoxMenuStrip.SelectedItem);
        }

        private void SetStyle(Color back_color, Color fore_color)
        {
            this.BackColor = back_color;
            pictureBoxClock.BackColor = back_color;
            menuStrip.BackColor = back_color;
            labelTimer.ForeColor = fore_color;
              
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                item.BackColor = back_color;
                item.ForeColor = fore_color;
                foreach (ToolStripMenuItem children in item.DropDownItems)
                {
                    children.BackColor = back_color;
                    children.ForeColor = fore_color;
                }
            }
            foreach (ToolStripMenuItem item in settingsToolStripMenuStrip.DropDownItems)
            {
                item.BackColor = back_color;
                item.ForeColor = fore_color;
                foreach (ToolStripTextBox children in item.DropDownItems)
                {
                    children.BackColor = back_color;
                    children.ForeColor = fore_color;
                }
            }
            foreach (ToolStripComboBox item in styleToolStripMenuStrip.DropDownItems)
            {
                item.BackColor = back_color;
                item.ForeColor = fore_color;
            }
            foreach (Control c in this.Controls)
            {
                UpdateColorControls(c);
            }
        }


        private void UpdateColorControls(Control ui_element)
        {
            if (ui_element is Button || ui_element is TextBox)
            {
                if (AdvancedCalculatorGUI.Properties.Settings.Default.Style == "Default")
                {
                    ui_element.BackColor = System.Drawing.Color.Wheat;
                    ui_element.ForeColor = SystemColors.ControlText;
                }
                else if (AdvancedCalculatorGUI.Properties.Settings.Default.Style == "Dark")
                {
                    ui_element.BackColor = SystemColors.GrayText;
                    ui_element.ForeColor = SystemColors.MenuBar;
                }
            }
            foreach (Control subC in ui_element.Controls)
            {
                UpdateColorControls(subC);
            }
        }

        private void SetDigitalClock()
        {
            int hour = DateTime.Now.Hour, minute = DateTime.Now.Minute, second = DateTime.Now.Second;
            string hour_string = "", minute_string = "", second_string = "";
            labelTimer.Visible = true;
            pictureBoxClock.Visible = false;
            if (hour < 10)
                hour_string += "0" + hour;
            else
                hour_string += hour;
            if (minute < 10)
                minute_string += "0" + minute;
            else
                minute_string += minute;
            if (second < 10)
                second_string += "0" + second;
            else
                second_string += second;
            labelTimer.Text = hour_string + ":" + minute_string + ":" + second_string;
        }

        private void SetAnalogClock()
        {
            int hour = DateTime.Now.Hour, minute = DateTime.Now.Minute, second = DateTime.Now.Second, second_hand_len = 45, minute_hand_len = 35, hour_hand_len = 25;
            int[] secCoord = new int[2], minCoord = new int[2], hourCoord = new int[2];
            Bitmap clock_bitmap = new Bitmap(clock_width + 1, clock_height + 1);
            Graphics clock_graphics = Graphics.FromImage(clock_bitmap);
            Brush clock_brush = Brushes.Black;
            Color clock_color = Color.Black;
            if (AdvancedCalculatorGUI.Properties.Settings.Default.Style == "Dark")
            {
                clock_brush = Brushes.White;
                clock_color = Color.White;
            }
            labelTimer.Visible = false;
            pictureBoxClock.Visible = true;

            secCoord = GetHandOfClockCoord(GetMinuteSecondRadianTimeValue(second), second_hand_len);
            minCoord = GetHandOfClockCoord(GetMinuteSecondRadianTimeValue(minute), minute_hand_len);
            hourCoord = GetHandOfClockCoord(GetHourRadianTimeValue(hour, minute), hour_hand_len);


            clock_graphics.Clear(this.BackColor);
            clock_graphics.DrawEllipse(new Pen(clock_color, 2f), 0, 0, clock_width, clock_height);
            clock_graphics.DrawString("12", new Font("Arial", 12, FontStyle.Bold), clock_brush, new PointF(39, 2));
            clock_graphics.DrawString("3", new Font("Arial", 12, FontStyle.Bold), clock_brush, new PointF(86, 39));
            clock_graphics.DrawString("6", new Font("Arial", 12, FontStyle.Bold), clock_brush, new PointF(43, 80));
            clock_graphics.DrawString("9", new Font("Arial", 12, FontStyle.Bold), clock_brush, new PointF(0, 39));
            clock_graphics.DrawLine(new Pen(Color.Red, 2f), new Point(center_x, center_y), new Point(secCoord[0], secCoord[1]));
            clock_graphics.DrawLine(new Pen(Color.Gray, 3f), new Point(center_x, center_y), new Point(minCoord[0], minCoord[1]));
            clock_graphics.DrawLine(new Pen(Color.Black, 4f), new Point(center_x, center_y), new Point(hourCoord[0], hourCoord[1]));
            pictureBoxClock.Image = clock_bitmap;
            clock_graphics.Dispose();
        }

        private int GetMinuteSecondRadianTimeValue (int time_value)
        {
            return time_value * 6;
        }

        private int GetHourRadianTimeValue(int hour, int minute)
        {
            return Convert.ToInt32((hour * 30 + minute / 2));
        }

        private int[] GetHandOfClockCoord(int radian_time_value, int time_hand_len)
        {
            int[] coord = new int[2];
            if (radian_time_value >= 0 && radian_time_value <= 180)
            {
                coord[0] = center_x + Convert.ToInt32((time_hand_len * Math.Sin(Math.PI * radian_time_value / 180)));
                coord[1] = center_y - Convert.ToInt32((time_hand_len * Math.Cos(Math.PI * radian_time_value / 180)));
            }
            else
            {
                coord[0] = center_x - Convert.ToInt32((time_hand_len * -Math.Sin(Math.PI * radian_time_value / 180)));
                coord[1] = center_y - Convert.ToInt32((time_hand_len * Math.Cos(Math.PI * radian_time_value / 180)));
            }
            return coord;
        }
    }
}
