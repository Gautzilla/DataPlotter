namespace DataPlotter.UserControls
{
    partial class AxisRange
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
            this.labelAxis = new System.Windows.Forms.Label();
            this.panelRange = new System.Windows.Forms.Panel();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.checkBoxLogarithmic = new System.Windows.Forms.CheckBox();
            this.panelRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAxis
            // 
            this.labelAxis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelAxis.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelAxis.Location = new System.Drawing.Point(0, 147);
            this.labelAxis.Name = "labelAxis";
            this.labelAxis.Size = new System.Drawing.Size(235, 33);
            this.labelAxis.TabIndex = 0;
            this.labelAxis.Text = "X-axis";
            this.labelAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRange
            // 
            this.panelRange.Controls.Add(this.textBoxMax);
            this.panelRange.Controls.Add(this.labelMin);
            this.panelRange.Controls.Add(this.textBoxMin);
            this.panelRange.Controls.Add(this.labelMax);
            this.panelRange.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRange.Location = new System.Drawing.Point(0, 0);
            this.panelRange.Name = "panelRange";
            this.panelRange.Size = new System.Drawing.Size(112, 147);
            this.panelRange.TabIndex = 1;
            // 
            // textBoxMax
            // 
            this.textBoxMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMax.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxMax.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxMax.Location = new System.Drawing.Point(0, 95);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(112, 19);
            this.textBoxMax.TabIndex = 2;
            this.textBoxMax.Leave += new System.EventHandler(this.textBoxMax_Leave);
            // 
            // labelMin
            // 
            this.labelMin.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelMin.Location = new System.Drawing.Point(0, 19);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(112, 33);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "Min";
            this.labelMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMin
            // 
            this.textBoxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMin.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxMin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxMin.Location = new System.Drawing.Point(0, 0);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(112, 19);
            this.textBoxMin.TabIndex = 0;
            this.textBoxMin.Leave += new System.EventHandler(this.textBoxMin_Leave);
            // 
            // labelMax
            // 
            this.labelMax.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelMax.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelMax.Location = new System.Drawing.Point(0, 114);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(112, 33);
            this.labelMax.TabIndex = 3;
            this.labelMax.Text = "Max";
            this.labelMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxLogarithmic
            // 
            this.checkBoxLogarithmic.AutoSize = true;
            this.checkBoxLogarithmic.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBoxLogarithmic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLogarithmic.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxLogarithmic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.checkBoxLogarithmic.Location = new System.Drawing.Point(111, 0);
            this.checkBoxLogarithmic.Name = "checkBoxLogarithmic";
            this.checkBoxLogarithmic.Size = new System.Drawing.Size(124, 147);
            this.checkBoxLogarithmic.TabIndex = 2;
            this.checkBoxLogarithmic.Text = "Logarithmic";
            this.checkBoxLogarithmic.UseVisualStyleBackColor = true;
            this.checkBoxLogarithmic.CheckedChanged += new System.EventHandler(this.checkBoxLogarithmic_CheckedChanged);
            // 
            // AxisRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.checkBoxLogarithmic);
            this.Controls.Add(this.panelRange);
            this.Controls.Add(this.labelAxis);
            this.Name = "AxisRange";
            this.Size = new System.Drawing.Size(235, 180);
            this.panelRange.ResumeLayout(false);
            this.panelRange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAxis;
        private System.Windows.Forms.Panel panelRange;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.CheckBox checkBoxLogarithmic;
    }
}
