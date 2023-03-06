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
            this.Btn_dataFilePath = new System.Windows.Forms.Button();
            this.label_dataPath = new System.Windows.Forms.Label();
            this.Btn_addXMajorTick = new System.Windows.Forms.Button();
            this.label_infoPath = new System.Windows.Forms.Label();
            this.ListBox_xVar = new System.Windows.Forms.ListBox();
            this.label_yVar = new System.Windows.Forms.Label();
            this.ListBox_yVar = new System.Windows.Forms.ListBox();
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
            this.GroupBox_Variables = new System.Windows.Forms.GroupBox();
            this.CheckBox_TripleInteractionSamePlot = new System.Windows.Forms.CheckBox();
            this.Label_yVar2 = new System.Windows.Forms.Label();
            this.GroupBox_filesManager = new System.Windows.Forms.GroupBox();
            this.GroupBox_gridTicks = new System.Windows.Forms.GroupBox();
            this.GroupBox_axesParameters = new System.Windows.Forms.GroupBox();
            this.CheckBox_isDepVarNum = new System.Windows.Forms.CheckBox();
            this.GroupBox_chartParameters = new System.Windows.Forms.GroupBox();
            this.Label_legendAnchor = new System.Windows.Forms.Label();
            this.Table_legendAnchor = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_legendTopLeft = new System.Windows.Forms.Button();
            this.Btn_legendTopRight = new System.Windows.Forms.Button();
            this.Btn_legendBottomLeft = new System.Windows.Forms.Button();
            this.Btn_legendBottomRight = new System.Windows.Forms.Button();
            this.TextBox_chartName = new System.Windows.Forms.TextBox();
            this.Label_chartName = new System.Windows.Forms.Label();
            this.Btn_plot = new System.Windows.Forms.Button();
            this.Btn_loadPreset = new System.Windows.Forms.Button();
            this.Btn_savePreset = new System.Windows.Forms.Button();
            this.GroupBox_plotParameters = new System.Windows.Forms.GroupBox();
            this.CheckBox_regression = new System.Windows.Forms.CheckBox();
            this.GroupBox_Variables.SuspendLayout();
            this.GroupBox_filesManager.SuspendLayout();
            this.GroupBox_gridTicks.SuspendLayout();
            this.GroupBox_axesParameters.SuspendLayout();
            this.GroupBox_chartParameters.SuspendLayout();
            this.Table_legendAnchor.SuspendLayout();
            this.GroupBox_plotParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_xVar
            // 
            this.label_xVar.AutoSize = true;
            this.label_xVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_xVar.Location = new System.Drawing.Point(2, 242);
            this.label_xVar.Name = "label_xVar";
            this.label_xVar.Size = new System.Drawing.Size(131, 19);
            this.label_xVar.TabIndex = 1;
            this.label_xVar.Text = "X-axis variable";
            // 
            // Btn_dataFilePath
            // 
            this.Btn_dataFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_dataFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_dataFilePath.Location = new System.Drawing.Point(6, 26);
            this.Btn_dataFilePath.Name = "Btn_dataFilePath";
            this.Btn_dataFilePath.Size = new System.Drawing.Size(95, 30);
            this.Btn_dataFilePath.TabIndex = 2;
            this.Btn_dataFilePath.Text = "Data File";
            this.Btn_dataFilePath.UseVisualStyleBackColor = false;
            this.Btn_dataFilePath.Click += new System.EventHandler(this.Btn_dataFilePath_Click);
            // 
            // label_dataPath
            // 
            this.label_dataPath.AutoSize = true;
            this.label_dataPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_dataPath.Location = new System.Drawing.Point(107, 32);
            this.label_dataPath.Name = "label_dataPath";
            this.label_dataPath.Size = new System.Drawing.Size(133, 19);
            this.label_dataPath.TabIndex = 3;
            this.label_dataPath.Text = "No loaded data";
            // 
            // Btn_addXMajorTick
            // 
            this.Btn_addXMajorTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_addXMajorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_addXMajorTick.Location = new System.Drawing.Point(40, 59);
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
            this.label_infoPath.Location = new System.Drawing.Point(107, 82);
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
            this.ListBox_xVar.Location = new System.Drawing.Point(6, 26);
            this.ListBox_xVar.Name = "ListBox_xVar";
            this.ListBox_xVar.Size = new System.Drawing.Size(230, 213);
            this.ListBox_xVar.TabIndex = 4;
            this.ListBox_xVar.SelectedIndexChanged += new System.EventHandler(this.ListBox_xVar_SelectedIndexChanged);
            // 
            // label_yVar
            // 
            this.label_yVar.AutoSize = true;
            this.label_yVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_yVar.Location = new System.Drawing.Point(238, 242);
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
            this.ListBox_yVar.Location = new System.Drawing.Point(242, 26);
            this.ListBox_yVar.Name = "ListBox_yVar";
            this.ListBox_yVar.Size = new System.Drawing.Size(230, 213);
            this.ListBox_yVar.TabIndex = 4;
            this.ListBox_yVar.SelectedIndexChanged += new System.EventHandler(this.ListBox_yVar_SelectedIndexChanged);
            // 
            // ListBox_yVar2
            // 
            this.ListBox_yVar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.ListBox_yVar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ListBox_yVar2.FormattingEnabled = true;
            this.ListBox_yVar2.ItemHeight = 19;
            this.ListBox_yVar2.Location = new System.Drawing.Point(478, 26);
            this.ListBox_yVar2.Name = "ListBox_yVar2";
            this.ListBox_yVar2.Size = new System.Drawing.Size(230, 80);
            this.ListBox_yVar2.TabIndex = 4;
            this.ListBox_yVar2.SelectedIndexChanged += new System.EventHandler(this.ListBox_yVar2_SelectedIndexChanged);
            // 
            // Label_yVar2Levels
            // 
            this.Label_yVar2Levels.AutoSize = true;
            this.Label_yVar2Levels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_yVar2Levels.Location = new System.Drawing.Point(474, 242);
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
            this.ListBox_yVar2Levels.Location = new System.Drawing.Point(478, 159);
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
            this.TextBox_chartWidth.Location = new System.Drawing.Point(6, 79);
            this.TextBox_chartWidth.Name = "TextBox_chartWidth";
            this.TextBox_chartWidth.Size = new System.Drawing.Size(111, 27);
            this.TextBox_chartWidth.TabIndex = 5;
            this.TextBox_chartWidth.Leave += new System.EventHandler(this.TextBox_chartSize_Leave);
            // 
            // TextBox_chartHeight
            // 
            this.TextBox_chartHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_chartHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_chartHeight.Location = new System.Drawing.Point(123, 79);
            this.TextBox_chartHeight.Name = "TextBox_chartHeight";
            this.TextBox_chartHeight.Size = new System.Drawing.Size(111, 27);
            this.TextBox_chartHeight.TabIndex = 5;
            this.TextBox_chartHeight.Leave += new System.EventHandler(this.TextBox_chartSize_Leave);
            // 
            // Label_chartWidth
            // 
            this.Label_chartWidth.AutoSize = true;
            this.Label_chartWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_chartWidth.Location = new System.Drawing.Point(6, 109);
            this.Label_chartWidth.Name = "Label_chartWidth";
            this.Label_chartWidth.Size = new System.Drawing.Size(105, 19);
            this.Label_chartWidth.TabIndex = 1;
            this.Label_chartWidth.Text = "Chart width";
            // 
            // Label_chartHeight
            // 
            this.Label_chartHeight.AutoSize = true;
            this.Label_chartHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_chartHeight.Location = new System.Drawing.Point(123, 109);
            this.Label_chartHeight.Name = "Label_chartHeight";
            this.Label_chartHeight.Size = new System.Drawing.Size(111, 19);
            this.Label_chartHeight.TabIndex = 1;
            this.Label_chartHeight.Text = "Chart height";
            // 
            // TextBox_depVarName
            // 
            this.TextBox_depVarName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_depVarName.Enabled = false;
            this.TextBox_depVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_depVarName.Location = new System.Drawing.Point(6, 26);
            this.TextBox_depVarName.Name = "TextBox_depVarName";
            this.TextBox_depVarName.Size = new System.Drawing.Size(228, 27);
            this.TextBox_depVarName.TabIndex = 5;
            this.TextBox_depVarName.Leave += new System.EventHandler(this.TextBox_depVarName_Leave);
            // 
            // Label_depVarName
            // 
            this.Label_depVarName.AutoSize = true;
            this.Label_depVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_depVarName.Location = new System.Drawing.Point(6, 56);
            this.Label_depVarName.Name = "Label_depVarName";
            this.Label_depVarName.Size = new System.Drawing.Size(219, 19);
            this.Label_depVarName.TabIndex = 1;
            this.Label_depVarName.Text = "Dependent variable name";
            // 
            // Label_xMin
            // 
            this.Label_xMin.AutoSize = true;
            this.Label_xMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_xMin.Location = new System.Drawing.Point(6, 232);
            this.Label_xMin.Name = "Label_xMin";
            this.Label_xMin.Size = new System.Drawing.Size(100, 19);
            this.Label_xMin.TabIndex = 1;
            this.Label_xMin.Text = "x minValue";
            // 
            // Label_xMax
            // 
            this.Label_xMax.AutoSize = true;
            this.Label_xMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_xMax.Location = new System.Drawing.Point(123, 232);
            this.Label_xMax.Name = "Label_xMax";
            this.Label_xMax.Size = new System.Drawing.Size(105, 19);
            this.Label_xMax.TabIndex = 1;
            this.Label_xMax.Text = "x maxValue";
            // 
            // TextBox_xMin
            // 
            this.TextBox_xMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_xMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_xMin.Location = new System.Drawing.Point(6, 202);
            this.TextBox_xMin.Name = "TextBox_xMin";
            this.TextBox_xMin.Size = new System.Drawing.Size(111, 27);
            this.TextBox_xMin.TabIndex = 5;
            this.TextBox_xMin.Leave += new System.EventHandler(this.TextBox_axisRange_Leave);
            // 
            // TextBox_xMax
            // 
            this.TextBox_xMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_xMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_xMax.Location = new System.Drawing.Point(123, 202);
            this.TextBox_xMax.Name = "TextBox_xMax";
            this.TextBox_xMax.Size = new System.Drawing.Size(111, 27);
            this.TextBox_xMax.TabIndex = 5;
            this.TextBox_xMax.Leave += new System.EventHandler(this.TextBox_axisRange_Leave);
            // 
            // Label_yMin
            // 
            this.Label_yMin.AutoSize = true;
            this.Label_yMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_yMin.Location = new System.Drawing.Point(6, 294);
            this.Label_yMin.Name = "Label_yMin";
            this.Label_yMin.Size = new System.Drawing.Size(99, 19);
            this.Label_yMin.TabIndex = 1;
            this.Label_yMin.Text = "y minValue";
            // 
            // Label_yMax
            // 
            this.Label_yMax.AutoSize = true;
            this.Label_yMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_yMax.Location = new System.Drawing.Point(123, 294);
            this.Label_yMax.Name = "Label_yMax";
            this.Label_yMax.Size = new System.Drawing.Size(104, 19);
            this.Label_yMax.TabIndex = 1;
            this.Label_yMax.Text = "y maxValue";
            // 
            // TextBox_yMin
            // 
            this.TextBox_yMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_yMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_yMin.Location = new System.Drawing.Point(6, 264);
            this.TextBox_yMin.Name = "TextBox_yMin";
            this.TextBox_yMin.Size = new System.Drawing.Size(111, 27);
            this.TextBox_yMin.TabIndex = 5;
            this.TextBox_yMin.Leave += new System.EventHandler(this.TextBox_axisRange_Leave);
            // 
            // TextBox_yMax
            // 
            this.TextBox_yMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_yMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_yMax.Location = new System.Drawing.Point(123, 264);
            this.TextBox_yMax.Name = "TextBox_yMax";
            this.TextBox_yMax.Size = new System.Drawing.Size(111, 27);
            this.TextBox_yMax.TabIndex = 5;
            this.TextBox_yMax.Leave += new System.EventHandler(this.TextBox_axisRange_Leave);
            // 
            // CheckBox_isXLog
            // 
            this.CheckBox_isXLog.AutoSize = true;
            this.CheckBox_isXLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.CheckBox_isXLog.Location = new System.Drawing.Point(249, 204);
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
            this.CheckBox_isYLog.Enabled = false;
            this.CheckBox_isYLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.CheckBox_isYLog.Location = new System.Drawing.Point(249, 266);
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
            this.ListBox_xMajorTicks.Location = new System.Drawing.Point(76, 26);
            this.ListBox_xMajorTicks.Name = "ListBox_xMajorTicks";
            this.ListBox_xMajorTicks.Size = new System.Drawing.Size(88, 213);
            this.ListBox_xMajorTicks.TabIndex = 4;
            // 
            // Label_xMajorTicks
            // 
            this.Label_xMajorTicks.AutoSize = true;
            this.Label_xMajorTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_xMajorTicks.Location = new System.Drawing.Point(72, 242);
            this.Label_xMajorTicks.Name = "Label_xMajorTicks";
            this.Label_xMajorTicks.Size = new System.Drawing.Size(103, 19);
            this.Label_xMajorTicks.TabIndex = 1;
            this.Label_xMajorTicks.Text = "X-axis ticks";
            // 
            // Label_yMajorTicks
            // 
            this.Label_yMajorTicks.AutoSize = true;
            this.Label_yMajorTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_yMajorTicks.Location = new System.Drawing.Point(273, 242);
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
            this.ListBox_yMajorTicks.Location = new System.Drawing.Point(277, 26);
            this.ListBox_yMajorTicks.Name = "ListBox_yMajorTicks";
            this.ListBox_yMajorTicks.Size = new System.Drawing.Size(88, 213);
            this.ListBox_yMajorTicks.TabIndex = 4;
            // 
            // TextBox_xMajorTick
            // 
            this.TextBox_xMajorTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_xMajorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_xMajorTick.Location = new System.Drawing.Point(6, 26);
            this.TextBox_xMajorTick.Name = "TextBox_xMajorTick";
            this.TextBox_xMajorTick.Size = new System.Drawing.Size(64, 27);
            this.TextBox_xMajorTick.TabIndex = 5;
            this.TextBox_xMajorTick.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_MajorTick_KeyUp);
            // 
            // Btn_addYMajorTick
            // 
            this.Btn_addYMajorTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_addYMajorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_addYMajorTick.Location = new System.Drawing.Point(241, 59);
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
            this.TextBox_yMajorTick.Location = new System.Drawing.Point(207, 26);
            this.TextBox_yMajorTick.Name = "TextBox_yMajorTick";
            this.TextBox_yMajorTick.Size = new System.Drawing.Size(64, 27);
            this.TextBox_yMajorTick.TabIndex = 5;
            this.TextBox_yMajorTick.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_MajorTick_KeyUp);
            // 
            // Btn_removeXMajorTick
            // 
            this.Btn_removeXMajorTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_removeXMajorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_removeXMajorTick.Location = new System.Drawing.Point(40, 95);
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
            this.Btn_removeYMajorTick.Location = new System.Drawing.Point(241, 95);
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
            this.Btn_infoFilePath.Location = new System.Drawing.Point(6, 76);
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
            this.TextBox_xMinorTicksInterval.Location = new System.Drawing.Point(6, 264);
            this.TextBox_xMinorTicksInterval.Name = "TextBox_xMinorTicksInterval";
            this.TextBox_xMinorTicksInterval.Size = new System.Drawing.Size(64, 27);
            this.TextBox_xMinorTicksInterval.TabIndex = 5;
            this.TextBox_xMinorTicksInterval.Leave += new System.EventHandler(this.TextBox_MinorTicksInterval_Leave);
            // 
            // Label_xMinorTicksInterval
            // 
            this.Label_xMinorTicksInterval.AutoSize = true;
            this.Label_xMinorTicksInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_xMinorTicksInterval.Location = new System.Drawing.Point(2, 294);
            this.Label_xMinorTicksInterval.Name = "Label_xMinorTicksInterval";
            this.Label_xMinorTicksInterval.Size = new System.Drawing.Size(167, 38);
            this.Label_xMinorTicksInterval.TabIndex = 1;
            this.Label_xMinorTicksInterval.Text = "X-axis \r\nminor ticks interval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(203, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Y-axis\r\nminor ticks interval";
            // 
            // TextBox_yMinorTicksInterval
            // 
            this.TextBox_yMinorTicksInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_yMinorTicksInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_yMinorTicksInterval.Location = new System.Drawing.Point(207, 264);
            this.TextBox_yMinorTicksInterval.Name = "TextBox_yMinorTicksInterval";
            this.TextBox_yMinorTicksInterval.Size = new System.Drawing.Size(64, 27);
            this.TextBox_yMinorTicksInterval.TabIndex = 5;
            this.TextBox_yMinorTicksInterval.Leave += new System.EventHandler(this.TextBox_MinorTicksInterval_Leave);
            // 
            // GroupBox_Variables
            // 
            this.GroupBox_Variables.Controls.Add(this.CheckBox_TripleInteractionSamePlot);
            this.GroupBox_Variables.Controls.Add(this.ListBox_xVar);
            this.GroupBox_Variables.Controls.Add(this.label_xVar);
            this.GroupBox_Variables.Controls.Add(this.label_yVar);
            this.GroupBox_Variables.Controls.Add(this.Label_yVar2);
            this.GroupBox_Variables.Controls.Add(this.Label_yVar2Levels);
            this.GroupBox_Variables.Controls.Add(this.ListBox_yVar);
            this.GroupBox_Variables.Controls.Add(this.ListBox_yVar2);
            this.GroupBox_Variables.Controls.Add(this.ListBox_yVar2Levels);
            this.GroupBox_Variables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.GroupBox_Variables.Location = new System.Drawing.Point(12, 132);
            this.GroupBox_Variables.Name = "GroupBox_Variables";
            this.GroupBox_Variables.Size = new System.Drawing.Size(718, 290);
            this.GroupBox_Variables.TabIndex = 7;
            this.GroupBox_Variables.TabStop = false;
            this.GroupBox_Variables.Text = "Variables to plot";
            // 
            // CheckBox_TripleInteractionSamePlot
            // 
            this.CheckBox_TripleInteractionSamePlot.AutoSize = true;
            this.CheckBox_TripleInteractionSamePlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.CheckBox_TripleInteractionSamePlot.Location = new System.Drawing.Point(478, 131);
            this.CheckBox_TripleInteractionSamePlot.Name = "CheckBox_TripleInteractionSamePlot";
            this.CheckBox_TripleInteractionSamePlot.Size = new System.Drawing.Size(215, 23);
            this.CheckBox_TripleInteractionSamePlot.TabIndex = 14;
            this.CheckBox_TripleInteractionSamePlot.Text = "Same plot for all levels";
            this.CheckBox_TripleInteractionSamePlot.UseVisualStyleBackColor = true;
            this.CheckBox_TripleInteractionSamePlot.CheckedChanged += new System.EventHandler(this.CheckBox_TripleInteractionSamePlot_CheckedChanged);
            // 
            // Label_yVar2
            // 
            this.Label_yVar2.AutoSize = true;
            this.Label_yVar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_yVar2.Location = new System.Drawing.Point(474, 109);
            this.Label_yVar2.Name = "Label_yVar2";
            this.Label_yVar2.Size = new System.Drawing.Size(164, 19);
            this.Label_yVar2.TabIndex = 1;
            this.Label_yVar2.Text = "2nd y-axis variable";
            // 
            // GroupBox_filesManager
            // 
            this.GroupBox_filesManager.Controls.Add(this.Btn_dataFilePath);
            this.GroupBox_filesManager.Controls.Add(this.Btn_infoFilePath);
            this.GroupBox_filesManager.Controls.Add(this.label_dataPath);
            this.GroupBox_filesManager.Controls.Add(this.label_infoPath);
            this.GroupBox_filesManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.GroupBox_filesManager.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_filesManager.Name = "GroupBox_filesManager";
            this.GroupBox_filesManager.Size = new System.Drawing.Size(243, 114);
            this.GroupBox_filesManager.TabIndex = 8;
            this.GroupBox_filesManager.TabStop = false;
            this.GroupBox_filesManager.Text = "Files manager";
            // 
            // GroupBox_gridTicks
            // 
            this.GroupBox_gridTicks.Controls.Add(this.TextBox_xMajorTick);
            this.GroupBox_gridTicks.Controls.Add(this.Label_xMajorTicks);
            this.GroupBox_gridTicks.Controls.Add(this.Label_xMinorTicksInterval);
            this.GroupBox_gridTicks.Controls.Add(this.label1);
            this.GroupBox_gridTicks.Controls.Add(this.Label_yMajorTicks);
            this.GroupBox_gridTicks.Controls.Add(this.Btn_addXMajorTick);
            this.GroupBox_gridTicks.Controls.Add(this.Btn_removeXMajorTick);
            this.GroupBox_gridTicks.Controls.Add(this.Btn_removeYMajorTick);
            this.GroupBox_gridTicks.Controls.Add(this.Btn_addYMajorTick);
            this.GroupBox_gridTicks.Controls.Add(this.ListBox_xMajorTicks);
            this.GroupBox_gridTicks.Controls.Add(this.ListBox_yMajorTicks);
            this.GroupBox_gridTicks.Controls.Add(this.TextBox_yMajorTick);
            this.GroupBox_gridTicks.Controls.Add(this.TextBox_xMinorTicksInterval);
            this.GroupBox_gridTicks.Controls.Add(this.TextBox_yMinorTicksInterval);
            this.GroupBox_gridTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.GroupBox_gridTicks.Location = new System.Drawing.Point(12, 442);
            this.GroupBox_gridTicks.Name = "GroupBox_gridTicks";
            this.GroupBox_gridTicks.Size = new System.Drawing.Size(380, 337);
            this.GroupBox_gridTicks.TabIndex = 9;
            this.GroupBox_gridTicks.TabStop = false;
            this.GroupBox_gridTicks.Text = "Grid ticks";
            // 
            // GroupBox_axesParameters
            // 
            this.GroupBox_axesParameters.Controls.Add(this.TextBox_depVarName);
            this.GroupBox_axesParameters.Controls.Add(this.Label_depVarName);
            this.GroupBox_axesParameters.Controls.Add(this.Label_xMin);
            this.GroupBox_axesParameters.Controls.Add(this.Label_yMin);
            this.GroupBox_axesParameters.Controls.Add(this.CheckBox_isYLog);
            this.GroupBox_axesParameters.Controls.Add(this.Label_xMax);
            this.GroupBox_axesParameters.Controls.Add(this.CheckBox_isDepVarNum);
            this.GroupBox_axesParameters.Controls.Add(this.CheckBox_isXLog);
            this.GroupBox_axesParameters.Controls.Add(this.Label_yMax);
            this.GroupBox_axesParameters.Controls.Add(this.TextBox_yMax);
            this.GroupBox_axesParameters.Controls.Add(this.TextBox_xMin);
            this.GroupBox_axesParameters.Controls.Add(this.TextBox_xMax);
            this.GroupBox_axesParameters.Controls.Add(this.TextBox_yMin);
            this.GroupBox_axesParameters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.GroupBox_axesParameters.Location = new System.Drawing.Point(398, 442);
            this.GroupBox_axesParameters.Name = "GroupBox_axesParameters";
            this.GroupBox_axesParameters.Size = new System.Drawing.Size(426, 337);
            this.GroupBox_axesParameters.TabIndex = 10;
            this.GroupBox_axesParameters.TabStop = false;
            this.GroupBox_axesParameters.Text = "Axes parameters";
            // 
            // CheckBox_isDepVarNum
            // 
            this.CheckBox_isDepVarNum.AutoSize = true;
            this.CheckBox_isDepVarNum.Enabled = false;
            this.CheckBox_isDepVarNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.CheckBox_isDepVarNum.Location = new System.Drawing.Point(10, 78);
            this.CheckBox_isDepVarNum.Name = "CheckBox_isDepVarNum";
            this.CheckBox_isDepVarNum.Size = new System.Drawing.Size(273, 23);
            this.CheckBox_isDepVarNum.TabIndex = 6;
            this.CheckBox_isDepVarNum.Text = "Numerical dependant variable";
            this.CheckBox_isDepVarNum.UseVisualStyleBackColor = true;
            this.CheckBox_isDepVarNum.CheckedChanged += new System.EventHandler(this.CheckBox_isDepVarNum_CheckedChanged);
            // 
            // GroupBox_chartParameters
            // 
            this.GroupBox_chartParameters.Controls.Add(this.Label_legendAnchor);
            this.GroupBox_chartParameters.Controls.Add(this.Table_legendAnchor);
            this.GroupBox_chartParameters.Controls.Add(this.TextBox_chartName);
            this.GroupBox_chartParameters.Controls.Add(this.Label_chartName);
            this.GroupBox_chartParameters.Controls.Add(this.TextBox_chartWidth);
            this.GroupBox_chartParameters.Controls.Add(this.Label_chartWidth);
            this.GroupBox_chartParameters.Controls.Add(this.Label_chartHeight);
            this.GroupBox_chartParameters.Controls.Add(this.TextBox_chartHeight);
            this.GroupBox_chartParameters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.GroupBox_chartParameters.Location = new System.Drawing.Point(736, 132);
            this.GroupBox_chartParameters.Name = "GroupBox_chartParameters";
            this.GroupBox_chartParameters.Size = new System.Drawing.Size(244, 229);
            this.GroupBox_chartParameters.TabIndex = 11;
            this.GroupBox_chartParameters.TabStop = false;
            this.GroupBox_chartParameters.Text = "Chart parameters";
            // 
            // Label_legendAnchor
            // 
            this.Label_legendAnchor.AutoSize = true;
            this.Label_legendAnchor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_legendAnchor.Location = new System.Drawing.Point(6, 175);
            this.Label_legendAnchor.Name = "Label_legendAnchor";
            this.Label_legendAnchor.Size = new System.Drawing.Size(128, 19);
            this.Label_legendAnchor.TabIndex = 15;
            this.Label_legendAnchor.Text = "Legend anchor";
            this.Label_legendAnchor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Table_legendAnchor
            // 
            this.Table_legendAnchor.ColumnCount = 2;
            this.Table_legendAnchor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table_legendAnchor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table_legendAnchor.Controls.Add(this.Btn_legendTopLeft, 0, 0);
            this.Table_legendAnchor.Controls.Add(this.Btn_legendTopRight, 1, 0);
            this.Table_legendAnchor.Controls.Add(this.Btn_legendBottomLeft, 0, 1);
            this.Table_legendAnchor.Controls.Add(this.Btn_legendBottomRight, 1, 1);
            this.Table_legendAnchor.Location = new System.Drawing.Point(140, 175);
            this.Table_legendAnchor.Name = "Table_legendAnchor";
            this.Table_legendAnchor.RowCount = 2;
            this.Table_legendAnchor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table_legendAnchor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table_legendAnchor.Size = new System.Drawing.Size(56, 48);
            this.Table_legendAnchor.TabIndex = 15;
            // 
            // Btn_legendTopLeft
            // 
            this.Btn_legendTopLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_legendTopLeft.FlatAppearance.BorderSize = 0;
            this.Btn_legendTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_legendTopLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Btn_legendTopLeft.Location = new System.Drawing.Point(3, 3);
            this.Btn_legendTopLeft.Name = "Btn_legendTopLeft";
            this.Btn_legendTopLeft.Size = new System.Drawing.Size(22, 18);
            this.Btn_legendTopLeft.TabIndex = 0;
            this.Btn_legendTopLeft.UseVisualStyleBackColor = false;
            this.Btn_legendTopLeft.Click += new System.EventHandler(this.Btn_legendTopLeft_Click);
            // 
            // Btn_legendTopRight
            // 
            this.Btn_legendTopRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_legendTopRight.FlatAppearance.BorderSize = 0;
            this.Btn_legendTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_legendTopRight.Location = new System.Drawing.Point(31, 3);
            this.Btn_legendTopRight.Name = "Btn_legendTopRight";
            this.Btn_legendTopRight.Size = new System.Drawing.Size(22, 18);
            this.Btn_legendTopRight.TabIndex = 1;
            this.Btn_legendTopRight.UseVisualStyleBackColor = false;
            this.Btn_legendTopRight.Click += new System.EventHandler(this.Btn_legendTopRight_Click);
            // 
            // Btn_legendBottomLeft
            // 
            this.Btn_legendBottomLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_legendBottomLeft.FlatAppearance.BorderSize = 0;
            this.Btn_legendBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_legendBottomLeft.Location = new System.Drawing.Point(3, 27);
            this.Btn_legendBottomLeft.Name = "Btn_legendBottomLeft";
            this.Btn_legendBottomLeft.Size = new System.Drawing.Size(22, 18);
            this.Btn_legendBottomLeft.TabIndex = 2;
            this.Btn_legendBottomLeft.UseVisualStyleBackColor = false;
            this.Btn_legendBottomLeft.Click += new System.EventHandler(this.Btn_legendBottomLeft_Click);
            // 
            // Btn_legendBottomRight
            // 
            this.Btn_legendBottomRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_legendBottomRight.FlatAppearance.BorderSize = 0;
            this.Btn_legendBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_legendBottomRight.Location = new System.Drawing.Point(31, 27);
            this.Btn_legendBottomRight.Name = "Btn_legendBottomRight";
            this.Btn_legendBottomRight.Size = new System.Drawing.Size(22, 18);
            this.Btn_legendBottomRight.TabIndex = 3;
            this.Btn_legendBottomRight.UseVisualStyleBackColor = false;
            this.Btn_legendBottomRight.Click += new System.EventHandler(this.Btn_legendBottomRight_Click);
            // 
            // TextBox_chartName
            // 
            this.TextBox_chartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_chartName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_chartName.Location = new System.Drawing.Point(6, 26);
            this.TextBox_chartName.Name = "TextBox_chartName";
            this.TextBox_chartName.Size = new System.Drawing.Size(228, 27);
            this.TextBox_chartName.TabIndex = 5;
            this.TextBox_chartName.Leave += new System.EventHandler(this.TextBox_chartName_Leave);
            // 
            // Label_chartName
            // 
            this.Label_chartName.AutoSize = true;
            this.Label_chartName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_chartName.Location = new System.Drawing.Point(6, 56);
            this.Label_chartName.Name = "Label_chartName";
            this.Label_chartName.Size = new System.Drawing.Size(104, 19);
            this.Label_chartName.TabIndex = 1;
            this.Label_chartName.Text = "Chart name";
            // 
            // Btn_plot
            // 
            this.Btn_plot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_plot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_plot.Location = new System.Drawing.Point(404, 44);
            this.Btn_plot.Name = "Btn_plot";
            this.Btn_plot.Size = new System.Drawing.Size(160, 62);
            this.Btn_plot.TabIndex = 2;
            this.Btn_plot.Text = "PLOT";
            this.Btn_plot.UseVisualStyleBackColor = false;
            this.Btn_plot.Click += new System.EventHandler(this.Btn_plot_Click);
            // 
            // Btn_loadPreset
            // 
            this.Btn_loadPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_loadPreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_loadPreset.Location = new System.Drawing.Point(583, 79);
            this.Btn_loadPreset.Name = "Btn_loadPreset";
            this.Btn_loadPreset.Size = new System.Drawing.Size(80, 47);
            this.Btn_loadPreset.TabIndex = 2;
            this.Btn_loadPreset.Text = "load";
            this.Btn_loadPreset.UseVisualStyleBackColor = false;
            this.Btn_loadPreset.Click += new System.EventHandler(this.Btn_loadPreset_Click);
            // 
            // Btn_savePreset
            // 
            this.Btn_savePreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_savePreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_savePreset.Location = new System.Drawing.Point(583, 30);
            this.Btn_savePreset.Name = "Btn_savePreset";
            this.Btn_savePreset.Size = new System.Drawing.Size(80, 47);
            this.Btn_savePreset.TabIndex = 2;
            this.Btn_savePreset.Text = "save";
            this.Btn_savePreset.UseVisualStyleBackColor = false;
            this.Btn_savePreset.Click += new System.EventHandler(this.Btn_savePreset_Click);
            // 
            // GroupBox_plotParameters
            // 
            this.GroupBox_plotParameters.Controls.Add(this.CheckBox_regression);
            this.GroupBox_plotParameters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.GroupBox_plotParameters.Location = new System.Drawing.Point(736, 367);
            this.GroupBox_plotParameters.Name = "GroupBox_plotParameters";
            this.GroupBox_plotParameters.Size = new System.Drawing.Size(244, 55);
            this.GroupBox_plotParameters.TabIndex = 12;
            this.GroupBox_plotParameters.TabStop = false;
            this.GroupBox_plotParameters.Text = "Plot Parameters";
            // 
            // CheckBox_regression
            // 
            this.CheckBox_regression.AutoSize = true;
            this.CheckBox_regression.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.CheckBox_regression.Location = new System.Drawing.Point(10, 26);
            this.CheckBox_regression.Name = "CheckBox_regression";
            this.CheckBox_regression.Size = new System.Drawing.Size(186, 23);
            this.CheckBox_regression.TabIndex = 13;
            this.CheckBox_regression.Text = "Plot regression line";
            this.CheckBox_regression.UseVisualStyleBackColor = true;
            this.CheckBox_regression.CheckedChanged += new System.EventHandler(this.CheckBox_regression_CheckedChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.GroupBox_plotParameters);
            this.Controls.Add(this.Btn_savePreset);
            this.Controls.Add(this.Btn_loadPreset);
            this.Controls.Add(this.Btn_plot);
            this.Controls.Add(this.GroupBox_chartParameters);
            this.Controls.Add(this.GroupBox_axesParameters);
            this.Controls.Add(this.GroupBox_gridTicks);
            this.Controls.Add(this.GroupBox_filesManager);
            this.Controls.Add(this.GroupBox_Variables);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Home";
            this.Text = "DataPlotter";
            this.Load += new System.EventHandler(this.Home_Load);
            this.GroupBox_Variables.ResumeLayout(false);
            this.GroupBox_Variables.PerformLayout();
            this.GroupBox_filesManager.ResumeLayout(false);
            this.GroupBox_filesManager.PerformLayout();
            this.GroupBox_gridTicks.ResumeLayout(false);
            this.GroupBox_gridTicks.PerformLayout();
            this.GroupBox_axesParameters.ResumeLayout(false);
            this.GroupBox_axesParameters.PerformLayout();
            this.GroupBox_chartParameters.ResumeLayout(false);
            this.GroupBox_chartParameters.PerformLayout();
            this.Table_legendAnchor.ResumeLayout(false);
            this.GroupBox_plotParameters.ResumeLayout(false);
            this.GroupBox_plotParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_xVar;
        private System.Windows.Forms.Button Btn_dataFilePath;
        private System.Windows.Forms.Label label_dataPath;
        private System.Windows.Forms.Button Btn_addXMajorTick;
        private System.Windows.Forms.Label label_infoPath;
        private System.Windows.Forms.ListBox ListBox_xVar;
        private System.Windows.Forms.Label label_yVar;
        private System.Windows.Forms.ListBox ListBox_yVar;
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
        private System.Windows.Forms.GroupBox GroupBox_Variables;
        private System.Windows.Forms.GroupBox GroupBox_filesManager;
        private System.Windows.Forms.GroupBox GroupBox_gridTicks;
        private System.Windows.Forms.GroupBox GroupBox_axesParameters;
        private System.Windows.Forms.GroupBox GroupBox_chartParameters;
        private System.Windows.Forms.TextBox TextBox_chartName;
        private System.Windows.Forms.Label Label_chartName;
        private System.Windows.Forms.Button Btn_plot;
        private System.Windows.Forms.Button Btn_loadPreset;
        private System.Windows.Forms.CheckBox CheckBox_isDepVarNum;
        private System.Windows.Forms.Button Btn_savePreset;
        private System.Windows.Forms.GroupBox GroupBox_plotParameters;
        private System.Windows.Forms.CheckBox CheckBox_regression;
        private System.Windows.Forms.CheckBox CheckBox_TripleInteractionSamePlot;
        private System.Windows.Forms.Label Label_yVar2;
        private System.Windows.Forms.Label Label_legendAnchor;
        private System.Windows.Forms.TableLayoutPanel Table_legendAnchor;
        private System.Windows.Forms.Button Btn_legendTopLeft;
        private System.Windows.Forms.Button Btn_legendTopRight;
        private System.Windows.Forms.Button Btn_legendBottomLeft;
        private System.Windows.Forms.Button Btn_legendBottomRight;
    }
}

