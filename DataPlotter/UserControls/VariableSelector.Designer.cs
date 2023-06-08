namespace DataPlotter.UserControls
{
    partial class VariableSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVariableType = new System.Windows.Forms.Label();
            this.listBoxVariables = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelVariableType
            // 
            this.labelVariableType.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVariableType.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelVariableType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelVariableType.Location = new System.Drawing.Point(0, 0);
            this.labelVariableType.Name = "labelVariableType";
            this.labelVariableType.Size = new System.Drawing.Size(655, 31);
            this.labelVariableType.TabIndex = 0;
            this.labelVariableType.Text = "X-axis variable";
            this.labelVariableType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxVariables
            // 
            this.listBoxVariables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.listBoxVariables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxVariables.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxVariables.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVariables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.listBoxVariables.FormattingEnabled = true;
            this.listBoxVariables.ItemHeight = 19;
            this.listBoxVariables.Location = new System.Drawing.Point(0, 31);
            this.listBoxVariables.Name = "listBoxVariables";
            this.listBoxVariables.Size = new System.Drawing.Size(331, 86);
            this.listBoxVariables.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(331, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(324, 86);
            this.listBox1.TabIndex = 2;
            // 
            // VariableSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBoxVariables);
            this.Controls.Add(this.labelVariableType);
            this.Name = "VariableSelector";
            this.Size = new System.Drawing.Size(655, 117);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelVariableType;
        private System.Windows.Forms.ListBox listBoxVariables;
        private System.Windows.Forms.ListBox listBox1;
    }
}
