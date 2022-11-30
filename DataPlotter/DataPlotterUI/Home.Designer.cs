namespace DataPlotter
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_xVar = new System.Windows.Forms.Label();
            this.btn_dataFilePath = new System.Windows.Forms.Button();
            this.label_dataPath = new System.Windows.Forms.Label();
            this.Btn_addXMajorTick = new System.Windows.Forms.Button();
            this.label_infoPath = new System.Windows.Forms.Label();
            this.ListBox_xVar = new System.Windows.Forms.ListBox();
            this.label_yVar = new System.Windows.Forms.Label();
            this.ListBox_yVar = new System.Windows.Forms.ListBox();
            this.Label_yVar2 = new System.Windows.Forms.Label();
            this.ListBox_yVar2 = new System.Windows.Forms.ListBox();
            this.Label_yVar2Levels = new System.Windows.Forms.Label();
            this.ListBox_yVar2Levels = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.TextBox_chartWidth = new System.Windows.Forms.TextBox();
            this.TextBox_chartHeight = new System.Windows.Forms.TextBox();
            this.Label_chartWidth = new System.Windows.Forms.Label();
            this.Label_chartHeight = new System.Windows.Forms.Label();
            this.TextBox_depVarName = new System.Windows.Forms.TextBox();
            this.Label_depVarName = new System.Windows.Forms.Label();
            this.Label_xMin = new System.Windows.Forms.Label();
            this.Label_xMax = new System.Windows.Forms.Label();
            this.TextBox_xMin = new System.Windows.Forms.TextBox();
            this.TextBox_xMax = new System.Windows.Forms.TextBox();
            this.Label_yMin = new System.Windows.Forms.Label();
            this.Label_yMax = new System.Windows.Forms.Label();
            this.TextBox_yMin = new System.Windows.Forms.TextBox();
            this.TextBox_yMax = new System.Windows.Forms.TextBox();
            this.CheckBox_isXLog = new System.Windows.Forms.CheckBox();
            this.CheckBox_isYLog = new System.Windows.Forms.CheckBox();
            this.ListBox_xMajorTicks = new System.Windows.Forms.ListBox();
            this.Label_xMajorTicks = new System.Windows.Forms.Label();
            this.Label_yMajorTicks = new System.Windows.Forms.Label();
            this.ListBox_yMajorTicks = new System.Windows.Forms.ListBox();
            this.TextBox_xMajorTick = new System.Windows.Forms.TextBox();
            this.Btn_addYMajorTick = new System.Windows.Forms.Button();
            this.TextBox_yMajorTick = new System.Windows.Forms.TextBox();
            this.Btn_removeXMajorTick = new System.Windows.Forms.Button();
            this.Btn_removeYMajorTick = new System.Windows.Forms.Button();
            this.Btn_infoFilePath = new System.Windows.Forms.Button();
            this.TextBox_xMinorTicksInterval = new System.Windows.Forms.TextBox();
            this.Label_xMinorTicksInterval = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_yMinorTicksInterval = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_xVar
            // 
            this.label_xVar.AutoSize = true;
            this.label_xVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_xVar.Location = new System.Drawing.Point(8, 339);
            this.label_xVar.Name = "label_xVar";
            this.label_xVar.Size = new System.Drawing.Size(131, 19);
            this.label_xVar.TabIndex = 1;
            this.label_xVar.Text = "X-axis variable";
            // 
            // btn_dataFilePath
            // 
            this.btn_dataFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btn_dataFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.btn_dataFilePath.Location = new System.Drawing.Point(12, 12);
            this.btn_dataFilePath.Name = "btn_dataFilePath";
            this.btn_dataFilePath.Size = new System.Drawing.Size(95, 30);
            this.btn_dataFilePath.TabIndex = 2;
            this.btn_dataFilePath.Text = "Data File";
            this.btn_dataFilePath.UseVisualStyleBackColor = false;
            this.btn_dataFilePath.Click += new System.EventHandler(this.Btn_dataFilePath_Click);
            // 
            // label_dataPath
            // 
            this.label_dataPath.AutoSize = true;
            this.label_dataPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_dataPath.Location = new System.Drawing.Point(113, 18);
            this.label_dataPath.Name = "label_dataPath";
            this.label_dataPath.Size = new System.Drawing.Size(133, 19);
            this.label_dataPath.TabIndex = 3;
            this.label_dataPath.Text = "No loaded data";
            // 
            // Btn_addXMajorTick
            // 
            this.Btn_addXMajorTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_addXMajorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_addXMajorTick.Location = new System.Drawing.Point(81, 514);
            this.Btn_addXMajorTick.Name = "Btn_addXMajorTick";
            this.Btn_addXMajorTick.Size = new System.Drawing.Size(30, 30);
            this.Btn_addXMajorTick.TabIndex = 2;
            this.Btn_addXMajorTick.Text = "+";
            this.Btn_addXMajorTick.UseVisualStyleBackColor = false;
            this.Btn_addXMajorTick.Click += new System.EventHandler(this.Btn_addXMajorTick_Click);
            // 
            // label_infoPath
            // 
            this.label_infoPath.AutoSize = true;
            this.label_infoPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_infoPath.Location = new System.Drawing.Point(113, 68);
            this.label_infoPath.Name = "label_infoPath";
            this.label_infoPath.Size = new System.Drawing.Size(133, 19);
            this.label_infoPath.TabIndex = 3;
            this.label_infoPath.Text = "No loaded data";
            // 
            // ListBox_xVar
            // 
            this.ListBox_xVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.ListBox_xVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ListBox_xVar.FormattingEnabled = true;
            this.ListBox_xVar.ItemHeight = 19;
            this.ListBox_xVar.Location = new System.Drawing.Point(12, 123);
            this.ListBox_xVar.Name = "ListBox_xVar";
            this.ListBox_xVar.Size = new System.Drawing.Size(230, 213);
            this.ListBox_xVar.TabIndex = 4;
            this.ListBox_xVar.SelectedIndexChanged += new System.EventHandler(this.ListBox_xVar_SelectedIndexChanged);
            // 
            // label_yVar
            // 
            this.label_yVar.AutoSize = true;
            this.label_yVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_yVar.Location = new System.Drawing.Point(244, 339);
            this.label_yVar.Name = "label_yVar";
            this.label_yVar.Size = new System.Drawing.Size(140, 38);
            this.label_yVar.TabIndex = 1;
            this.label_yVar.Text = "Y-axis variable\r\n(distinct curves)";
            // 
            // ListBox_yVar
            // 
            this.ListBox_yVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.ListBox_yVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ListBox_yVar.FormattingEnabled = true;
            this.ListBox_yVar.ItemHeight = 19;
            this.ListBox_yVar.Location = new System.Drawing.Point(248, 123);
            this.ListBox_yVar.Name = "ListBox_yVar";
            this.ListBox_yVar.Size = new System.Drawing.Size(230, 213);
            this.ListBox_yVar.TabIndex = 4;
            this.ListBox_yVar.SelectedIndexChanged += new System.EventHandler(this.ListBox_yVar_SelectedIndexChanged);
            // 
            // Label_yVar2
            // 
            this.Label_yVar2.AutoSize = true;
            this.Label_yVar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_yVar2.Location = new System.Drawing.Point(480, 206);
            this.Label_yVar2.Name = "Label_yVar2";
            this.Label_yVar2.Size = new System.Drawing.Size(164, 19);
            this.Label_yVar2.TabIndex = 1;
            this.Label_yVar2.Text = "2nd y-axis variable";
            // 
            // ListBox_yVar2
            // 
            this.ListBox_yVar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.ListBox_yVar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ListBox_yVar2.FormattingEnabled = true;
            this.ListBox_yVar2.ItemHeight = 19;
            this.ListBox_yVar2.Location = new System.Drawing.Point(484, 123);
            this.ListBox_yVar2.Name = "ListBox_yVar2";
            this.ListBox_yVar2.Size = new System.Drawing.Size(230, 80);
            this.ListBox_yVar2.TabIndex = 4;
            this.ListBox_yVar2.SelectedIndexChanged += new System.EventHandler(this.ListBox_yVar2_SelectedIndexChanged);
            // 
            // Label_yVar2Levels
            // 
            this.Label_yVar2Levels.AutoSize = true;
            this.Label_yVar2Levels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_yVar2Levels.Location = new System.Drawing.Point(480, 339);
            this.Label_yVar2Levels.Name = "Label_yVar2Levels";
            this.Label_yVar2Levels.Size = new System.Drawing.Size(208, 19);
            this.Label_yVar2Levels.TabIndex = 1;
            this.Label_yVar2Levels.Text = "2nd y-axis variable level";
            // 
            // ListBox_yVar2Levels
            // 
            this.ListBox_yVar2Levels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.ListBox_yVar2Levels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ListBox_yVar2Levels.FormattingEnabled = true;
            this.ListBox_yVar2Levels.ItemHeight = 19;
            this.ListBox_yVar2Levels.Location = new System.Drawing.Point(484, 256);
            this.ListBox_yVar2Levels.Name = "ListBox_yVar2Levels";
            this.ListBox_yVar2Levels.Size = new System.Drawing.Size(230, 80);
            this.ListBox_yVar2Levels.TabIndex = 4;
            this.ListBox_yVar2Levels.SelectedIndexChanged += new System.EventHandler(this.ListBox_yVar2Levels_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // TextBox_chartWidth
            // 
            this.TextBox_chartWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_chartWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_chartWidth.Location = new System.Drawing.Point(853, 190);
            this.TextBox_chartWidth.Name = "TextBox_chartWidth";
            this.TextBox_chartWidth.Size = new System.Drawing.Size(111, 27);
            this.TextBox_chartWidth.TabIndex = 5;
            this.TextBox_chartWidth.Leave += new System.EventHandler(this.TextBox_chartSize_Leave);
            // 
            // TextBox_chartHeight
            // 
            this.TextBox_chartHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_chartHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_chartHeight.Location = new System.Drawing.Point(970, 190);
            this.TextBox_chartHeight.Name = "TextBox_chartHeight";
            this.TextBox_chartHeight.Size = new System.Drawing.Size(111, 27);
            this.TextBox_chartHeight.TabIndex = 5;
            this.TextBox_chartHeight.Leave += new System.EventHandler(this.TextBox_chartSize_Leave);
            // 
            // Label_chartWidth
            // 
            this.Label_chartWidth.AutoSize = true;
            this.Label_chartWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_chartWidth.Location = new System.Drawing.Point(853, 220);
            this.Label_chartWidth.Name = "Label_chartWidth";
            this.Label_chartWidth.Size = new System.Drawing.Size(105, 19);
            this.Label_chartWidth.TabIndex = 1;
            this.Label_chartWidth.Text = "Chart width";
            // 
            // Label_chartHeight
            // 
            this.Label_chartHeight.AutoSize = true;
            this.Label_chartHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_chartHeight.Location = new System.Drawing.Point(970, 220);
            this.Label_chartHeight.Name = "Label_chartHeight";
            this.Label_chartHeight.Size = new System.Drawing.Size(111, 19);
            this.Label_chartHeight.TabIndex = 1;
            this.Label_chartHeight.Text = "Chart height";
            // 
            // TextBox_depVarName
            // 
            this.TextBox_depVarName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_depVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_depVarName.Location = new System.Drawing.Point(853, 113);
            this.TextBox_depVarName.Name = "TextBox_depVarName";
            this.TextBox_depVarName.Size = new System.Drawing.Size(228, 27);
            this.TextBox_depVarName.TabIndex = 5;
            this.TextBox_depVarName.Leave += new System.EventHandler(this.TextBox_depVarName_Leave);
            // 
            // Label_depVarName
            // 
            this.Label_depVarName.AutoSize = true;
            this.Label_depVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_depVarName.Location = new System.Drawing.Point(853, 143);
            this.Label_depVarName.Name = "Label_depVarName";
            this.Label_depVarName.Size = new System.Drawing.Size(219, 19);
            this.Label_depVarName.TabIndex = 1;
            this.Label_depVarName.Text = "Dependent variable name";
            // 
            // Label_xMin
            // 
            this.Label_xMin.AutoSize = true;
            this.Label_xMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_xMin.Location = new System.Drawing.Point(853, 284);
            this.Label_xMin.Name = "Label_xMin";
            this.Label_xMin.Size = new System.Drawing.Size(100, 19);
            this.Label_xMin.TabIndex = 1;
            this.Label_xMin.Text = "x minValue";
            // 
            // Label_xMax
            // 
            this.Label_xMax.AutoSize = true;
            this.Label_xMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_xMax.Location = new System.Drawing.Point(970, 284);
            this.Label_xMax.Name = "Label_xMax";
            this.Label_xMax.Size = new System.Drawing.Size(105, 19);
            this.Label_xMax.TabIndex = 1;
            this.Label_xMax.Text = "x maxValue";
            // 
            // TextBox_xMin
            // 
            this.TextBox_xMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_xMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_xMin.Location = new System.Drawing.Point(853, 254);
            this.TextBox_xMin.Name = "TextBox_xMin";
            this.TextBox_xMin.Size = new System.Drawing.Size(111, 27);
            this.TextBox_xMin.TabIndex = 5;
            this.TextBox_xMin.Leave += new System.EventHandler(this.TextBox_axisRange_Leave);
            // 
            // TextBox_xMax
            // 
            this.TextBox_xMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_xMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_xMax.Location = new System.Drawing.Point(970, 254);
            this.TextBox_xMax.Name = "TextBox_xMax";
            this.TextBox_xMax.Size = new System.Drawing.Size(111, 27);
            this.TextBox_xMax.TabIndex = 5;
            this.TextBox_xMax.Leave += new System.EventHandler(this.TextBox_axisRange_Leave);
            // 
            // Label_yMin
            // 
            this.Label_yMin.AutoSize = true;
            this.Label_yMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_yMin.Location = new System.Drawing.Point(853, 346);
            this.Label_yMin.Name = "Label_yMin";
            this.Label_yMin.Size = new System.Drawing.Size(99, 19);
            this.Label_yMin.TabIndex = 1;
            this.Label_yMin.Text = "y minValue";
            // 
            // Label_yMax
            // 
            this.Label_yMax.AutoSize = true;
            this.Label_yMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_yMax.Location = new System.Drawing.Point(970, 346);
            this.Label_yMax.Name = "Label_yMax";
            this.Label_yMax.Size = new System.Drawing.Size(104, 19);
            this.Label_yMax.TabIndex = 1;
            this.Label_yMax.Text = "y maxValue";
            // 
            // TextBox_yMin
            // 
            this.TextBox_yMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_yMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_yMin.Location = new System.Drawing.Point(853, 316);
            this.TextBox_yMin.Name = "TextBox_yMin";
            this.TextBox_yMin.Size = new System.Drawing.Size(111, 27);
            this.TextBox_yMin.TabIndex = 5;
            this.TextBox_yMin.Leave += new System.EventHandler(this.TextBox_axisRange_Leave);
            // 
            // TextBox_yMax
            // 
            this.TextBox_yMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_yMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_yMax.Location = new System.Drawing.Point(970, 316);
            this.TextBox_yMax.Name = "TextBox_yMax";
            this.TextBox_yMax.Size = new System.Drawing.Size(111, 27);
            this.TextBox_yMax.TabIndex = 5;
            this.TextBox_yMax.Leave += new System.EventHandler(this.TextBox_axisRange_Leave);
            // 
            // CheckBox_isXLog
            // 
            this.CheckBox_isXLog.AutoSize = true;
            this.CheckBox_isXLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.CheckBox_isXLog.Location = new System.Drawing.Point(1096, 256);
            this.CheckBox_isXLog.Name = "CheckBox_isXLog";
            this.CheckBox_isXLog.Size = new System.Drawing.Size(175, 23);
            this.CheckBox_isXLog.TabIndex = 6;
            this.CheckBox_isXLog.Text = "logarithmic x-axis";
            this.CheckBox_isXLog.UseVisualStyleBackColor = true;
            this.CheckBox_isXLog.CheckedChanged += new System.EventHandler(this.CheckBox_isAxisLog_CheckedChanged);
            // 
            // CheckBox_isYLog
            // 
            this.CheckBox_isYLog.AutoSize = true;
            this.CheckBox_isYLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.CheckBox_isYLog.Location = new System.Drawing.Point(1096, 318);
            this.CheckBox_isYLog.Name = "CheckBox_isYLog";
            this.CheckBox_isYLog.Size = new System.Drawing.Size(174, 23);
            this.CheckBox_isYLog.TabIndex = 6;
            this.CheckBox_isYLog.Text = "logarithmic y-axis";
            this.CheckBox_isYLog.UseVisualStyleBackColor = true;
            this.CheckBox_isYLog.CheckedChanged += new System.EventHandler(this.CheckBox_isAxisLog_CheckedChanged);
            // 
            // ListBox_xMajorTicks
            // 
            this.ListBox_xMajorTicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.ListBox_xMajorTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ListBox_xMajorTicks.FormattingEnabled = true;
            this.ListBox_xMajorTicks.ItemHeight = 19;
            this.ListBox_xMajorTicks.Location = new System.Drawing.Point(117, 481);
            this.ListBox_xMajorTicks.Name = "ListBox_xMajorTicks";
            this.ListBox_xMajorTicks.Size = new System.Drawing.Size(88, 213);
            this.ListBox_xMajorTicks.TabIndex = 4;
            // 
            // Label_xMajorTicks
            // 
            this.Label_xMajorTicks.AutoSize = true;
            this.Label_xMajorTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_xMajorTicks.Location = new System.Drawing.Point(113, 697);
            this.Label_xMajorTicks.Name = "Label_xMajorTicks";
            this.Label_xMajorTicks.Size = new System.Drawing.Size(103, 19);
            this.Label_xMajorTicks.TabIndex = 1;
            this.Label_xMajorTicks.Text = "X-axis ticks";
            // 
            // Label_yMajorTicks
            // 
            this.Label_yMajorTicks.AutoSize = true;
            this.Label_yMajorTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_yMajorTicks.Location = new System.Drawing.Point(314, 697);
            this.Label_yMajorTicks.Name = "Label_yMajorTicks";
            this.Label_yMajorTicks.Size = new System.Drawing.Size(103, 19);
            this.Label_yMajorTicks.TabIndex = 1;
            this.Label_yMajorTicks.Text = "Y-axis ticks";
            // 
            // ListBox_yMajorTicks
            // 
            this.ListBox_yMajorTicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.ListBox_yMajorTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ListBox_yMajorTicks.FormattingEnabled = true;
            this.ListBox_yMajorTicks.ItemHeight = 19;
            this.ListBox_yMajorTicks.Location = new System.Drawing.Point(318, 481);
            this.ListBox_yMajorTicks.Name = "ListBox_yMajorTicks";
            this.ListBox_yMajorTicks.Size = new System.Drawing.Size(88, 213);
            this.ListBox_yMajorTicks.TabIndex = 4;
            // 
            // TextBox_xMajorTick
            // 
            this.TextBox_xMajorTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_xMajorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_xMajorTick.Location = new System.Drawing.Point(47, 481);
            this.TextBox_xMajorTick.Name = "TextBox_xMajorTick";
            this.TextBox_xMajorTick.Size = new System.Drawing.Size(64, 27);
            this.TextBox_xMajorTick.TabIndex = 5;
            this.TextBox_xMajorTick.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_MajorTick_KeyUp);
            // 
            // Btn_addYMajorTick
            // 
            this.Btn_addYMajorTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_addYMajorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_addYMajorTick.Location = new System.Drawing.Point(282, 514);
            this.Btn_addYMajorTick.Name = "Btn_addYMajorTick";
            this.Btn_addYMajorTick.Size = new System.Drawing.Size(30, 30);
            this.Btn_addYMajorTick.TabIndex = 2;
            this.Btn_addYMajorTick.Text = "+";
            this.Btn_addYMajorTick.UseVisualStyleBackColor = false;
            this.Btn_addYMajorTick.Click += new System.EventHandler(this.Btn_addYMajorTick_Click);
            // 
            // TextBox_yMajorTick
            // 
            this.TextBox_yMajorTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_yMajorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_yMajorTick.Location = new System.Drawing.Point(248, 481);
            this.TextBox_yMajorTick.Name = "TextBox_yMajorTick";
            this.TextBox_yMajorTick.Size = new System.Drawing.Size(64, 27);
            this.TextBox_yMajorTick.TabIndex = 5;
            this.TextBox_yMajorTick.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_MajorTick_KeyUp);
            // 
            // Btn_removeXMajorTick
            // 
            this.Btn_removeXMajorTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_removeXMajorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_removeXMajorTick.Location = new System.Drawing.Point(81, 550);
            this.Btn_removeXMajorTick.Name = "Btn_removeXMajorTick";
            this.Btn_removeXMajorTick.Size = new System.Drawing.Size(30, 30);
            this.Btn_removeXMajorTick.TabIndex = 2;
            this.Btn_removeXMajorTick.Text = "-";
            this.Btn_removeXMajorTick.UseVisualStyleBackColor = false;
            this.Btn_removeXMajorTick.Click += new System.EventHandler(this.Btn_removeXMajorTick_Click);
            // 
            // Btn_removeYMajorTick
            // 
            this.Btn_removeYMajorTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_removeYMajorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_removeYMajorTick.Location = new System.Drawing.Point(282, 550);
            this.Btn_removeYMajorTick.Name = "Btn_removeYMajorTick";
            this.Btn_removeYMajorTick.Size = new System.Drawing.Size(30, 30);
            this.Btn_removeYMajorTick.TabIndex = 2;
            this.Btn_removeYMajorTick.Text = "-";
            this.Btn_removeYMajorTick.UseVisualStyleBackColor = false;
            this.Btn_removeYMajorTick.Click += new System.EventHandler(this.Btn_removeYMajorTick_Click);
            // 
            // Btn_infoFilePath
            // 
            this.Btn_infoFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_infoFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_infoFilePath.Location = new System.Drawing.Point(12, 62);
            this.Btn_infoFilePath.Name = "Btn_infoFilePath";
            this.Btn_infoFilePath.Size = new System.Drawing.Size(95, 30);
            this.Btn_infoFilePath.TabIndex = 2;
            this.Btn_infoFilePath.Text = "Info File";
            this.Btn_infoFilePath.UseVisualStyleBackColor = false;
            this.Btn_infoFilePath.Click += new System.EventHandler(this.Btn_infoFilePath_Click);
            // 
            // TextBox_xMinorTicksInterval
            // 
            this.TextBox_xMinorTicksInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_xMinorTicksInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_xMinorTicksInterval.Location = new System.Drawing.Point(47, 719);
            this.TextBox_xMinorTicksInterval.Name = "TextBox_xMinorTicksInterval";
            this.TextBox_xMinorTicksInterval.Size = new System.Drawing.Size(64, 27);
            this.TextBox_xMinorTicksInterval.TabIndex = 5;
            this.TextBox_xMinorTicksInterval.Leave += new System.EventHandler(this.TextBox_MinorTicksInterval_Leave);
            // 
            // Label_xMinorTicksInterval
            // 
            this.Label_xMinorTicksInterval.AutoSize = true;
            this.Label_xMinorTicksInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_xMinorTicksInterval.Location = new System.Drawing.Point(43, 749);
            this.Label_xMinorTicksInterval.Name = "Label_xMinorTicksInterval";
            this.Label_xMinorTicksInterval.Size = new System.Drawing.Size(167, 38);
            this.Label_xMinorTicksInterval.TabIndex = 1;
            this.Label_xMinorTicksInterval.Text = "X-axis \r\nminor ticks interval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(244, 749);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Y-axis\r\nminor ticks interval";
            // 
            // TextBox_yMinorTicksInterval
            // 
            this.TextBox_yMinorTicksInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_yMinorTicksInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_yMinorTicksInterval.Location = new System.Drawing.Point(248, 719);
            this.TextBox_yMinorTicksInterval.Name = "TextBox_yMinorTicksInterval";
            this.TextBox_yMinorTicksInterval.Size = new System.Drawing.Size(64, 27);
            this.TextBox_yMinorTicksInterval.TabIndex = 5;
            this.TextBox_yMinorTicksInterval.Leave += new System.EventHandler(this.TextBox_MinorTicksInterval_Leave);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.CheckBox_isYLog);
            this.Controls.Add(this.CheckBox_isXLog);
            this.Controls.Add(this.TextBox_yMax);
            this.Controls.Add(this.TextBox_xMax);
            this.Controls.Add(this.TextBox_chartHeight);
            this.Controls.Add(this.TextBox_depVarName);
            this.Controls.Add(this.TextBox_yMin);
            this.Controls.Add(this.TextBox_xMin);
            this.Controls.Add(this.TextBox_yMajorTick);
            this.Controls.Add(this.TextBox_yMinorTicksInterval);
            this.Controls.Add(this.TextBox_xMinorTicksInterval);
            this.Controls.Add(this.TextBox_xMajorTick);
            this.Controls.Add(this.TextBox_chartWidth);
            this.Controls.Add(this.ListBox_yVar2Levels);
            this.Controls.Add(this.ListBox_yVar2);
            this.Controls.Add(this.ListBox_yVar);
            this.Controls.Add(this.ListBox_yMajorTicks);
            this.Controls.Add(this.ListBox_xMajorTicks);
            this.Controls.Add(this.ListBox_xVar);
            this.Controls.Add(this.label_infoPath);
            this.Controls.Add(this.Label_yVar2Levels);
            this.Controls.Add(this.label_dataPath);
            this.Controls.Add(this.Btn_addYMajorTick);
            this.Controls.Add(this.Label_yVar2);
            this.Controls.Add(this.Btn_removeYMajorTick);
            this.Controls.Add(this.Btn_removeXMajorTick);
            this.Controls.Add(this.Btn_addXMajorTick);
            this.Controls.Add(this.Label_yMax);
            this.Controls.Add(this.label_yVar);
            this.Controls.Add(this.Label_xMax);
            this.Controls.Add(this.Btn_infoFilePath);
            this.Controls.Add(this.btn_dataFilePath);
            this.Controls.Add(this.Label_yMin);
            this.Controls.Add(this.Label_chartHeight);
            this.Controls.Add(this.Label_xMin);
            this.Controls.Add(this.Label_depVarName);
            this.Controls.Add(this.Label_yMajorTicks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_chartWidth);
            this.Controls.Add(this.Label_xMinorTicksInterval);
            this.Controls.Add(this.Label_xMajorTicks);
            this.Controls.Add(this.label_xVar);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Home";
            this.Text = "DataPlotter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_xVar;
        private System.Windows.Forms.Button btn_dataFilePath;
        private System.Windows.Forms.Label label_dataPath;
        private System.Windows.Forms.Button Btn_addXMajorTick;
        private System.Windows.Forms.Label label_infoPath;
        private System.Windows.Forms.ListBox ListBox_xVar;
        private System.Windows.Forms.Label label_yVar;
        private System.Windows.Forms.ListBox ListBox_yVar;
        private System.Windows.Forms.Label Label_yVar2;
        private System.Windows.Forms.ListBox ListBox_yVar2;
        private System.Windows.Forms.Label Label_yVar2Levels;
        private System.Windows.Forms.ListBox ListBox_yVar2Levels;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox TextBox_chartWidth;
        private System.Windows.Forms.TextBox TextBox_chartHeight;
        private System.Windows.Forms.Label Label_chartWidth;
        private System.Windows.Forms.Label Label_chartHeight;
        private System.Windows.Forms.TextBox TextBox_depVarName;
        private System.Windows.Forms.Label Label_depVarName;
        private System.Windows.Forms.Label Label_xMin;
        private System.Windows.Forms.Label Label_xMax;
        private System.Windows.Forms.TextBox TextBox_xMin;
        private System.Windows.Forms.TextBox TextBox_xMax;
        private System.Windows.Forms.Label Label_yMin;
        private System.Windows.Forms.Label Label_yMax;
        private System.Windows.Forms.TextBox TextBox_yMin;
        private System.Windows.Forms.TextBox TextBox_yMax;
        private System.Windows.Forms.CheckBox CheckBox_isXLog;
        private System.Windows.Forms.CheckBox CheckBox_isYLog;
        private System.Windows.Forms.ListBox ListBox_xMajorTicks;
        private System.Windows.Forms.Label Label_xMajorTicks;
        private System.Windows.Forms.Label Label_yMajorTicks;
        private System.Windows.Forms.ListBox ListBox_yMajorTicks;
        private System.Windows.Forms.TextBox TextBox_xMajorTick;
        private System.Windows.Forms.Button Btn_addYMajorTick;
        private System.Windows.Forms.TextBox TextBox_yMajorTick;
        private System.Windows.Forms.Button Btn_removeXMajorTick;
        private System.Windows.Forms.Button Btn_removeYMajorTick;
        private System.Windows.Forms.Button Btn_infoFilePath;
        private System.Windows.Forms.TextBox TextBox_xMinorTicksInterval;
        private System.Windows.Forms.Label Label_xMinorTicksInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_yMinorTicksInterval;
    }
}

