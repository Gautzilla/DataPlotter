﻿namespace DataPlotter.Forms
{
    partial class Chart
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
            this.panelChartName = new System.Windows.Forms.Panel();
            this.tableLayoutPanelChartName = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxChartName = new System.Windows.Forms.TextBox();
            this.labelChartName = new System.Windows.Forms.Label();
            this.tableLayoutPanelChartGlobals = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelChartSize = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelChartHeight = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxChartHeight = new System.Windows.Forms.TextBox();
            this.labelChartHeight = new System.Windows.Forms.Label();
            this.labelChartWidth = new System.Windows.Forms.Label();
            this.tableLayoutPanelChartWidth = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxChartWidth = new System.Windows.Forms.TextBox();
            this.panelTicks = new System.Windows.Forms.Panel();
            this.gridTickSelectorYAxisTicks = new DataPlotter.UserControls.GridTickSelector();
            this.gridTickSelectorXAxisTicks = new DataPlotter.UserControls.GridTickSelector();
            this.panelLegend = new System.Windows.Forms.Panel();
            this.legendDisplay = new DataPlotter.UserControls.LegendDisplay();
            this.panelDependantVariable = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDependantVariableName = new System.Windows.Forms.TextBox();
            this.labelDependantVariableName = new System.Windows.Forms.Label();
            this.panelRegression = new System.Windows.Forms.Panel();
            this.checkBoxRegression = new System.Windows.Forms.CheckBox();
            this.panelAxisRanges = new System.Windows.Forms.Panel();
            this.axisRangeY = new DataPlotter.UserControls.AxisRange();
            this.axisRangeX = new DataPlotter.UserControls.AxisRange();
            this.panelChartName.SuspendLayout();
            this.tableLayoutPanelChartName.SuspendLayout();
            this.tableLayoutPanelChartGlobals.SuspendLayout();
            this.tableLayoutPanelChartSize.SuspendLayout();
            this.tableLayoutPanelChartHeight.SuspendLayout();
            this.tableLayoutPanelChartWidth.SuspendLayout();
            this.panelTicks.SuspendLayout();
            this.panelLegend.SuspendLayout();
            this.panelDependantVariable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelRegression.SuspendLayout();
            this.panelAxisRanges.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChartName
            // 
            this.panelChartName.Controls.Add(this.tableLayoutPanelChartName);
            this.panelChartName.Controls.Add(this.labelChartName);
            this.panelChartName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.panelChartName.Location = new System.Drawing.Point(3, 3);
            this.panelChartName.Name = "panelChartName";
            this.panelChartName.Size = new System.Drawing.Size(394, 52);
            this.panelChartName.TabIndex = 0;
            // 
            // tableLayoutPanelChartName
            // 
            this.tableLayoutPanelChartName.ColumnCount = 1;
            this.tableLayoutPanelChartName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChartName.Controls.Add(this.textBoxChartName, 0, 1);
            this.tableLayoutPanelChartName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChartName.Location = new System.Drawing.Point(139, 0);
            this.tableLayoutPanelChartName.Name = "tableLayoutPanelChartName";
            this.tableLayoutPanelChartName.RowCount = 3;
            this.tableLayoutPanelChartName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartName.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelChartName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartName.Size = new System.Drawing.Size(255, 52);
            this.tableLayoutPanelChartName.TabIndex = 1;
            // 
            // textBoxChartName
            // 
            this.textBoxChartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxChartName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChartName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChartName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxChartName.Location = new System.Drawing.Point(3, 16);
            this.textBoxChartName.Name = "textBoxChartName";
            this.textBoxChartName.Size = new System.Drawing.Size(249, 19);
            this.textBoxChartName.TabIndex = 1;
            this.textBoxChartName.TextChanged += new System.EventHandler(this.textBoxChartName_TextChanged);
            // 
            // labelChartName
            // 
            this.labelChartName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelChartName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelChartName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelChartName.Location = new System.Drawing.Point(0, 0);
            this.labelChartName.Name = "labelChartName";
            this.labelChartName.Size = new System.Drawing.Size(139, 52);
            this.labelChartName.TabIndex = 0;
            this.labelChartName.Text = "Chart Name:";
            this.labelChartName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelChartGlobals
            // 
            this.tableLayoutPanelChartGlobals.ColumnCount = 2;
            this.tableLayoutPanelChartGlobals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelChartGlobals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChartGlobals.Controls.Add(this.panelChartName, 0, 0);
            this.tableLayoutPanelChartGlobals.Controls.Add(this.tableLayoutPanelChartSize, 1, 0);
            this.tableLayoutPanelChartGlobals.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelChartGlobals.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelChartGlobals.Name = "tableLayoutPanelChartGlobals";
            this.tableLayoutPanelChartGlobals.RowCount = 1;
            this.tableLayoutPanelChartGlobals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChartGlobals.Size = new System.Drawing.Size(1024, 58);
            this.tableLayoutPanelChartGlobals.TabIndex = 1;
            // 
            // tableLayoutPanelChartSize
            // 
            this.tableLayoutPanelChartSize.ColumnCount = 2;
            this.tableLayoutPanelChartSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.11168F));
            this.tableLayoutPanelChartSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.88833F));
            this.tableLayoutPanelChartSize.Controls.Add(this.tableLayoutPanelChartHeight, 1, 1);
            this.tableLayoutPanelChartSize.Controls.Add(this.labelChartHeight, 0, 1);
            this.tableLayoutPanelChartSize.Controls.Add(this.labelChartWidth, 0, 0);
            this.tableLayoutPanelChartSize.Controls.Add(this.tableLayoutPanelChartWidth, 1, 0);
            this.tableLayoutPanelChartSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelChartSize.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanelChartSize.Name = "tableLayoutPanelChartSize";
            this.tableLayoutPanelChartSize.RowCount = 2;
            this.tableLayoutPanelChartSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartSize.Size = new System.Drawing.Size(486, 52);
            this.tableLayoutPanelChartSize.TabIndex = 1;
            // 
            // tableLayoutPanelChartHeight
            // 
            this.tableLayoutPanelChartHeight.ColumnCount = 1;
            this.tableLayoutPanelChartHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChartHeight.Controls.Add(this.textBoxChartHeight, 0, 1);
            this.tableLayoutPanelChartHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChartHeight.Location = new System.Drawing.Point(120, 29);
            this.tableLayoutPanelChartHeight.Name = "tableLayoutPanelChartHeight";
            this.tableLayoutPanelChartHeight.RowCount = 3;
            this.tableLayoutPanelChartHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelChartHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartHeight.Size = new System.Drawing.Size(363, 20);
            this.tableLayoutPanelChartHeight.TabIndex = 4;
            // 
            // textBoxChartHeight
            // 
            this.textBoxChartHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxChartHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChartHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChartHeight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxChartHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxChartHeight.Location = new System.Drawing.Point(3, 3);
            this.textBoxChartHeight.Name = "textBoxChartHeight";
            this.textBoxChartHeight.Size = new System.Drawing.Size(357, 19);
            this.textBoxChartHeight.TabIndex = 2;
            this.textBoxChartHeight.TextChanged += new System.EventHandler(this.textBoxChartHeight_TextChanged);
            // 
            // labelChartHeight
            // 
            this.labelChartHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChartHeight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelChartHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelChartHeight.Location = new System.Drawing.Point(3, 26);
            this.labelChartHeight.Name = "labelChartHeight";
            this.labelChartHeight.Size = new System.Drawing.Size(111, 26);
            this.labelChartHeight.TabIndex = 2;
            this.labelChartHeight.Text = "Height:";
            this.labelChartHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChartWidth
            // 
            this.labelChartWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChartWidth.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelChartWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelChartWidth.Location = new System.Drawing.Point(3, 0);
            this.labelChartWidth.Name = "labelChartWidth";
            this.labelChartWidth.Size = new System.Drawing.Size(111, 26);
            this.labelChartWidth.TabIndex = 1;
            this.labelChartWidth.Text = "Width:";
            this.labelChartWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelChartWidth
            // 
            this.tableLayoutPanelChartWidth.ColumnCount = 1;
            this.tableLayoutPanelChartWidth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChartWidth.Controls.Add(this.textBoxChartWidth, 0, 1);
            this.tableLayoutPanelChartWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChartWidth.Location = new System.Drawing.Point(120, 3);
            this.tableLayoutPanelChartWidth.Name = "tableLayoutPanelChartWidth";
            this.tableLayoutPanelChartWidth.RowCount = 3;
            this.tableLayoutPanelChartWidth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartWidth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelChartWidth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartWidth.Size = new System.Drawing.Size(363, 20);
            this.tableLayoutPanelChartWidth.TabIndex = 3;
            // 
            // textBoxChartWidth
            // 
            this.textBoxChartWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxChartWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChartWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChartWidth.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxChartWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxChartWidth.Location = new System.Drawing.Point(3, 3);
            this.textBoxChartWidth.Name = "textBoxChartWidth";
            this.textBoxChartWidth.Size = new System.Drawing.Size(357, 19);
            this.textBoxChartWidth.TabIndex = 2;
            this.textBoxChartWidth.TextChanged += new System.EventHandler(this.textBoxChartWidth_TextChanged);
            // 
            // panelTicks
            // 
            this.panelTicks.Controls.Add(this.gridTickSelectorYAxisTicks);
            this.panelTicks.Controls.Add(this.gridTickSelectorXAxisTicks);
            this.panelTicks.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTicks.Location = new System.Drawing.Point(0, 58);
            this.panelTicks.Name = "panelTicks";
            this.panelTicks.Size = new System.Drawing.Size(380, 486);
            this.panelTicks.TabIndex = 2;
            // 
            // gridTickSelectorYAxisTicks
            // 
            this.gridTickSelectorYAxisTicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.gridTickSelectorYAxisTicks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTickSelectorYAxisTicks.Home = null;
            this.gridTickSelectorYAxisTicks.Location = new System.Drawing.Point(190, 0);
            this.gridTickSelectorYAxisTicks.Name = "gridTickSelectorYAxisTicks";
            this.gridTickSelectorYAxisTicks.Size = new System.Drawing.Size(190, 486);
            this.gridTickSelectorYAxisTicks.TabIndex = 1;
            this.gridTickSelectorYAxisTicks.Ticks = null;
            // 
            // gridTickSelectorXAxisTicks
            // 
            this.gridTickSelectorXAxisTicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.gridTickSelectorXAxisTicks.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridTickSelectorXAxisTicks.Home = null;
            this.gridTickSelectorXAxisTicks.Location = new System.Drawing.Point(0, 0);
            this.gridTickSelectorXAxisTicks.Name = "gridTickSelectorXAxisTicks";
            this.gridTickSelectorXAxisTicks.Size = new System.Drawing.Size(190, 486);
            this.gridTickSelectorXAxisTicks.TabIndex = 0;
            this.gridTickSelectorXAxisTicks.Ticks = null;
            // 
            // panelLegend
            // 
            this.panelLegend.Controls.Add(this.legendDisplay);
            this.panelLegend.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLegend.Location = new System.Drawing.Point(380, 58);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelLegend.Size = new System.Drawing.Size(644, 148);
            this.panelLegend.TabIndex = 3;
            // 
            // legendDisplay
            // 
            this.legendDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.legendDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.legendDisplay.Home = null;
            this.legendDisplay.Location = new System.Drawing.Point(20, 0);
            this.legendDisplay.Name = "legendDisplay";
            this.legendDisplay.Size = new System.Drawing.Size(107, 148);
            this.legendDisplay.TabIndex = 1;
            // 
            // panelDependantVariable
            // 
            this.panelDependantVariable.Controls.Add(this.tableLayoutPanel1);
            this.panelDependantVariable.Controls.Add(this.labelDependantVariableName);
            this.panelDependantVariable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDependantVariable.Location = new System.Drawing.Point(380, 206);
            this.panelDependantVariable.Name = "panelDependantVariable";
            this.panelDependantVariable.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelDependantVariable.Size = new System.Drawing.Size(644, 68);
            this.panelDependantVariable.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDependantVariableName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(159, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 68);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxDependantVariableName
            // 
            this.textBoxDependantVariableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxDependantVariableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDependantVariableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDependantVariableName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxDependantVariableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxDependantVariableName.Location = new System.Drawing.Point(3, 24);
            this.textBoxDependantVariableName.Name = "textBoxDependantVariableName";
            this.textBoxDependantVariableName.Size = new System.Drawing.Size(479, 19);
            this.textBoxDependantVariableName.TabIndex = 1;
            this.textBoxDependantVariableName.TextChanged += new System.EventHandler(this.textBoxDependantVariableName_TextChanged);
            // 
            // labelDependantVariableName
            // 
            this.labelDependantVariableName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDependantVariableName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelDependantVariableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelDependantVariableName.Location = new System.Drawing.Point(20, 0);
            this.labelDependantVariableName.Name = "labelDependantVariableName";
            this.labelDependantVariableName.Size = new System.Drawing.Size(139, 68);
            this.labelDependantVariableName.TabIndex = 3;
            this.labelDependantVariableName.Text = "Dependant Variable Name:";
            this.labelDependantVariableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRegression
            // 
            this.panelRegression.Controls.Add(this.checkBoxRegression);
            this.panelRegression.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegression.Location = new System.Drawing.Point(380, 274);
            this.panelRegression.Name = "panelRegression";
            this.panelRegression.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelRegression.Size = new System.Drawing.Size(644, 52);
            this.panelRegression.TabIndex = 5;
            // 
            // checkBoxRegression
            // 
            this.checkBoxRegression.AutoSize = true;
            this.checkBoxRegression.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBoxRegression.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRegression.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxRegression.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.checkBoxRegression.Location = new System.Drawing.Point(20, 0);
            this.checkBoxRegression.Name = "checkBoxRegression";
            this.checkBoxRegression.Size = new System.Drawing.Size(214, 52);
            this.checkBoxRegression.TabIndex = 0;
            this.checkBoxRegression.Text = "Plot regression lines";
            this.checkBoxRegression.UseVisualStyleBackColor = true;
            this.checkBoxRegression.CheckedChanged += new System.EventHandler(this.checkBoxRegression_CheckedChanged);
            // 
            // panelAxisRanges
            // 
            this.panelAxisRanges.Controls.Add(this.axisRangeY);
            this.panelAxisRanges.Controls.Add(this.axisRangeX);
            this.panelAxisRanges.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAxisRanges.Location = new System.Drawing.Point(380, 326);
            this.panelAxisRanges.Name = "panelAxisRanges";
            this.panelAxisRanges.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelAxisRanges.Size = new System.Drawing.Size(644, 151);
            this.panelAxisRanges.TabIndex = 6;
            // 
            // axisRangeY
            // 
            this.axisRangeY.Axis = null;
            this.axisRangeY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.axisRangeY.Dock = System.Windows.Forms.DockStyle.Left;
            this.axisRangeY.Home = null;
            this.axisRangeY.Location = new System.Drawing.Point(270, 0);
            this.axisRangeY.Name = "axisRangeY";
            this.axisRangeY.Size = new System.Drawing.Size(250, 151);
            this.axisRangeY.TabIndex = 1;
            // 
            // axisRangeX
            // 
            this.axisRangeX.Axis = null;
            this.axisRangeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.axisRangeX.Dock = System.Windows.Forms.DockStyle.Left;
            this.axisRangeX.Home = null;
            this.axisRangeX.Location = new System.Drawing.Point(20, 0);
            this.axisRangeX.Name = "axisRangeX";
            this.axisRangeX.Size = new System.Drawing.Size(250, 151);
            this.axisRangeX.TabIndex = 0;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1024, 544);
            this.Controls.Add(this.panelAxisRanges);
            this.Controls.Add(this.panelRegression);
            this.Controls.Add(this.panelDependantVariable);
            this.Controls.Add(this.panelLegend);
            this.Controls.Add(this.panelTicks);
            this.Controls.Add(this.tableLayoutPanelChartGlobals);
            this.Name = "Chart";
            this.Text = "Chart";
            this.panelChartName.ResumeLayout(false);
            this.tableLayoutPanelChartName.ResumeLayout(false);
            this.tableLayoutPanelChartName.PerformLayout();
            this.tableLayoutPanelChartGlobals.ResumeLayout(false);
            this.tableLayoutPanelChartSize.ResumeLayout(false);
            this.tableLayoutPanelChartHeight.ResumeLayout(false);
            this.tableLayoutPanelChartHeight.PerformLayout();
            this.tableLayoutPanelChartWidth.ResumeLayout(false);
            this.tableLayoutPanelChartWidth.PerformLayout();
            this.panelTicks.ResumeLayout(false);
            this.panelLegend.ResumeLayout(false);
            this.panelDependantVariable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelRegression.ResumeLayout(false);
            this.panelRegression.PerformLayout();
            this.panelAxisRanges.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChartName;
        private System.Windows.Forms.Label labelChartName;
        private System.Windows.Forms.TextBox textBoxChartName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartGlobals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartHeight;
        private System.Windows.Forms.TextBox textBoxChartHeight;
        private System.Windows.Forms.Label labelChartHeight;
        private System.Windows.Forms.Label labelChartWidth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartWidth;
        private System.Windows.Forms.TextBox textBoxChartWidth;
        private UserControls.GridTickSelector gridTickSelectorXAxisTicks;
        private UserControls.GridTickSelector gridTickSelectorYAxisTicks;
        private UserControls.LegendDisplay legendDisplay;
        private System.Windows.Forms.Panel panelTicks;
        private System.Windows.Forms.Panel panelLegend;
        private System.Windows.Forms.Panel panelDependantVariable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDependantVariableName;
        private System.Windows.Forms.Label labelDependantVariableName;
        private System.Windows.Forms.Panel panelRegression;
        private System.Windows.Forms.CheckBox checkBoxRegression;
        private System.Windows.Forms.Panel panelAxisRanges;
        private UserControls.AxisRange axisRangeY;
        private UserControls.AxisRange axisRangeX;
    }
}