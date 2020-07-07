using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3
{
    public partial class Form1 : Form
    {
        int Clk_WIDTH = 100, Clk_HEIGHT = 100, secH = 45, minH = 35, hrH = 25;
        int center_x, center_y;
        Bitmap bmp;
        Graphics g;


        public Form1()
        {
            InitializeComponent();

            comboBoxStyle.SelectedIndex = 0;
            comboBoxClock.SelectedIndex = 0;

            bmp = new Bitmap(Clk_WIDTH + 1, Clk_HEIGHT + 1);
            center_x = Clk_WIDTH / 2;
            center_y = Clk_HEIGHT / 2;
        }

        private void btnWasClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string TextUpdate = button.Text;

            if (TextUpdate == "*" || TextUpdate == "/" || TextUpdate == "+" || TextUpdate == "-" || TextUpdate == "%")
            {
                updateDisplay(" " + TextUpdate + " ");
            }
            else
            {
                updateDisplay(TextUpdate);
            }
        }

        public void ClearClicked(object sender, EventArgs e)
        {
            bool Deleted = false;
            while (MainTextBox.Text.Length > 0)
            {
                string nextChar = MainTextBox.Text.Substring(MainTextBox.Text.Length - 1);

                if (nextChar != " ")
                {
                    if (Deleted)
                       break;
                    Deleted = true;
                }
                MainTextBox.Text = MainTextBox.Text.Substring(0, MainTextBox.Text.Length - 1);
            }
        }

        public void PlusMinusClicked(object sender, EventArgs e)
        {
            bool Deleted = false;
            while (MainTextBox.Text.Length > 0)
            {
                string nextChar = MainTextBox.Text.Substring(MainTextBox.Text.Length - 1);

                if (nextChar != " ")
                {
                    if (Deleted)
                        break;
                    Deleted = true;
                }

                MainTextBox.Text = MainTextBox.Text.Substring(0, MainTextBox.Text.Length - 1);
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            String input = MainTextBox.Text;

            try
            {
                var something = new DataTable().Compute(input, null);
                MainTextBox.Text = Convert.ToString(something);
            }
            catch (Exception error)
            {
                MessageBox.Show("Syntax Error !");
            }

        }

        private void updateDisplay(string Update, Boolean replace = false)
        {
            if (MainTextBox.Text == "0" || replace)
            {
                MainTextBox.Text = Update;
            }
            else
            {
                MainTextBox.Text += Update;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.NumPad0))
                this.button0.PerformClick();
            else if (keyData == (Keys.NumPad1))
                this.button1.PerformClick();
            else if (keyData == (Keys.NumPad2))
                this.button2.PerformClick();
            else if (keyData == (Keys.NumPad3))
                this.button3.PerformClick();
            else if (keyData == (Keys.NumPad4))
                this.button4.PerformClick();
            else if (keyData == (Keys.NumPad5))
                this.button5.PerformClick();
            else if (keyData == (Keys.NumPad6))
                this.button6.PerformClick();
            else if (keyData == (Keys.NumPad7))
                this.button7.PerformClick();
            else if (keyData == (Keys.NumPad8))
                this.button8.PerformClick();
            else if (keyData == (Keys.NumPad9))
                this.button9.PerformClick();
            else if (keyData == (Keys.Decimal))
                this.buttonDot.PerformClick();
            else if (keyData == (Keys.Multiply))
                this.buttonMnoz.PerformClick();
            else if (keyData == (Keys.Divide))
                this.buttonDiv.PerformClick();
            else if (keyData == (Keys.Add))
                this.buttonAdd.PerformClick();
            else if (keyData == (Keys.Subtract))
                this.buttonSub.PerformClick();
            else if (keyData == (Keys.D5 | Keys.Shift))
                this.buttonMod.PerformClick();
            else if (keyData == (Keys.Delete))
                this.buttonClear.PerformClick();
            else if (keyData == (Keys.Enter))
                this.buttonCalc.PerformClick();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            if (comboBoxStyle.SelectedItem == "Default Style")
            {
                Projekt3.Properties.Settings.Default.Style = "Default";
                this.BackColor = SystemColors.Control;
                this.pictureBoxClock.BackColor = SystemColors.Control;
                foreach (Control c in this.Controls)
                {
                    UpdateColorControls(c);
                }
            }
            if (comboBoxStyle.SelectedItem == "Dark Style")
            {
                Projekt3.Properties.Settings.Default.Style = "Dark";
                this.BackColor = SystemColors.ControlDarkDark;
                this.pictureBoxClock.BackColor = SystemColors.ControlDarkDark;
                foreach (Control c in this.Controls)
                {
                    UpdateColorControls(c);
                }
            }
            if (comboBoxClock.SelectedItem == "Digital Clock")
            {
                labelTimer.Visible = true;
                pictureBoxClock.Visible = false;
                string time = "";

                if (h < 10)
                    time += "0" + h;
                else
                    time += h;
                time += ":";

                if (m < 10)
                    time += "0" + m;
                else
                    time += m;
                time += ":";

                if (s < 10)
                    time += "0" + s;
                else
                    time += s;

                labelTimer.Text = time;
            }

            if (comboBoxClock.SelectedItem == "Analog Clock")
            {
                int[] secCoord = new int[2];
                int[] minCoord = new int[2];
                int[] hourCoord = new int[2];

                pictureBoxClock.Visible = true;
                labelTimer.Visible = false;
                g = Graphics.FromImage(bmp);

                secCoord = msCoord(s, secH);
                minCoord = msCoord(m, minH);
                hourCoord = hrCoord(h % 12, m, hrH);

                g.Clear(this.BackColor);
                g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, Clk_WIDTH, Clk_HEIGHT);
          
                g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(39, 2));
                g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(86, 39));
                g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(43, 80));
                g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 39));

                g.DrawLine(new Pen(Color.Red, 1f), new Point(center_x, center_y), new Point(secCoord[0], secCoord[1]));
                g.DrawLine(new Pen(Color.Gray, 2f), new Point(center_x, center_y), new Point(minCoord[0], minCoord[1]));
                g.DrawLine(new Pen(Color.Black, 3f), new Point(center_x, center_y), new Point(hourCoord[0], hourCoord[1]));

                pictureBoxClock.Image = bmp;
                g.Dispose();
            }

        }

        public void UpdateColorControls(Control myControl)
        {
            if (myControl is Button)
            {
                if (Projekt3.Properties.Settings.Default.Style == "Default")
                {
                    myControl.BackColor = SystemColors.ControlLight;
                }
                else if (Projekt3.Properties.Settings.Default.Style == "Dark")
                {
                    myControl.BackColor = SystemColors.ControlDark;
                }
            }
            if (myControl is TextBox)
            {
                if (Projekt3.Properties.Settings.Default.Style == "Default")
                {
                    myControl.BackColor = SystemColors.Control;
                }
                else if (Projekt3.Properties.Settings.Default.Style == "Dark")
                {
                    myControl.BackColor = SystemColors.ControlDark;
                }
            }

            foreach (Control subC in myControl.Controls)
            {
                UpdateColorControls(subC);
            }
        }

        private int[] msCoord(int Value, int hlen)
        {
            int[] coord = new int[2];
            Value = Value * 6;  

            if (Value >= 0 && Value <= 180)
            {
                coord[0] = center_x + Convert.ToInt32((hlen * Math.Sin(Math.PI * Value / 180)));
                coord[1] = center_y - Convert.ToInt32((hlen * Math.Cos(Math.PI * Value / 180)));
            }
            else
            {
                coord[0] = center_x - Convert.ToInt32((hlen * -Math.Sin(Math.PI * Value / 180)));
                coord[1] = center_y - Convert.ToInt32((hlen * Math.Cos(Math.PI * Value / 180)));
            }
            return coord;
        }

        private int[] hrCoord(int H_Value, int M_Value, int hlen)
        {
            int[] coord = new int[2];
            int Value = Convert.ToInt32(( H_Value*30 + M_Value/2 ));

            if (Value >= 0 && Value <= 180)
            {
                coord[0] = center_x + Convert.ToInt32((hlen * Math.Sin(Math.PI * Value / 180)));
                coord[1] = center_y - Convert.ToInt32((hlen * Math.Cos(Math.PI * Value / 180)));
            }
            else
            {
                coord[0] = center_x - Convert.ToInt32((hlen * -Math.Sin(Math.PI * Value / 180)));
                coord[1] = center_y - Convert.ToInt32((hlen * Math.Cos(Math.PI * Value / 180)));
            }
            return coord;
        }
    }
}
