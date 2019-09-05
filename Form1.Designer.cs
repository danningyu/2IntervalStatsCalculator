namespace AngleCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.debugMessages = new System.Windows.Forms.TextBox();
            this.anglePlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.plotButton = new System.Windows.Forms.Button();
            this.YMaxLabel = new System.Windows.Forms.Label();
            this.XMaxLabel = new System.Windows.Forms.Label();
            this.XMinLabel = new System.Windows.Forms.Label();
            this.YMinLabel = new System.Windows.Forms.Label();
            this.XMaxBox = new System.Windows.Forms.TextBox();
            this.XMinBox = new System.Windows.Forms.TextBox();
            this.YMaxBox = new System.Windows.Forms.TextBox();
            this.YMinBox = new System.Windows.Forms.TextBox();
            this.intervalAvg = new System.Windows.Forms.Label();
            this.intervalAvgButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lowerBoundText = new System.Windows.Forms.TextBox();
            this.upperBoundText = new System.Windows.Forms.TextBox();
            this.intervalAvgTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IntervalStdDevTextBox = new System.Windows.Forms.TextBox();
            this.resetBoundsButton = new System.Windows.Forms.Button();
            this.matchIntervalBoundsButton = new System.Windows.Forms.Button();
            this.matchGraphBoundsButton = new System.Windows.Forms.Button();
            this.exportExcelDialog = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.interval2UncertText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upperBound2Text = new System.Windows.Forms.TextBox();
            this.lowerBound2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.interval2AvgText = new System.Windows.Forms.TextBox();
            this.matchBounds2Button = new System.Windows.Forms.Button();
            this.intervalSelectorBox = new System.Windows.Forms.ComboBox();
            this.diffTextBox = new System.Windows.Forms.TextBox();
            this.calcDiffButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.diffUncertBox = new System.Windows.Forms.TextBox();
            this.exportExcelButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anglePlot)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportDataToExcelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportDataToExcelToolStripMenuItem
            // 
            this.exportDataToExcelToolStripMenuItem.Name = "exportDataToExcelToolStripMenuItem";
            this.exportDataToExcelToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exportDataToExcelToolStripMenuItem.Text = "Export Results";
            this.exportDataToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportDataToExcelToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisionHistoryToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // revisionHistoryToolStripMenuItem
            // 
            this.revisionHistoryToolStripMenuItem.Name = "revisionHistoryToolStripMenuItem";
            this.revisionHistoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.revisionHistoryToolStripMenuItem.Text = "Revision History";
            this.revisionHistoryToolStripMenuItem.Click += new System.EventHandler(this.revisionHistoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog2.InitialDirectory = "C:\\\\";
            this.openFileDialog2.RestoreDirectory = true;
            this.openFileDialog2.Title = "Select a File";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // debugMessages
            // 
            this.debugMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debugMessages.Location = new System.Drawing.Point(0, 435);
            this.debugMessages.Multiline = true;
            this.debugMessages.Name = "debugMessages";
            this.debugMessages.ReadOnly = true;
            this.debugMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugMessages.Size = new System.Drawing.Size(915, 99);
            this.debugMessages.TabIndex = 6;
            this.debugMessages.TabStop = false;
            this.debugMessages.Text = "Diagnostic Messages:";
            this.debugMessages.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // anglePlot
            // 
            chartArea2.Name = "ChartArea1";
            this.anglePlot.ChartAreas.Add(chartArea2);
            this.anglePlot.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.anglePlot.Legends.Add(legend2);
            this.anglePlot.Location = new System.Drawing.Point(0, 24);
            this.anglePlot.Name = "anglePlot";
            this.anglePlot.Size = new System.Drawing.Size(915, 253);
            this.anglePlot.TabIndex = 7;
            this.anglePlot.Text = "chart1";
            title2.Name = "Angle Plot";
            title2.Text = "Angle Plot";
            this.anglePlot.Titles.Add(title2);
            this.anglePlot.Click += new System.EventHandler(this.anglePlot_Click);
            // 
            // plotButton
            // 
            this.plotButton.Location = new System.Drawing.Point(12, 283);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(60, 23);
            this.plotButton.TabIndex = 1;
            this.plotButton.Text = "Plot Data";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // YMaxLabel
            // 
            this.YMaxLabel.AutoSize = true;
            this.YMaxLabel.Location = new System.Drawing.Point(507, 288);
            this.YMaxLabel.Name = "YMaxLabel";
            this.YMaxLabel.Size = new System.Drawing.Size(33, 13);
            this.YMaxLabel.TabIndex = 10;
            this.YMaxLabel.Text = "Ymax";
            // 
            // XMaxLabel
            // 
            this.XMaxLabel.AutoSize = true;
            this.XMaxLabel.Location = new System.Drawing.Point(220, 289);
            this.XMaxLabel.Name = "XMaxLabel";
            this.XMaxLabel.Size = new System.Drawing.Size(33, 13);
            this.XMaxLabel.TabIndex = 11;
            this.XMaxLabel.Text = "Xmax";
            // 
            // XMinLabel
            // 
            this.XMinLabel.AutoSize = true;
            this.XMinLabel.Location = new System.Drawing.Point(78, 288);
            this.XMinLabel.Name = "XMinLabel";
            this.XMinLabel.Size = new System.Drawing.Size(30, 13);
            this.XMinLabel.TabIndex = 12;
            this.XMinLabel.Text = "Xmin";
            // 
            // YMinLabel
            // 
            this.YMinLabel.AutoSize = true;
            this.YMinLabel.Location = new System.Drawing.Point(365, 289);
            this.YMinLabel.Name = "YMinLabel";
            this.YMinLabel.Size = new System.Drawing.Size(30, 13);
            this.YMinLabel.TabIndex = 13;
            this.YMinLabel.Text = "Ymin";
            // 
            // XMaxBox
            // 
            this.XMaxBox.Location = new System.Drawing.Point(259, 286);
            this.XMaxBox.Name = "XMaxBox";
            this.XMaxBox.Size = new System.Drawing.Size(100, 20);
            this.XMaxBox.TabIndex = 3;
            // 
            // XMinBox
            // 
            this.XMinBox.Location = new System.Drawing.Point(114, 285);
            this.XMinBox.Name = "XMinBox";
            this.XMinBox.Size = new System.Drawing.Size(100, 20);
            this.XMinBox.TabIndex = 2;
            this.XMinBox.TextChanged += new System.EventHandler(this.XMinBox_TextChanged);
            // 
            // YMaxBox
            // 
            this.YMaxBox.Location = new System.Drawing.Point(546, 285);
            this.YMaxBox.Name = "YMaxBox";
            this.YMaxBox.Size = new System.Drawing.Size(100, 20);
            this.YMaxBox.TabIndex = 5;
            // 
            // YMinBox
            // 
            this.YMinBox.Location = new System.Drawing.Point(401, 286);
            this.YMinBox.Name = "YMinBox";
            this.YMinBox.Size = new System.Drawing.Size(100, 20);
            this.YMinBox.TabIndex = 4;
            // 
            // intervalAvg
            // 
            this.intervalAvg.AutoSize = true;
            this.intervalAvg.Location = new System.Drawing.Point(12, 350);
            this.intervalAvg.Name = "intervalAvg";
            this.intervalAvg.Size = new System.Drawing.Size(94, 13);
            this.intervalAvg.TabIndex = 7;
            this.intervalAvg.Text = "Interval 1 Average";
            // 
            // intervalAvgButton
            // 
            this.intervalAvgButton.Location = new System.Drawing.Point(12, 312);
            this.intervalAvgButton.Name = "intervalAvgButton";
            this.intervalAvgButton.Size = new System.Drawing.Size(111, 23);
            this.intervalAvgButton.TabIndex = 13;
            this.intervalAvgButton.Text = "Interval 1 Statistics";
            this.intervalAvgButton.UseVisualStyleBackColor = true;
            this.intervalAvgButton.Click += new System.EventHandler(this.intervalAvgButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Start";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "End";
            // 
            // lowerBoundText
            // 
            this.lowerBoundText.Location = new System.Drawing.Point(164, 315);
            this.lowerBoundText.Name = "lowerBoundText";
            this.lowerBoundText.Size = new System.Drawing.Size(100, 20);
            this.lowerBoundText.TabIndex = 18;
            // 
            // upperBoundText
            // 
            this.upperBoundText.Location = new System.Drawing.Point(302, 317);
            this.upperBoundText.Name = "upperBoundText";
            this.upperBoundText.Size = new System.Drawing.Size(100, 20);
            this.upperBoundText.TabIndex = 19;
            // 
            // intervalAvgTextBox
            // 
            this.intervalAvgTextBox.Location = new System.Drawing.Point(112, 347);
            this.intervalAvgTextBox.Name = "intervalAvgTextBox";
            this.intervalAvgTextBox.ReadOnly = true;
            this.intervalAvgTextBox.Size = new System.Drawing.Size(100, 20);
            this.intervalAvgTextBox.TabIndex = 14;
            this.intervalAvgTextBox.TabStop = false;
            this.intervalAvgTextBox.TextChanged += new System.EventHandler(this.intervalAvgTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Interval 1 Uncert.";
            // 
            // IntervalStdDevTextBox
            // 
            this.IntervalStdDevTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IntervalStdDevTextBox.Location = new System.Drawing.Point(310, 347);
            this.IntervalStdDevTextBox.Name = "IntervalStdDevTextBox";
            this.IntervalStdDevTextBox.ReadOnly = true;
            this.IntervalStdDevTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntervalStdDevTextBox.TabIndex = 15;
            this.IntervalStdDevTextBox.TabStop = false;
            this.IntervalStdDevTextBox.TextChanged += new System.EventHandler(this.IntervalStdDevTextBox_TextChanged);
            // 
            // resetBoundsButton
            // 
            this.resetBoundsButton.Location = new System.Drawing.Point(652, 284);
            this.resetBoundsButton.Name = "resetBoundsButton";
            this.resetBoundsButton.Size = new System.Drawing.Size(92, 23);
            this.resetBoundsButton.TabIndex = 6;
            this.resetBoundsButton.Text = "Reset Bounds";
            this.resetBoundsButton.UseVisualStyleBackColor = true;
            this.resetBoundsButton.Click += new System.EventHandler(this.resetBoundsButton_Click);
            // 
            // matchIntervalBoundsButton
            // 
            this.matchIntervalBoundsButton.Location = new System.Drawing.Point(750, 284);
            this.matchIntervalBoundsButton.Name = "matchIntervalBoundsButton";
            this.matchIntervalBoundsButton.Size = new System.Drawing.Size(87, 23);
            this.matchIntervalBoundsButton.TabIndex = 7;
            this.matchIntervalBoundsButton.Text = "Match Bounds";
            this.matchIntervalBoundsButton.UseVisualStyleBackColor = true;
            this.matchIntervalBoundsButton.Click += new System.EventHandler(this.matchIntervalBoundsButton_Click);
            // 
            // matchGraphBoundsButton
            // 
            this.matchGraphBoundsButton.Location = new System.Drawing.Point(12, 373);
            this.matchGraphBoundsButton.Name = "matchGraphBoundsButton";
            this.matchGraphBoundsButton.Size = new System.Drawing.Size(398, 23);
            this.matchGraphBoundsButton.TabIndex = 20;
            this.matchGraphBoundsButton.Text = "Match Graph X Bounds for Interval 1";
            this.matchGraphBoundsButton.UseVisualStyleBackColor = true;
            this.matchGraphBoundsButton.Click += new System.EventHandler(this.matchGraphBoundsButton_Click);
            // 
            // exportExcelDialog
            // 
            this.exportExcelDialog.DereferenceLinks = false;
            this.exportExcelDialog.Filter = "Excel File(*.xlsx)| *.xlsx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Interval 2 Statistics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // interval2UncertText
            // 
            this.interval2UncertText.BackColor = System.Drawing.SystemColors.Window;
            this.interval2UncertText.Location = new System.Drawing.Point(714, 347);
            this.interval2UncertText.Name = "interval2UncertText";
            this.interval2UncertText.ReadOnly = true;
            this.interval2UncertText.Size = new System.Drawing.Size(100, 20);
            this.interval2UncertText.TabIndex = 36;
            this.interval2UncertText.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Interval 2 Uncert.";
            // 
            // upperBound2Text
            // 
            this.upperBound2Text.Location = new System.Drawing.Point(706, 317);
            this.upperBound2Text.Name = "upperBound2Text";
            this.upperBound2Text.Size = new System.Drawing.Size(100, 20);
            this.upperBound2Text.TabIndex = 39;
            // 
            // lowerBound2
            // 
            this.lowerBound2.Location = new System.Drawing.Point(568, 315);
            this.lowerBound2.Name = "lowerBound2";
            this.lowerBound2.Size = new System.Drawing.Size(100, 20);
            this.lowerBound2.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Interval 2 Average";
            // 
            // interval2AvgText
            // 
            this.interval2AvgText.Location = new System.Drawing.Point(516, 347);
            this.interval2AvgText.Name = "interval2AvgText";
            this.interval2AvgText.Size = new System.Drawing.Size(100, 20);
            this.interval2AvgText.TabIndex = 42;
            // 
            // matchBounds2Button
            // 
            this.matchBounds2Button.Location = new System.Drawing.Point(419, 373);
            this.matchBounds2Button.Name = "matchBounds2Button";
            this.matchBounds2Button.Size = new System.Drawing.Size(398, 23);
            this.matchBounds2Button.TabIndex = 43;
            this.matchBounds2Button.Text = "Match Graph X Bounds for Interval 2";
            this.matchBounds2Button.UseVisualStyleBackColor = true;
            this.matchBounds2Button.Click += new System.EventHandler(this.matchBounds2Button_Click);
            // 
            // intervalSelectorBox
            // 
            this.intervalSelectorBox.FormattingEnabled = true;
            this.intervalSelectorBox.Items.AddRange(new object[] {
            "Interval 1",
            "Interval 2"});
            this.intervalSelectorBox.Location = new System.Drawing.Point(843, 286);
            this.intervalSelectorBox.Name = "intervalSelectorBox";
            this.intervalSelectorBox.Size = new System.Drawing.Size(67, 21);
            this.intervalSelectorBox.TabIndex = 45;
            this.intervalSelectorBox.SelectedIndexChanged += new System.EventHandler(this.intervalSelectorBox_SelectedIndexChanged);
            // 
            // diffTextBox
            // 
            this.diffTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.diffTextBox.Location = new System.Drawing.Point(207, 404);
            this.diffTextBox.Name = "diffTextBox";
            this.diffTextBox.ReadOnly = true;
            this.diffTextBox.Size = new System.Drawing.Size(100, 20);
            this.diffTextBox.TabIndex = 46;
            this.diffTextBox.TabStop = false;
            // 
            // calcDiffButton
            // 
            this.calcDiffButton.Location = new System.Drawing.Point(15, 402);
            this.calcDiffButton.Name = "calcDiffButton";
            this.calcDiffButton.Size = new System.Drawing.Size(128, 23);
            this.calcDiffButton.TabIndex = 47;
            this.calcDiffButton.Text = "Calculate Difference";
            this.calcDiffButton.UseVisualStyleBackColor = true;
            this.calcDiffButton.Click += new System.EventHandler(this.calcDiffButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Difference";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Difference Uncert.";
            // 
            // diffUncertBox
            // 
            this.diffUncertBox.BackColor = System.Drawing.SystemColors.Window;
            this.diffUncertBox.Location = new System.Drawing.Point(410, 404);
            this.diffUncertBox.Name = "diffUncertBox";
            this.diffUncertBox.ReadOnly = true;
            this.diffUncertBox.Size = new System.Drawing.Size(100, 20);
            this.diffUncertBox.TabIndex = 50;
            this.diffUncertBox.TabStop = false;
            // 
            // exportExcelButton
            // 
            this.exportExcelButton.Location = new System.Drawing.Point(516, 402);
            this.exportExcelButton.Name = "exportExcelButton";
            this.exportExcelButton.Size = new System.Drawing.Size(298, 23);
            this.exportExcelButton.TabIndex = 51;
            this.exportExcelButton.Text = "Export Results to Excel";
            this.exportExcelButton.UseVisualStyleBackColor = true;
            this.exportExcelButton.Click += new System.EventHandler(this.exportExcelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 534);
            this.Controls.Add(this.exportExcelButton);
            this.Controls.Add(this.diffUncertBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calcDiffButton);
            this.Controls.Add(this.diffTextBox);
            this.Controls.Add(this.intervalSelectorBox);
            this.Controls.Add(this.matchBounds2Button);
            this.Controls.Add(this.interval2AvgText);
            this.Controls.Add(this.interval2UncertText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upperBound2Text);
            this.Controls.Add(this.lowerBound2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matchGraphBoundsButton);
            this.Controls.Add(this.matchIntervalBoundsButton);
            this.Controls.Add(this.resetBoundsButton);
            this.Controls.Add(this.YMaxBox);
            this.Controls.Add(this.YMaxLabel);
            this.Controls.Add(this.YMinBox);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.YMinLabel);
            this.Controls.Add(this.XMaxBox);
            this.Controls.Add(this.XMaxLabel);
            this.Controls.Add(this.XMinBox);
            this.Controls.Add(this.IntervalStdDevTextBox);
            this.Controls.Add(this.XMinLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.intervalAvgTextBox);
            this.Controls.Add(this.upperBoundText);
            this.Controls.Add(this.lowerBoundText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intervalAvgButton);
            this.Controls.Add(this.intervalAvg);
            this.Controls.Add(this.anglePlot);
            this.Controls.Add(this.debugMessages);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Angle Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anglePlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox debugMessages;
        private System.Windows.Forms.DataVisualization.Charting.Chart anglePlot;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Label YMaxLabel;
        private System.Windows.Forms.Label XMaxLabel;
        private System.Windows.Forms.Label XMinLabel;
        private System.Windows.Forms.Label YMinLabel;
        private System.Windows.Forms.TextBox XMaxBox;
        private System.Windows.Forms.TextBox XMinBox;
        private System.Windows.Forms.TextBox YMaxBox;
        private System.Windows.Forms.TextBox YMinBox;
        private System.Windows.Forms.Label intervalAvg;
        private System.Windows.Forms.Button intervalAvgButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lowerBoundText;
        private System.Windows.Forms.TextBox upperBoundText;
        private System.Windows.Forms.TextBox intervalAvgTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IntervalStdDevTextBox;
        private System.Windows.Forms.Button resetBoundsButton;
        private System.Windows.Forms.Button matchIntervalBoundsButton;
        private System.Windows.Forms.Button matchGraphBoundsButton;
        private System.Windows.Forms.ToolStripMenuItem exportDataToExcelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportExcelDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox interval2UncertText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox upperBound2Text;
        private System.Windows.Forms.TextBox lowerBound2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox interval2AvgText;
        private System.Windows.Forms.Button matchBounds2Button;
        private System.Windows.Forms.ComboBox intervalSelectorBox;
        private System.Windows.Forms.TextBox diffTextBox;
        private System.Windows.Forms.Button calcDiffButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox diffUncertBox;
        private System.Windows.Forms.Button exportExcelButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}

