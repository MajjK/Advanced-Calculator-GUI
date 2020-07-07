namespace Projekt3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonKropka = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMnoz = new System.Windows.Forms.Button();
            this.buttonDziel = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLicz = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.groupBoxAppStyle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClock = new System.Windows.Forms.ComboBox();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            this.groupBoxAppStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.Location = new System.Drawing.Point(21, 26);
            this.MainTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ReadOnly = true;
            this.MainTextBox.Size = new System.Drawing.Size(223, 166);
            this.MainTextBox.TabIndex = 0;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(112, 405);
            this.button0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 33);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 358);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 358);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 313);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(205, 313);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 270);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 33);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(112, 270);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 33);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(205, 270);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 33);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 313);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // buttonKropka
            // 
            this.buttonKropka.Location = new System.Drawing.Point(21, 405);
            this.buttonKropka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKropka.Name = "buttonKropka";
            this.buttonKropka.Size = new System.Drawing.Size(75, 33);
            this.buttonKropka.TabIndex = 11;
            this.buttonKropka.Text = ".";
            this.buttonKropka.UseVisualStyleBackColor = true;
            this.buttonKropka.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(293, 226);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 33);
            this.buttonDodaj.TabIndex = 13;
            this.buttonDodaj.Text = "+";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(205, 226);
            this.buttonMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(75, 33);
            this.buttonMin.TabIndex = 14;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // buttonMnoz
            // 
            this.buttonMnoz.Location = new System.Drawing.Point(112, 226);
            this.buttonMnoz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMnoz.Name = "buttonMnoz";
            this.buttonMnoz.Size = new System.Drawing.Size(75, 33);
            this.buttonMnoz.TabIndex = 15;
            this.buttonMnoz.Text = "*";
            this.buttonMnoz.UseVisualStyleBackColor = true;
            this.buttonMnoz.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // buttonDziel
            // 
            this.buttonDziel.Location = new System.Drawing.Point(21, 226);
            this.buttonDziel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDziel.Name = "buttonDziel";
            this.buttonDziel.Size = new System.Drawing.Size(75, 33);
            this.buttonDziel.TabIndex = 16;
            this.buttonDziel.Text = "/";
            this.buttonDziel.UseVisualStyleBackColor = true;
            this.buttonDziel.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(293, 270);
            this.buttonMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 33);
            this.buttonMod.TabIndex = 17;
            this.buttonMod.Text = "%";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.btnWasClicked);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(205, 405);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 33);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ClearClicked);
            // 
            // buttonLicz
            // 
            this.buttonLicz.Location = new System.Drawing.Point(293, 313);
            this.buttonLicz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLicz.Name = "buttonLicz";
            this.buttonLicz.Size = new System.Drawing.Size(75, 33);
            this.buttonLicz.TabIndex = 20;
            this.buttonLicz.Text = "=";
            this.buttonLicz.UseVisualStyleBackColor = true;
            this.buttonLicz.Click += new System.EventHandler(this.buttonLicz_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(325, 54);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(81, 32);
            this.labelTimer.TabIndex = 21;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxClock.Location = new System.Drawing.Point(315, 26);
            this.pictureBoxClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClock.TabIndex = 22;
            this.pictureBoxClock.TabStop = false;
            // 
            // groupBoxAppStyle
            // 
            this.groupBoxAppStyle.Controls.Add(this.label1);
            this.groupBoxAppStyle.Controls.Add(this.comboBoxClock);
            this.groupBoxAppStyle.Controls.Add(this.comboBoxStyle);
            this.groupBoxAppStyle.Location = new System.Drawing.Point(293, 390);
            this.groupBoxAppStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAppStyle.Name = "groupBoxAppStyle";
            this.groupBoxAppStyle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAppStyle.Size = new System.Drawing.Size(135, 98);
            this.groupBoxAppStyle.TabIndex = 23;
            this.groupBoxAppStyle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "App Style";
            // 
            // comboBoxClock
            // 
            this.comboBoxClock.FormattingEnabled = true;
            this.comboBoxClock.Items.AddRange(new object[] {
            "Digital Clock",
            "Analog Clock"});
            this.comboBoxClock.Location = new System.Drawing.Point(4, 66);
            this.comboBoxClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClock.Name = "comboBoxClock";
            this.comboBoxClock.Size = new System.Drawing.Size(116, 24);
            this.comboBoxClock.TabIndex = 1;
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Items.AddRange(new object[] {
            "Default Style",
            "Dark Style"});
            this.comboBoxStyle.Location = new System.Drawing.Point(4, 37);
            this.comboBoxStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(116, 24);
            this.comboBoxStyle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 495);
            this.Controls.Add(this.groupBoxAppStyle);
            this.Controls.Add(this.pictureBoxClock);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonLicz);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonDziel);
            this.Controls.Add(this.buttonMnoz);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonKropka);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.MainTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            this.groupBoxAppStyle.ResumeLayout(false);
            this.groupBoxAppStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonKropka;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMnoz;
        private System.Windows.Forms.Button buttonDziel;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLicz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.PictureBox pictureBoxClock;
        private System.Windows.Forms.GroupBox groupBoxAppStyle;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.ComboBox comboBoxClock;
        private System.Windows.Forms.Label label1;
    }
}

