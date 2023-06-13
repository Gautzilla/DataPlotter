namespace DataPlotter.Forms
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
            this.labelChartName = new System.Windows.Forms.Label();
            this.textBoxChartName = new System.Windows.Forms.TextBox();
            this.panelChartName.SuspendLayout();
            this.tableLayoutPanelChartName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChartName
            // 
            this.panelChartName.Controls.Add(this.tableLayoutPanelChartName);
            this.panelChartName.Controls.Add(this.labelChartName);
            this.panelChartName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChartName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.panelChartName.Location = new System.Drawing.Point(0, 0);
            this.panelChartName.Name = "panelChartName";
            this.panelChartName.Size = new System.Drawing.Size(800, 57);
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
            this.tableLayoutPanelChartName.Size = new System.Drawing.Size(661, 57);
            this.tableLayoutPanelChartName.TabIndex = 1;
            // 
            // labelChartName
            // 
            this.labelChartName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelChartName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelChartName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelChartName.Location = new System.Drawing.Point(0, 0);
            this.labelChartName.Name = "labelChartName";
            this.labelChartName.Size = new System.Drawing.Size(139, 57);
            this.labelChartName.TabIndex = 0;
            this.labelChartName.Text = "Chart Name:";
            this.labelChartName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxChartName
            // 
            this.textBoxChartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxChartName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChartName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChartName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxChartName.Location = new System.Drawing.Point(3, 19);
            this.textBoxChartName.Name = "textBoxChartName";
            this.textBoxChartName.Size = new System.Drawing.Size(655, 19);
            this.textBoxChartName.TabIndex = 1;
            this.textBoxChartName.TextChanged += new System.EventHandler(this.textBoxChartName_TextChanged);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChartName);
            this.Name = "Chart";
            this.Text = "Chart";
            this.panelChartName.ResumeLayout(false);
            this.tableLayoutPanelChartName.ResumeLayout(false);
            this.tableLayoutPanelChartName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChartName;
        private System.Windows.Forms.Label labelChartName;
        private System.Windows.Forms.TextBox textBoxChartName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartName;
    }
}