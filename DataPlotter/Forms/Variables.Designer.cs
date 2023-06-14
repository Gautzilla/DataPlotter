namespace DataPlotter.Forms
{
    partial class Variables
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
            this.variableSelectorYVar = new DataPlotter.UserControls.VariableSelector();
            this.variableSelectorXVar = new DataPlotter.UserControls.VariableSelector();
            this.SuspendLayout();
            // 
            // variableSelectorYVar
            // 
            this.variableSelectorYVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.variableSelectorYVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.variableSelectorYVar.Location = new System.Drawing.Point(20, 220);
            this.variableSelectorYVar.Name = "variableSelectorYVar";
            this.variableSelectorYVar.NextVariableSelector = null;
            this.variableSelectorYVar.Size = new System.Drawing.Size(760, 200);
            this.variableSelectorYVar.TabIndex = 1;
            this.variableSelectorYVar.VariableType = "X-axis variable";
            // 
            // variableSelectorXVar
            // 
            this.variableSelectorXVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.variableSelectorXVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.variableSelectorXVar.Location = new System.Drawing.Point(20, 20);
            this.variableSelectorXVar.Name = "variableSelectorXVar";
            this.variableSelectorXVar.NextVariableSelector = null;
            this.variableSelectorXVar.Size = new System.Drawing.Size(760, 200);
            this.variableSelectorXVar.TabIndex = 0;
            this.variableSelectorXVar.VariableType = "X-axis variable";
            // 
            // Variables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.variableSelectorYVar);
            this.Controls.Add(this.variableSelectorXVar);
            this.Name = "Variables";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Variables";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.VariableSelector variableSelectorXVar;
        private UserControls.VariableSelector variableSelectorYVar;
    }
}