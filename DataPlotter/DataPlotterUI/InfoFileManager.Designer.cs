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
            this.ComboBox_depVarType = new System.Windows.Forms.ComboBox();
            this.TextBox_depVarName = new System.Windows.Forms.TextBox();
            this.Label_depVarName = new System.Windows.Forms.Label();
            this.Label_depVarType = new System.Windows.Forms.Label();
            this.GroupBox_dependentVariable.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_dependentVariable
            // 
            this.GroupBox_dependentVariable.Controls.Add(this.ComboBox_depVarType);
            this.GroupBox_dependentVariable.Controls.Add(this.TextBox_depVarName);
            this.GroupBox_dependentVariable.Controls.Add(this.Label_depVarName);
            this.GroupBox_dependentVariable.Controls.Add(this.Label_depVarType);
            this.GroupBox_dependentVariable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.GroupBox_dependentVariable.Location = new System.Drawing.Point(14, 13);
            this.GroupBox_dependentVariable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox_dependentVariable.Name = "GroupBox_dependentVariable";
            this.GroupBox_dependentVariable.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox_dependentVariable.Size = new System.Drawing.Size(313, 119);
            this.GroupBox_dependentVariable.TabIndex = 9;
            this.GroupBox_dependentVariable.TabStop = false;
            this.GroupBox_dependentVariable.Text = "Dependent Variable";
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
            this.ComboBox_depVarType.Location = new System.Drawing.Point(74, 80);
            this.ComboBox_depVarType.Name = "ComboBox_depVarType";
            this.ComboBox_depVarType.Size = new System.Drawing.Size(232, 27);
            this.ComboBox_depVarType.TabIndex = 11;
            // 
            // TextBox_depVarName
            // 
            this.TextBox_depVarName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.TextBox_depVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.TextBox_depVarName.Location = new System.Drawing.Point(74, 39);
            this.TextBox_depVarName.Name = "TextBox_depVarName";
            this.TextBox_depVarName.Size = new System.Drawing.Size(232, 27);
            this.TextBox_depVarName.TabIndex = 10;
            // 
            // Label_depVarName
            // 
            this.Label_depVarName.AutoSize = true;
            this.Label_depVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Label_depVarName.Location = new System.Drawing.Point(10, 42);
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
            this.Label_depVarType.Location = new System.Drawing.Point(10, 80);
            this.Label_depVarType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_depVarType.Name = "Label_depVarType";
            this.Label_depVarType.Size = new System.Drawing.Size(49, 19);
            this.Label_depVarType.TabIndex = 3;
            this.Label_depVarType.Text = "Type";
            // 
            // InfoFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1333, 658);
            this.Controls.Add(this.GroupBox_dependentVariable);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "InfoFileManager";
            this.Text = "InfoFile Manager";
            this.GroupBox_dependentVariable.ResumeLayout(false);
            this.GroupBox_dependentVariable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_dependentVariable;
        private System.Windows.Forms.Label Label_depVarName;
        private System.Windows.Forms.Label Label_depVarType;
        private System.Windows.Forms.TextBox TextBox_depVarName;
        private System.Windows.Forms.ComboBox ComboBox_depVarType;
    }
}