namespace AdvancedCalculatorGUI
{
    partial class CalculatorGUI
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>

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
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTextBox = new System.Windows.Forms.TextBox();
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
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.styleComboBoxMenuStrip = new System.Windows.Forms.ToolStripComboBox();
            this.clockComboBoxMenuStrip = new System.Windows.Forms.ToolStripComboBox();
            this.settingsToolStripMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripPlotSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.startTextBoxToolStrip = new System.Windows.Forms.ToolStripTextBox();
            this.stopToolStripPlotSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTextBoxToolStrip = new System.Windows.Forms.ToolStripTextBox();
            this.stepToolStripPlotSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.stepTextBoxToolStrip = new System.Windows.Forms.ToolStripTextBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonBracket = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.BackColor = System.Drawing.Color.Wheat;
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTextBox.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTextBox.Location = new System.Drawing.Point(16, 35);
            this.mainTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.Size = new System.Drawing.Size(195, 81);
            this.mainTextBox.TabIndex = 0;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Wheat;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Arial", 12F);
            this.button0.Location = new System.Drawing.Point(82, 330);
            this.button0.Margin = new System.Windows.Forms.Padding(2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(56, 27);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Wheat;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F);
            this.button2.Location = new System.Drawing.Point(82, 294);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F);
            this.button1.Location = new System.Drawing.Point(14, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Wheat;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F);
            this.button3.Location = new System.Drawing.Point(150, 294);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Wheat;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 12F);
            this.button5.Location = new System.Drawing.Point(82, 259);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 27);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Wheat;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 12F);
            this.button6.Location = new System.Drawing.Point(150, 259);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 27);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Wheat;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(14, 224);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 27);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Wheat;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 12F);
            this.button8.Location = new System.Drawing.Point(82, 224);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 27);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Wheat;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 12F);
            this.button9.Location = new System.Drawing.Point(150, 224);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 27);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Wheat;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F);
            this.button4.Location = new System.Drawing.Point(14, 259);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.Wheat;
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(150, 330);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(56, 27);
            this.buttonDot.TabIndex = 11;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Wheat;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(218, 294);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 27);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.Color.Wheat;
            this.buttonSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.Location = new System.Drawing.Point(218, 259);
            this.buttonSub.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(56, 27);
            this.buttonSub.TabIndex = 14;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // buttonMult
            // 
            this.buttonMult.BackColor = System.Drawing.Color.Wheat;
            this.buttonMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMult.Location = new System.Drawing.Point(218, 224);
            this.buttonMult.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(56, 27);
            this.buttonMult.TabIndex = 15;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = false;
            this.buttonMult.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.Wheat;
            this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.Location = new System.Drawing.Point(218, 188);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(56, 27);
            this.buttonDiv.TabIndex = 16;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // buttonMod
            // 
            this.buttonMod.BackColor = System.Drawing.Color.Wheat;
            this.buttonMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.Location = new System.Drawing.Point(150, 188);
            this.buttonMod.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(56, 27);
            this.buttonMod.TabIndex = 17;
            this.buttonMod.Text = "%";
            this.buttonMod.UseVisualStyleBackColor = false;
            this.buttonMod.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Wheat;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(14, 329);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(56, 27);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "<=";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ProcessBackButton);
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.Wheat;
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalc.Location = new System.Drawing.Point(218, 330);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(56, 27);
            this.buttonCalc.TabIndex = 20;
            this.buttonCalc.Text = "=";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.ProcessCalcButton);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.ClockStyleUpdate);
            // 
            // labelTimer
            // 
            this.labelTimer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(231, 62);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(78, 26);
            this.labelTimer.TabIndex = 21;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxClock.Location = new System.Drawing.Point(235, 35);
            this.pictureBoxClock.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(74, 81);
            this.pictureBoxClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClock.TabIndex = 22;
            this.pictureBoxClock.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Wheat;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(218, 154);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 27);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ProcessClearButton);
            // 
            // buttonRoot
            // 
            this.buttonRoot.BackColor = System.Drawing.Color.Wheat;
            this.buttonRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoot.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoot.Location = new System.Drawing.Point(14, 154);
            this.buttonRoot.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(56, 27);
            this.buttonRoot.TabIndex = 25;
            this.buttonRoot.Text = "√";
            this.buttonRoot.UseVisualStyleBackColor = false;
            this.buttonRoot.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // buttonPower
            // 
            this.buttonPower.BackColor = System.Drawing.Color.Wheat;
            this.buttonPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPower.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPower.Location = new System.Drawing.Point(14, 189);
            this.buttonPower.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(56, 27);
            this.buttonPower.TabIndex = 26;
            this.buttonPower.Text = "^";
            this.buttonPower.UseVisualStyleBackColor = false;
            this.buttonPower.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenuStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(327, 26);
            this.menuStrip.TabIndex = 27;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuMenuStrip
            // 
            this.menuMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuStrip,
            this.settingsToolStripMenuStrip});
            this.menuMenuStrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMenuStrip.Name = "menuMenuStrip";
            this.menuMenuStrip.Size = new System.Drawing.Size(58, 22);
            this.menuMenuStrip.Text = "Menu";
            // 
            // styleToolStripMenuStrip
            // 
            this.styleToolStripMenuStrip.BackColor = System.Drawing.SystemColors.Info;
            this.styleToolStripMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleComboBoxMenuStrip,
            this.clockComboBoxMenuStrip});
            this.styleToolStripMenuStrip.Name = "styleToolStripMenuStrip";
            this.styleToolStripMenuStrip.Size = new System.Drawing.Size(180, 22);
            this.styleToolStripMenuStrip.Text = "Style";
            // 
            // styleComboBoxMenuStrip
            // 
            this.styleComboBoxMenuStrip.BackColor = System.Drawing.SystemColors.Info;
            this.styleComboBoxMenuStrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleComboBoxMenuStrip.Items.AddRange(new object[] {
            "Default Style",
            "Dark Style"});
            this.styleComboBoxMenuStrip.Name = "styleComboBoxMenuStrip";
            this.styleComboBoxMenuStrip.Size = new System.Drawing.Size(121, 26);
            // 
            // clockComboBoxMenuStrip
            // 
            this.clockComboBoxMenuStrip.BackColor = System.Drawing.SystemColors.Info;
            this.clockComboBoxMenuStrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockComboBoxMenuStrip.Items.AddRange(new object[] {
            "Digital Clock",
            "Analog Clock"});
            this.clockComboBoxMenuStrip.Margin = new System.Windows.Forms.Padding(1);
            this.clockComboBoxMenuStrip.Name = "clockComboBoxMenuStrip";
            this.clockComboBoxMenuStrip.Size = new System.Drawing.Size(121, 26);
            // 
            // settingsToolStripMenuStrip
            // 
            this.settingsToolStripMenuStrip.BackColor = System.Drawing.SystemColors.Info;
            this.settingsToolStripMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripPlotSetting,
            this.stopToolStripPlotSetting,
            this.stepToolStripPlotSetting});
            this.settingsToolStripMenuStrip.Name = "settingsToolStripMenuStrip";
            this.settingsToolStripMenuStrip.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuStrip.Text = "Plot Settings";
            // 
            // startToolStripPlotSetting
            // 
            this.startToolStripPlotSetting.AutoSize = false;
            this.startToolStripPlotSetting.BackColor = System.Drawing.SystemColors.Info;
            this.startToolStripPlotSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTextBoxToolStrip});
            this.startToolStripPlotSetting.Name = "startToolStripPlotSetting";
            this.startToolStripPlotSetting.Size = new System.Drawing.Size(100, 22);
            this.startToolStripPlotSetting.Text = "Start";
            this.startToolStripPlotSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startTextBoxToolStrip
            // 
            this.startTextBoxToolStrip.BackColor = System.Drawing.SystemColors.Info;
            this.startTextBoxToolStrip.Font = new System.Drawing.Font("Arial", 12F);
            this.startTextBoxToolStrip.Name = "startTextBoxToolStrip";
            this.startTextBoxToolStrip.Size = new System.Drawing.Size(50, 26);
            this.startTextBoxToolStrip.Text = "-5";
            this.startTextBoxToolStrip.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stopToolStripPlotSetting
            // 
            this.stopToolStripPlotSetting.AutoSize = false;
            this.stopToolStripPlotSetting.BackColor = System.Drawing.SystemColors.Info;
            this.stopToolStripPlotSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopTextBoxToolStrip});
            this.stopToolStripPlotSetting.Name = "stopToolStripPlotSetting";
            this.stopToolStripPlotSetting.Size = new System.Drawing.Size(100, 22);
            this.stopToolStripPlotSetting.Text = "Stop";
            this.stopToolStripPlotSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stopTextBoxToolStrip
            // 
            this.stopTextBoxToolStrip.BackColor = System.Drawing.SystemColors.Info;
            this.stopTextBoxToolStrip.Font = new System.Drawing.Font("Arial", 12F);
            this.stopTextBoxToolStrip.Name = "stopTextBoxToolStrip";
            this.stopTextBoxToolStrip.Size = new System.Drawing.Size(50, 26);
            this.stopTextBoxToolStrip.Text = "5";
            this.stopTextBoxToolStrip.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stepToolStripPlotSetting
            // 
            this.stepToolStripPlotSetting.AutoSize = false;
            this.stepToolStripPlotSetting.BackColor = System.Drawing.SystemColors.Info;
            this.stepToolStripPlotSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepTextBoxToolStrip});
            this.stepToolStripPlotSetting.Name = "stepToolStripPlotSetting";
            this.stepToolStripPlotSetting.Size = new System.Drawing.Size(100, 22);
            this.stepToolStripPlotSetting.Text = "Step";
            this.stepToolStripPlotSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stepTextBoxToolStrip
            // 
            this.stepTextBoxToolStrip.BackColor = System.Drawing.SystemColors.Info;
            this.stepTextBoxToolStrip.Font = new System.Drawing.Font("Arial", 12F);
            this.stepTextBoxToolStrip.Name = "stepTextBoxToolStrip";
            this.stepTextBoxToolStrip.Size = new System.Drawing.Size(50, 26);
            this.stepTextBoxToolStrip.Text = "0,1";
            this.stepTextBoxToolStrip.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.Wheat;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.Location = new System.Drawing.Point(150, 154);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(56, 27);
            this.buttonLog.TabIndex = 28;
            this.buttonLog.Text = "log";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.Color.Wheat;
            this.buttonSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSin.Location = new System.Drawing.Point(82, 154);
            this.buttonSin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(56, 27);
            this.buttonSin.TabIndex = 29;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // buttonBracket
            // 
            this.buttonBracket.BackColor = System.Drawing.Color.Wheat;
            this.buttonBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBracket.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBracket.Location = new System.Drawing.Point(82, 188);
            this.buttonBracket.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBracket.Name = "buttonBracket";
            this.buttonBracket.Size = new System.Drawing.Size(56, 27);
            this.buttonBracket.TabIndex = 30;
            this.buttonBracket.Text = "()";
            this.buttonBracket.UseVisualStyleBackColor = false;
            this.buttonBracket.Click += new System.EventHandler(this.ProcessBracketButton);
            // 
            // buttonDraw
            // 
            this.buttonDraw.BackColor = System.Drawing.Color.Wheat;
            this.buttonDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDraw.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDraw.Location = new System.Drawing.Point(155, 4);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(56, 27);
            this.buttonDraw.TabIndex = 31;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = false;
            this.buttonDraw.Click += new System.EventHandler(this.ProcessDrawButton);
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.Wheat;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.Location = new System.Drawing.Point(95, 4);
            this.buttonX.Margin = new System.Windows.Forms.Padding(2);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(56, 27);
            this.buttonX.TabIndex = 32;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.ProcessActionButton);
            // 
            // CalculatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(327, 382);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonBracket);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBoxClock);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDot);
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
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalculatorGUI";
            this.Text = "CalculatorGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBox;
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
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.PictureBox pictureBoxClock;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuStrip;
        private System.Windows.Forms.ToolStripComboBox styleComboBoxMenuStrip;
        private System.Windows.Forms.ToolStripComboBox clockComboBoxMenuStrip;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonBracket;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startToolStripPlotSetting;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripPlotSetting;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripPlotSetting;
        private System.Windows.Forms.ToolStripTextBox startTextBoxToolStrip;
        private System.Windows.Forms.ToolStripTextBox stopTextBoxToolStrip;
        private System.Windows.Forms.ToolStripTextBox stepTextBoxToolStrip;
        private System.Windows.Forms.Button buttonX;
    }
}

