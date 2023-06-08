namespace DataPlotter.Forms
{
    partial class SetLoading
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
            this.buttonLoadPreset = new System.Windows.Forms.Button();
            this.listViewChartInfos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonLoadPreset
            // 
            this.buttonLoadPreset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLoadPreset.FlatAppearance.BorderSize = 0;
            this.buttonLoadPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadPreset.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLoadPreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonLoadPreset.Location = new System.Drawing.Point(0, 393);
            this.buttonLoadPreset.Name = "buttonLoadPreset";
            this.buttonLoadPreset.Size = new System.Drawing.Size(800, 57);
            this.buttonLoadPreset.TabIndex = 3;
            this.buttonLoadPreset.Text = "Load";
            this.buttonLoadPreset.UseVisualStyleBackColor = true;
            this.buttonLoadPreset.Click += new System.EventHandler(this.buttonLoadPreset_Click);
            // 
            // listViewChartInfos
            // 
            this.listViewChartInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.listViewChartInfos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewChartInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewChartInfos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.listViewChartInfos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.listViewChartInfos.FullRowSelect = true;
            this.listViewChartInfos.HideSelection = false;
            this.listViewChartInfos.Location = new System.Drawing.Point(0, 0);
            this.listViewChartInfos.MultiSelect = false;
            this.listViewChartInfos.Name = "listViewChartInfos";
            this.listViewChartInfos.Size = new System.Drawing.Size(800, 393);
            this.listViewChartInfos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewChartInfos.TabIndex = 4;
            this.listViewChartInfos.UseCompatibleStateImageBehavior = false;
            // 
            // SetLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewChartInfos);
            this.Controls.Add(this.buttonLoadPreset);
            this.Name = "SetLoading";
            this.Text = "Set Loading";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLoadPreset;
        private System.Windows.Forms.ListView listViewChartInfos;
    }
}