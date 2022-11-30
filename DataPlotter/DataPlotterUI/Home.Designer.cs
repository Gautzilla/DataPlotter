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
            this.btn_InfoPath = new System.Windows.Forms.Button();
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
            // btn_InfoPath
            // 
            this.btn_InfoPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btn_InfoPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.btn_InfoPath.Location = new System.Drawing.Point(12, 62);
            this.btn_InfoPath.Name = "btn_InfoPath";
            this.btn_InfoPath.Size = new System.Drawing.Size(95, 30);
            this.btn_InfoPath.TabIndex = 2;
            this.btn_InfoPath.Text = "Info File";
            this.btn_InfoPath.UseVisualStyleBackColor = false;
            this.btn_InfoPath.Click += new System.EventHandler(this.Btn_InfoPath_Click);
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
            this.TextBox_chartWidth.Leave += new System.EventHandler(this.TextBox_chartWidth_Leave);
            // 
            // TextBox_chartHeight
            // 
            this.TextBox_chartHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_chartHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_chartHeight.Location = new System.Drawing.Point(970, 190);
            this.TextBox_chartHeight.Name = "TextBox_chartHeight";
            this.TextBox_chartHeight.Size = new System.Drawing.Size(111, 27);
            this.TextBox_chartHeight.TabIndex = 5;
            this.TextBox_chartHeight.Leave += new System.EventHandler(this.TextBox_chartHeight_Leave);
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
            this.TextBox_xMin.Leave += new System.EventHandler(this.TextBox_xMin_Leave);
            // 
            // TextBox_xMax
            // 
            this.TextBox_xMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_xMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_xMax.Location = new System.Drawing.Point(970, 254);
            this.TextBox_xMax.Name = "TextBox_xMax";
            this.TextBox_xMax.Size = new System.Drawing.Size(111, 27);
            this.TextBox_xMax.TabIndex = 5;
            this.TextBox_xMax.Leave += new System.EventHandler(this.TextBox_xMax_Leave);
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
            this.TextBox_yMin.Leave += new System.EventHandler(this.TextBox_yMin_Leave);
            // 
            // TextBox_yMax
            // 
            this.TextBox_yMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_yMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_yMax.Location = new System.Drawing.Point(970, 316);
            this.TextBox_yMax.Name = "TextBox_yMax";
            this.TextBox_yMax.Size = new System.Drawing.Size(111, 27);
            this.TextBox_yMax.TabIndex = 5;
            this.TextBox_yMax.Leave += new System.EventHandler(this.TextBox_yMax_Leave);
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
            this.CheckBox_isXLog.CheckedChanged += new System.EventHandler(this.CheckBox_isXLog_CheckedChanged);
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
            this.CheckBox_isYLog.CheckedChanged += new System.EventHandler(this.CheckBox_isYLog_CheckedChanged);
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
            this.Controls.Add(this.TextBox_chartWidth);
            this.Controls.Add(this.ListBox_yVar2Levels);
            this.Controls.Add(this.ListBox_yVar2);
            this.Controls.Add(this.ListBox_yVar);
            this.Controls.Add(this.ListBox_xVar);
            this.Controls.Add(this.label_infoPath);
            this.Controls.Add(this.Label_yVar2Levels);
            this.Controls.Add(this.label_dataPath);
            this.Controls.Add(this.Label_yVar2);
            this.Controls.Add(this.btn_InfoPath);
            this.Controls.Add(this.Label_yMax);
            this.Controls.Add(this.label_yVar);
            this.Controls.Add(this.Label_xMax);
            this.Controls.Add(this.btn_dataFilePath);
            this.Controls.Add(this.Label_yMin);
            this.Controls.Add(this.Label_chartHeight);
            this.Controls.Add(this.Label_xMin);
            this.Controls.Add(this.Label_depVarName);
            this.Controls.Add(this.Label_chartWidth);
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
        private System.Windows.Forms.Button btn_InfoPath;
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
    }
}

