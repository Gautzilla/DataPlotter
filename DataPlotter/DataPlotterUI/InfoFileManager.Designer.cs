namespace DataPlotter.DataPlotterUI
{
    partial class InfoFileManager
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
            this.GroupBox_dependentVariable = new System.Windows.Forms.GroupBox();
            this.TextBox_depVarUnit = new System.Windows.Forms.TextBox();
            this.Label_depVarUnit = new System.Windows.Forms.Label();
            this.ComboBox_depVarType = new System.Windows.Forms.ComboBox();
            this.TextBox_depVarName = new System.Windows.Forms.TextBox();
            this.Label_depVarName = new System.Windows.Forms.Label();
            this.Label_depVarType = new System.Windows.Forms.Label();
            this.GroupBox_independentVariables = new System.Windows.Forms.GroupBox();
            this.TextBox_newLevelName = new System.Windows.Forms.TextBox();
            this.Label_indepVarLevels = new System.Windows.Forms.Label();
            this.Btn_addIndepVarLevel = new System.Windows.Forms.Button();
            this.Btn_removeIndepVarLevel = new System.Windows.Forms.Button();
            this.ListBox_indepVarLevels = new System.Windows.Forms.ListBox();
            this.TextBox_indepVarUnit = new System.Windows.Forms.TextBox();
            this.Label_indepVarUnit = new System.Windows.Forms.Label();
            this.ComboBox_indepVarType = new System.Windows.Forms.ComboBox();
            this.Label_indepVarType = new System.Windows.Forms.Label();
            this.TextBox_indepVarName = new System.Windows.Forms.TextBox();
            this.Label_indepVarName = new System.Windows.Forms.Label();
            this.Btn_addIndepVar = new System.Windows.Forms.Button();
            this.Btn_removeIndepVar = new System.Windows.Forms.Button();
            this.ListBox_indepVar = new System.Windows.Forms.ListBox();
            this.GroupBox_file = new System.Windows.Forms.GroupBox();
            this.Btn_saveInfoFile = new System.Windows.Forms.Button();
            this.Btn_loadInfoFile = new System.Windows.Forms.Button();
            this.OpenFileDialog_infoFile = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox_dependentVariable.SuspendLayout();
            this.GroupBox_independentVariables.SuspendLayout();
            this.GroupBox_file.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_dependentVariable
            // 
            this.GroupBox_dependentVariable.Controls.Add(this.TextBox_depVarUnit);
            this.GroupBox_dependentVariable.Controls.Add(this.Label_depVarUnit);
            this.GroupBox_dependentVariable.Controls.Add(this.ComboBox_depVarType);
            this.GroupBox_dependentVariable.Controls.Add(this.TextBox_depVarName);
            this.GroupBox_dependentVariable.Controls.Add(this.Label_depVarName);
            this.GroupBox_dependentVariable.Controls.Add(this.Label_depVarType);
            this.GroupBox_dependentVariable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.GroupBox_dependentVariable.Location = new System.Drawing.Point(134, 13);
            this.GroupBox_dependentVariable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox_dependentVariable.Name = "GroupBox_dependentVariable";
            this.GroupBox_dependentVariable.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox_dependentVariable.Size = new System.Drawing.Size(456, 119);
            this.GroupBox_dependentVariable.TabIndex = 9;
            this.GroupBox_dependentVariable.TabStop = false;
            this.GroupBox_dependentVariable.Text = "Dependent Variable";
            // 
            // TextBox_depVarUnit
            // 
            this.TextBox_depVarUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_depVarUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_depVarUnit.Location = new System.Drawing.Point(244, 77);
            this.TextBox_depVarUnit.Name = "TextBox_depVarUnit";
            this.TextBox_depVarUnit.Size = new System.Drawing.Size(204, 27);
            this.TextBox_depVarUnit.TabIndex = 13;
            // 
            // Label_depVarUnit
            // 
            this.Label_depVarUnit.AutoSize = true;
            this.Label_depVarUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_depVarUnit.Location = new System.Drawing.Point(193, 80);
            this.Label_depVarUnit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_depVarUnit.Name = "Label_depVarUnit";
            this.Label_depVarUnit.Size = new System.Drawing.Size(43, 19);
            this.Label_depVarUnit.TabIndex = 12;
            this.Label_depVarUnit.Text = "Unit";
            this.Label_depVarUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox_depVarType
            // 
            this.ComboBox_depVarType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ComboBox_depVarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_depVarType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox_depVarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ComboBox_depVarType.FormattingEnabled = true;
            this.ComboBox_depVarType.Items.AddRange(new object[] {
            "Linear",
            "Logarithmic",
            "Qualitative"});
            this.ComboBox_depVarType.Location = new System.Drawing.Point(74, 74);
            this.ComboBox_depVarType.Name = "ComboBox_depVarType";
            this.ComboBox_depVarType.Size = new System.Drawing.Size(98, 27);
            this.ComboBox_depVarType.TabIndex = 11;
            // 
            // TextBox_depVarName
            // 
            this.TextBox_depVarName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_depVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_depVarName.Location = new System.Drawing.Point(74, 41);
            this.TextBox_depVarName.Name = "TextBox_depVarName";
            this.TextBox_depVarName.Size = new System.Drawing.Size(374, 27);
            this.TextBox_depVarName.TabIndex = 10;
            // 
            // Label_depVarName
            // 
            this.Label_depVarName.AutoSize = true;
            this.Label_depVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_depVarName.Location = new System.Drawing.Point(10, 44);
            this.Label_depVarName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_depVarName.Name = "Label_depVarName";
            this.Label_depVarName.Size = new System.Drawing.Size(56, 19);
            this.Label_depVarName.TabIndex = 3;
            this.Label_depVarName.Text = "Name";
            this.Label_depVarName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_depVarType
            // 
            this.Label_depVarType.AutoSize = true;
            this.Label_depVarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_depVarType.Location = new System.Drawing.Point(10, 77);
            this.Label_depVarType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_depVarType.Name = "Label_depVarType";
            this.Label_depVarType.Size = new System.Drawing.Size(49, 19);
            this.Label_depVarType.TabIndex = 3;
            this.Label_depVarType.Text = "Type";
            // 
            // GroupBox_independentVariables
            // 
            this.GroupBox_independentVariables.Controls.Add(this.TextBox_newLevelName);
            this.GroupBox_independentVariables.Controls.Add(this.Label_indepVarLevels);
            this.GroupBox_independentVariables.Controls.Add(this.Btn_addIndepVarLevel);
            this.GroupBox_independentVariables.Controls.Add(this.Btn_removeIndepVarLevel);
            this.GroupBox_independentVariables.Controls.Add(this.ListBox_indepVarLevels);
            this.GroupBox_independentVariables.Controls.Add(this.TextBox_indepVarUnit);
            this.GroupBox_independentVariables.Controls.Add(this.Label_indepVarUnit);
            this.GroupBox_independentVariables.Controls.Add(this.ComboBox_indepVarType);
            this.GroupBox_independentVariables.Controls.Add(this.Label_indepVarType);
            this.GroupBox_independentVariables.Controls.Add(this.TextBox_indepVarName);
            this.GroupBox_independentVariables.Controls.Add(this.Label_indepVarName);
            this.GroupBox_independentVariables.Controls.Add(this.Btn_addIndepVar);
            this.GroupBox_independentVariables.Controls.Add(this.Btn_removeIndepVar);
            this.GroupBox_independentVariables.Controls.Add(this.ListBox_indepVar);
            this.GroupBox_independentVariables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.GroupBox_independentVariables.Location = new System.Drawing.Point(14, 140);
            this.GroupBox_independentVariables.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox_independentVariables.Name = "GroupBox_independentVariables";
            this.GroupBox_independentVariables.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox_independentVariables.Size = new System.Drawing.Size(576, 296);
            this.GroupBox_independentVariables.TabIndex = 10;
            this.GroupBox_independentVariables.TabStop = false;
            this.GroupBox_independentVariables.Text = "Independent Variables";
            // 
            // TextBox_newLevelName
            // 
            this.TextBox_newLevelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_newLevelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_newLevelName.Location = new System.Drawing.Point(317, 113);
            this.TextBox_newLevelName.Name = "TextBox_newLevelName";
            this.TextBox_newLevelName.Size = new System.Drawing.Size(215, 27);
            this.TextBox_newLevelName.TabIndex = 20;
            // 
            // Label_indepVarLevels
            // 
            this.Label_indepVarLevels.AutoSize = true;
            this.Label_indepVarLevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_indepVarLevels.Location = new System.Drawing.Point(249, 116);
            this.Label_indepVarLevels.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_indepVarLevels.Name = "Label_indepVarLevels";
            this.Label_indepVarLevels.Size = new System.Drawing.Size(60, 19);
            this.Label_indepVarLevels.TabIndex = 19;
            this.Label_indepVarLevels.Text = "Levels";
            // 
            // Btn_addIndepVarLevel
            // 
            this.Btn_addIndepVarLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_addIndepVarLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_addIndepVarLevel.Location = new System.Drawing.Point(538, 110);
            this.Btn_addIndepVarLevel.Name = "Btn_addIndepVarLevel";
            this.Btn_addIndepVarLevel.Size = new System.Drawing.Size(30, 30);
            this.Btn_addIndepVarLevel.TabIndex = 17;
            this.Btn_addIndepVarLevel.Text = "+";
            this.Btn_addIndepVarLevel.UseVisualStyleBackColor = false;
            this.Btn_addIndepVarLevel.Click += new System.EventHandler(this.Btn_addIndepVarLevel_Click);
            // 
            // Btn_removeIndepVarLevel
            // 
            this.Btn_removeIndepVarLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_removeIndepVarLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_removeIndepVarLevel.Location = new System.Drawing.Point(281, 215);
            this.Btn_removeIndepVarLevel.Name = "Btn_removeIndepVarLevel";
            this.Btn_removeIndepVarLevel.Size = new System.Drawing.Size(30, 30);
            this.Btn_removeIndepVarLevel.TabIndex = 18;
            this.Btn_removeIndepVarLevel.Text = "-";
            this.Btn_removeIndepVarLevel.UseVisualStyleBackColor = false;
            this.Btn_removeIndepVarLevel.Click += new System.EventHandler(this.Btn_removeIndepVarLevel_Click);
            // 
            // ListBox_indepVarLevels
            // 
            this.ListBox_indepVarLevels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.ListBox_indepVarLevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ListBox_indepVarLevels.FormattingEnabled = true;
            this.ListBox_indepVarLevels.ItemHeight = 19;
            this.ListBox_indepVarLevels.Location = new System.Drawing.Point(317, 146);
            this.ListBox_indepVarLevels.Name = "ListBox_indepVarLevels";
            this.ListBox_indepVarLevels.Size = new System.Drawing.Size(251, 99);
            this.ListBox_indepVarLevels.TabIndex = 16;
            // 
            // TextBox_indepVarUnit
            // 
            this.TextBox_indepVarUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_indepVarUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_indepVarUnit.Location = new System.Drawing.Point(317, 251);
            this.TextBox_indepVarUnit.Name = "TextBox_indepVarUnit";
            this.TextBox_indepVarUnit.Size = new System.Drawing.Size(251, 27);
            this.TextBox_indepVarUnit.TabIndex = 15;
            // 
            // Label_indepVarUnit
            // 
            this.Label_indepVarUnit.AutoSize = true;
            this.Label_indepVarUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_indepVarUnit.Location = new System.Drawing.Point(249, 254);
            this.Label_indepVarUnit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_indepVarUnit.Name = "Label_indepVarUnit";
            this.Label_indepVarUnit.Size = new System.Drawing.Size(43, 19);
            this.Label_indepVarUnit.TabIndex = 14;
            this.Label_indepVarUnit.Text = "Unit";
            this.Label_indepVarUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox_indepVarType
            // 
            this.ComboBox_indepVarType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ComboBox_indepVarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_indepVarType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox_indepVarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ComboBox_indepVarType.FormattingEnabled = true;
            this.ComboBox_indepVarType.Items.AddRange(new object[] {
            "Linear",
            "Logarithmic",
            "Qualitative"});
            this.ComboBox_indepVarType.Location = new System.Drawing.Point(317, 66);
            this.ComboBox_indepVarType.Name = "ComboBox_indepVarType";
            this.ComboBox_indepVarType.Size = new System.Drawing.Size(251, 27);
            this.ComboBox_indepVarType.TabIndex = 13;
            // 
            // Label_indepVarType
            // 
            this.Label_indepVarType.AutoSize = true;
            this.Label_indepVarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_indepVarType.Location = new System.Drawing.Point(249, 69);
            this.Label_indepVarType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_indepVarType.Name = "Label_indepVarType";
            this.Label_indepVarType.Size = new System.Drawing.Size(49, 19);
            this.Label_indepVarType.TabIndex = 12;
            this.Label_indepVarType.Text = "Type";
            // 
            // TextBox_indepVarName
            // 
            this.TextBox_indepVarName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_indepVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_indepVarName.Location = new System.Drawing.Point(317, 27);
            this.TextBox_indepVarName.Name = "TextBox_indepVarName";
            this.TextBox_indepVarName.Size = new System.Drawing.Size(251, 27);
            this.TextBox_indepVarName.TabIndex = 13;
            this.TextBox_indepVarName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_indepVarName_KeyUp);
            this.TextBox_indepVarName.Leave += new System.EventHandler(this.TextBox_indepVarName_Leave);
            // 
            // Label_indepVarName
            // 
            this.Label_indepVarName.AutoSize = true;
            this.Label_indepVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_indepVarName.Location = new System.Drawing.Point(249, 30);
            this.Label_indepVarName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_indepVarName.Name = "Label_indepVarName";
            this.Label_indepVarName.Size = new System.Drawing.Size(56, 19);
            this.Label_indepVarName.TabIndex = 12;
            this.Label_indepVarName.Text = "Name";
            this.Label_indepVarName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_addIndepVar
            // 
            this.Btn_addIndepVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_addIndepVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_addIndepVar.Location = new System.Drawing.Point(10, 27);
            this.Btn_addIndepVar.Name = "Btn_addIndepVar";
            this.Btn_addIndepVar.Size = new System.Drawing.Size(30, 30);
            this.Btn_addIndepVar.TabIndex = 6;
            this.Btn_addIndepVar.Text = "+";
            this.Btn_addIndepVar.UseVisualStyleBackColor = false;
            this.Btn_addIndepVar.Click += new System.EventHandler(this.Btn_addIndepVar_Click);
            // 
            // Btn_removeIndepVar
            // 
            this.Btn_removeIndepVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_removeIndepVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_removeIndepVar.Location = new System.Drawing.Point(10, 63);
            this.Btn_removeIndepVar.Name = "Btn_removeIndepVar";
            this.Btn_removeIndepVar.Size = new System.Drawing.Size(30, 30);
            this.Btn_removeIndepVar.TabIndex = 7;
            this.Btn_removeIndepVar.Text = "-";
            this.Btn_removeIndepVar.UseVisualStyleBackColor = false;
            this.Btn_removeIndepVar.Click += new System.EventHandler(this.Btn_removeIndepVar_Click);
            // 
            // ListBox_indepVar
            // 
            this.ListBox_indepVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.ListBox_indepVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.ListBox_indepVar.FormattingEnabled = true;
            this.ListBox_indepVar.ItemHeight = 19;
            this.ListBox_indepVar.Location = new System.Drawing.Point(46, 27);
            this.ListBox_indepVar.Name = "ListBox_indepVar";
            this.ListBox_indepVar.Size = new System.Drawing.Size(186, 251);
            this.ListBox_indepVar.TabIndex = 5;
            this.ListBox_indepVar.SelectedIndexChanged += new System.EventHandler(this.ListBox_indepVar_SelectedIndexChanged);
            // 
            // GroupBox_file
            // 
            this.GroupBox_file.Controls.Add(this.Btn_saveInfoFile);
            this.GroupBox_file.Controls.Add(this.Btn_loadInfoFile);
            this.GroupBox_file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.GroupBox_file.Location = new System.Drawing.Point(14, 13);
            this.GroupBox_file.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox_file.Name = "GroupBox_file";
            this.GroupBox_file.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox_file.Size = new System.Drawing.Size(110, 119);
            this.GroupBox_file.TabIndex = 12;
            this.GroupBox_file.TabStop = false;
            this.GroupBox_file.Text = "File";
            // 
            // Btn_saveInfoFile
            // 
            this.Btn_saveInfoFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_saveInfoFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_saveInfoFile.Location = new System.Drawing.Point(8, 44);
            this.Btn_saveInfoFile.Name = "Btn_saveInfoFile";
            this.Btn_saveInfoFile.Size = new System.Drawing.Size(95, 30);
            this.Btn_saveInfoFile.TabIndex = 4;
            this.Btn_saveInfoFile.Text = "Save";
            this.Btn_saveInfoFile.UseVisualStyleBackColor = false;
            // 
            // Btn_loadInfoFile
            // 
            this.Btn_loadInfoFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.Btn_loadInfoFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.Btn_loadInfoFile.Location = new System.Drawing.Point(8, 80);
            this.Btn_loadInfoFile.Name = "Btn_loadInfoFile";
            this.Btn_loadInfoFile.Size = new System.Drawing.Size(95, 30);
            this.Btn_loadInfoFile.TabIndex = 3;
            this.Btn_loadInfoFile.Text = "Load";
            this.Btn_loadInfoFile.UseVisualStyleBackColor = false;
            this.Btn_loadInfoFile.Click += new System.EventHandler(this.Btn_loadInfoFile_Click);
            // 
            // OpenFileDialog_infoFile
            // 
            this.OpenFileDialog_infoFile.FileName = "openFileDialog1";
            // 
            // InfoFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(614, 452);
            this.Controls.Add(this.GroupBox_file);
            this.Controls.Add(this.GroupBox_independentVariables);
            this.Controls.Add(this.GroupBox_dependentVariable);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "InfoFileManager";
            this.Text = "InfoFile Manager";
            this.GroupBox_dependentVariable.ResumeLayout(false);
            this.GroupBox_dependentVariable.PerformLayout();
            this.GroupBox_independentVariables.ResumeLayout(false);
            this.GroupBox_independentVariables.PerformLayout();
            this.GroupBox_file.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_dependentVariable;
        private System.Windows.Forms.Label Label_depVarName;
        private System.Windows.Forms.Label Label_depVarType;
        private System.Windows.Forms.TextBox TextBox_depVarName;
        private System.Windows.Forms.ComboBox ComboBox_depVarType;
        private System.Windows.Forms.GroupBox GroupBox_independentVariables;
        private System.Windows.Forms.ListBox ListBox_indepVar;
        private System.Windows.Forms.TextBox TextBox_indepVarName;
        private System.Windows.Forms.Label Label_indepVarName;
        private System.Windows.Forms.Button Btn_addIndepVar;
        private System.Windows.Forms.Button Btn_removeIndepVar;
        private System.Windows.Forms.ComboBox ComboBox_indepVarType;
        private System.Windows.Forms.Label Label_indepVarType;
        private System.Windows.Forms.Label Label_indepVarLevels;
        private System.Windows.Forms.Button Btn_addIndepVarLevel;
        private System.Windows.Forms.Button Btn_removeIndepVarLevel;
        private System.Windows.Forms.ListBox ListBox_indepVarLevels;
        private System.Windows.Forms.TextBox TextBox_indepVarUnit;
        private System.Windows.Forms.Label Label_indepVarUnit;
        private System.Windows.Forms.GroupBox GroupBox_file;
        private System.Windows.Forms.Button Btn_saveInfoFile;
        private System.Windows.Forms.Button Btn_loadInfoFile;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_infoFile;
        private System.Windows.Forms.TextBox TextBox_depVarUnit;
        private System.Windows.Forms.Label Label_depVarUnit;
        private System.Windows.Forms.TextBox TextBox_newLevelName;
    }
}