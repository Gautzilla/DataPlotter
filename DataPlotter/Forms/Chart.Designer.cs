﻿namespace DataPlotter.Forms
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
            this.textBoxChartName = new System.Windows.Forms.TextBox();
            this.labelChartName = new System.Windows.Forms.Label();
            this.tableLayoutPanelChartGlobals = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelChartSize = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelChartHeight = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxChartHeight = new System.Windows.Forms.TextBox();
            this.labelChartHeight = new System.Windows.Forms.Label();
            this.labelChartWidth = new System.Windows.Forms.Label();
            this.tableLayoutPanelChartWidth = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxChartWidth = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAxes = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTicks = new System.Windows.Forms.TableLayoutPanel();
            this.gridTickSelectorXAxisTicks = new DataPlotter.UserControls.GridTickSelector();
            this.gridTickSelectorYAxisTicks = new DataPlotter.UserControls.GridTickSelector();
            this.panelChartName.SuspendLayout();
            this.tableLayoutPanelChartName.SuspendLayout();
            this.tableLayoutPanelChartGlobals.SuspendLayout();
            this.tableLayoutPanelChartSize.SuspendLayout();
            this.tableLayoutPanelChartHeight.SuspendLayout();
            this.tableLayoutPanelChartWidth.SuspendLayout();
            this.tableLayoutPanelAxes.SuspendLayout();
            this.tableLayoutPanelTicks.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChartName
            // 
            this.panelChartName.Controls.Add(this.tableLayoutPanelChartName);
            this.panelChartName.Controls.Add(this.labelChartName);
            this.panelChartName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.panelChartName.Location = new System.Drawing.Point(3, 3);
            this.panelChartName.Name = "panelChartName";
            this.panelChartName.Size = new System.Drawing.Size(394, 52);
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
            this.tableLayoutPanelChartName.Size = new System.Drawing.Size(255, 52);
            this.tableLayoutPanelChartName.TabIndex = 1;
            // 
            // textBoxChartName
            // 
            this.textBoxChartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxChartName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChartName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChartName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxChartName.Location = new System.Drawing.Point(3, 16);
            this.textBoxChartName.Name = "textBoxChartName";
            this.textBoxChartName.Size = new System.Drawing.Size(249, 19);
            this.textBoxChartName.TabIndex = 1;
            this.textBoxChartName.TextChanged += new System.EventHandler(this.textBoxChartName_TextChanged);
            // 
            // labelChartName
            // 
            this.labelChartName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelChartName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelChartName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelChartName.Location = new System.Drawing.Point(0, 0);
            this.labelChartName.Name = "labelChartName";
            this.labelChartName.Size = new System.Drawing.Size(139, 52);
            this.labelChartName.TabIndex = 0;
            this.labelChartName.Text = "Chart Name:";
            this.labelChartName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelChartGlobals
            // 
            this.tableLayoutPanelChartGlobals.ColumnCount = 2;
            this.tableLayoutPanelChartGlobals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelChartGlobals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChartGlobals.Controls.Add(this.panelChartName, 0, 0);
            this.tableLayoutPanelChartGlobals.Controls.Add(this.tableLayoutPanelChartSize, 1, 0);
            this.tableLayoutPanelChartGlobals.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelChartGlobals.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelChartGlobals.Name = "tableLayoutPanelChartGlobals";
            this.tableLayoutPanelChartGlobals.RowCount = 1;
            this.tableLayoutPanelChartGlobals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChartGlobals.Size = new System.Drawing.Size(800, 58);
            this.tableLayoutPanelChartGlobals.TabIndex = 1;
            // 
            // tableLayoutPanelChartSize
            // 
            this.tableLayoutPanelChartSize.ColumnCount = 2;
            this.tableLayoutPanelChartSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.11168F));
            this.tableLayoutPanelChartSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.88833F));
            this.tableLayoutPanelChartSize.Controls.Add(this.tableLayoutPanelChartHeight, 1, 1);
            this.tableLayoutPanelChartSize.Controls.Add(this.labelChartHeight, 0, 1);
            this.tableLayoutPanelChartSize.Controls.Add(this.labelChartWidth, 0, 0);
            this.tableLayoutPanelChartSize.Controls.Add(this.tableLayoutPanelChartWidth, 1, 0);
            this.tableLayoutPanelChartSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChartSize.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanelChartSize.Name = "tableLayoutPanelChartSize";
            this.tableLayoutPanelChartSize.RowCount = 2;
            this.tableLayoutPanelChartSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartSize.Size = new System.Drawing.Size(394, 52);
            this.tableLayoutPanelChartSize.TabIndex = 1;
            // 
            // tableLayoutPanelChartHeight
            // 
            this.tableLayoutPanelChartHeight.ColumnCount = 1;
            this.tableLayoutPanelChartHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChartHeight.Controls.Add(this.textBoxChartHeight, 0, 1);
            this.tableLayoutPanelChartHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChartHeight.Location = new System.Drawing.Point(98, 29);
            this.tableLayoutPanelChartHeight.Name = "tableLayoutPanelChartHeight";
            this.tableLayoutPanelChartHeight.RowCount = 3;
            this.tableLayoutPanelChartHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelChartHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartHeight.Size = new System.Drawing.Size(293, 20);
            this.tableLayoutPanelChartHeight.TabIndex = 4;
            // 
            // textBoxChartHeight
            // 
            this.textBoxChartHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxChartHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChartHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChartHeight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxChartHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxChartHeight.Location = new System.Drawing.Point(3, 3);
            this.textBoxChartHeight.Name = "textBoxChartHeight";
            this.textBoxChartHeight.Size = new System.Drawing.Size(287, 19);
            this.textBoxChartHeight.TabIndex = 2;
            this.textBoxChartHeight.TextChanged += new System.EventHandler(this.textBoxChartHeight_TextChanged);
            // 
            // labelChartHeight
            // 
            this.labelChartHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChartHeight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelChartHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelChartHeight.Location = new System.Drawing.Point(3, 26);
            this.labelChartHeight.Name = "labelChartHeight";
            this.labelChartHeight.Size = new System.Drawing.Size(89, 26);
            this.labelChartHeight.TabIndex = 2;
            this.labelChartHeight.Text = "Height:";
            this.labelChartHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChartWidth
            // 
            this.labelChartWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChartWidth.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelChartWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelChartWidth.Location = new System.Drawing.Point(3, 0);
            this.labelChartWidth.Name = "labelChartWidth";
            this.labelChartWidth.Size = new System.Drawing.Size(89, 26);
            this.labelChartWidth.TabIndex = 1;
            this.labelChartWidth.Text = "Width:";
            this.labelChartWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelChartWidth
            // 
            this.tableLayoutPanelChartWidth.ColumnCount = 1;
            this.tableLayoutPanelChartWidth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChartWidth.Controls.Add(this.textBoxChartWidth, 0, 1);
            this.tableLayoutPanelChartWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChartWidth.Location = new System.Drawing.Point(98, 3);
            this.tableLayoutPanelChartWidth.Name = "tableLayoutPanelChartWidth";
            this.tableLayoutPanelChartWidth.RowCount = 3;
            this.tableLayoutPanelChartWidth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartWidth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelChartWidth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChartWidth.Size = new System.Drawing.Size(293, 20);
            this.tableLayoutPanelChartWidth.TabIndex = 3;
            // 
            // textBoxChartWidth
            // 
            this.textBoxChartWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxChartWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChartWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChartWidth.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxChartWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxChartWidth.Location = new System.Drawing.Point(3, 3);
            this.textBoxChartWidth.Name = "textBoxChartWidth";
            this.textBoxChartWidth.Size = new System.Drawing.Size(287, 19);
            this.textBoxChartWidth.TabIndex = 2;
            this.textBoxChartWidth.TextChanged += new System.EventHandler(this.textBoxChartWidth_TextChanged);
            // 
            // tableLayoutPanelAxes
            // 
            this.tableLayoutPanelAxes.ColumnCount = 2;
            this.tableLayoutPanelAxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAxes.Controls.Add(this.tableLayoutPanelTicks, 0, 0);
            this.tableLayoutPanelAxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelAxes.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanelAxes.Name = "tableLayoutPanelAxes";
            this.tableLayoutPanelAxes.RowCount = 1;
            this.tableLayoutPanelAxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAxes.Size = new System.Drawing.Size(800, 308);
            this.tableLayoutPanelAxes.TabIndex = 2;
            // 
            // tableLayoutPanelTicks
            // 
            this.tableLayoutPanelTicks.ColumnCount = 2;
            this.tableLayoutPanelTicks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTicks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTicks.Controls.Add(this.gridTickSelectorXAxisTicks, 0, 0);
            this.tableLayoutPanelTicks.Controls.Add(this.gridTickSelectorYAxisTicks, 1, 0);
            this.tableLayoutPanelTicks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTicks.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTicks.Name = "tableLayoutPanelTicks";
            this.tableLayoutPanelTicks.RowCount = 1;
            this.tableLayoutPanelTicks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTicks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTicks.Size = new System.Drawing.Size(394, 302);
            this.tableLayoutPanelTicks.TabIndex = 0;
            // 
            // gridTickSelectorXAxisTicks
            // 
            this.gridTickSelectorXAxisTicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.gridTickSelectorXAxisTicks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTickSelectorXAxisTicks.Home = null;
            this.gridTickSelectorXAxisTicks.Location = new System.Drawing.Point(3, 3);
            this.gridTickSelectorXAxisTicks.Name = "gridTickSelectorXAxisTicks";
            this.gridTickSelectorXAxisTicks.Size = new System.Drawing.Size(191, 296);
            this.gridTickSelectorXAxisTicks.TabIndex = 0;
            this.gridTickSelectorXAxisTicks.Ticks = null;
            // 
            // gridTickSelectorYAxisTicks
            // 
            this.gridTickSelectorYAxisTicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.gridTickSelectorYAxisTicks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTickSelectorYAxisTicks.Home = null;
            this.gridTickSelectorYAxisTicks.Location = new System.Drawing.Point(200, 3);
            this.gridTickSelectorYAxisTicks.Name = "gridTickSelectorYAxisTicks";
            this.gridTickSelectorYAxisTicks.Size = new System.Drawing.Size(191, 296);
            this.gridTickSelectorYAxisTicks.TabIndex = 1;
            this.gridTickSelectorYAxisTicks.Ticks = null;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.tableLayoutPanelAxes);
            this.Controls.Add(this.tableLayoutPanelChartGlobals);
            this.Name = "Chart";
            this.Text = "Chart";
            this.panelChartName.ResumeLayout(false);
            this.tableLayoutPanelChartName.ResumeLayout(false);
            this.tableLayoutPanelChartName.PerformLayout();
            this.tableLayoutPanelChartGlobals.ResumeLayout(false);
            this.tableLayoutPanelChartSize.ResumeLayout(false);
            this.tableLayoutPanelChartHeight.ResumeLayout(false);
            this.tableLayoutPanelChartHeight.PerformLayout();
            this.tableLayoutPanelChartWidth.ResumeLayout(false);
            this.tableLayoutPanelChartWidth.PerformLayout();
            this.tableLayoutPanelAxes.ResumeLayout(false);
            this.tableLayoutPanelTicks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChartName;
        private System.Windows.Forms.Label labelChartName;
        private System.Windows.Forms.TextBox textBoxChartName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartGlobals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartHeight;
        private System.Windows.Forms.TextBox textBoxChartHeight;
        private System.Windows.Forms.Label labelChartHeight;
        private System.Windows.Forms.Label labelChartWidth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChartWidth;
        private System.Windows.Forms.TextBox textBoxChartWidth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAxes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTicks;
        private UserControls.GridTickSelector gridTickSelectorXAxisTicks;
        private UserControls.GridTickSelector gridTickSelectorYAxisTicks;
    }
}