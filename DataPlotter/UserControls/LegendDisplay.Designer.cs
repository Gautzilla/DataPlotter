namespace DataPlotter.UserControls
{
    partial class LegendDisplay
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLegendTopLeft = new System.Windows.Forms.Button();
            this.buttonLegendTopRight = new System.Windows.Forms.Button();
            this.buttonLegendBottomLeft = new System.Windows.Forms.Button();
            this.buttonLegendBottomRight = new System.Windows.Forms.Button();
            this.labelLegend = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonLegendBottomRight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonLegendBottomLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonLegendTopRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLegendTopLeft, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonLegendTopLeft
            // 
            this.buttonLegendTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLegendTopLeft.Location = new System.Drawing.Point(3, 3);
            this.buttonLegendTopLeft.Name = "buttonLegendTopLeft";
            this.buttonLegendTopLeft.Size = new System.Drawing.Size(44, 44);
            this.buttonLegendTopLeft.TabIndex = 0;
            this.buttonLegendTopLeft.UseVisualStyleBackColor = true;
            this.buttonLegendTopLeft.Click += new System.EventHandler(this.buttonLegendTopLeft_Click);
            // 
            // buttonLegendTopRight
            // 
            this.buttonLegendTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLegendTopRight.Location = new System.Drawing.Point(53, 3);
            this.buttonLegendTopRight.Name = "buttonLegendTopRight";
            this.buttonLegendTopRight.Size = new System.Drawing.Size(44, 44);
            this.buttonLegendTopRight.TabIndex = 1;
            this.buttonLegendTopRight.UseVisualStyleBackColor = true;
            this.buttonLegendTopRight.Click += new System.EventHandler(this.buttonLegendTopRight_Click);
            // 
            // buttonLegendBottomLeft
            // 
            this.buttonLegendBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLegendBottomLeft.Location = new System.Drawing.Point(3, 53);
            this.buttonLegendBottomLeft.Name = "buttonLegendBottomLeft";
            this.buttonLegendBottomLeft.Size = new System.Drawing.Size(44, 44);
            this.buttonLegendBottomLeft.TabIndex = 2;
            this.buttonLegendBottomLeft.UseVisualStyleBackColor = true;
            this.buttonLegendBottomLeft.Click += new System.EventHandler(this.buttonLegendBottomLeft_Click);
            // 
            // buttonLegendBottomRight
            // 
            this.buttonLegendBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLegendBottomRight.Location = new System.Drawing.Point(53, 53);
            this.buttonLegendBottomRight.Name = "buttonLegendBottomRight";
            this.buttonLegendBottomRight.Size = new System.Drawing.Size(44, 44);
            this.buttonLegendBottomRight.TabIndex = 3;
            this.buttonLegendBottomRight.UseVisualStyleBackColor = true;
            this.buttonLegendBottomRight.Click += new System.EventHandler(this.buttonLegendBottomRight_Click);
            // 
            // labelLegend
            // 
            this.labelLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelLegend.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelLegend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelLegend.Location = new System.Drawing.Point(0, 133);
            this.labelLegend.Name = "labelLegend";
            this.labelLegend.Size = new System.Drawing.Size(108, 46);
            this.labelLegend.TabIndex = 1;
            this.labelLegend.Text = "Legend Docking";
            this.labelLegend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LegendDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.labelLegend);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LegendDisplay";
            this.Size = new System.Drawing.Size(108, 179);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonLegendBottomRight;
        private System.Windows.Forms.Button buttonLegendBottomLeft;
        private System.Windows.Forms.Button buttonLegendTopRight;
        private System.Windows.Forms.Button buttonLegendTopLeft;
        private System.Windows.Forms.Label labelLegend;
    }
}
