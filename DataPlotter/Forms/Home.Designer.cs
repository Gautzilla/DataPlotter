namespace DataPlotter.Forms
{
    partial class Home
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.buttonChart = new System.Windows.Forms.Button();
            this.buttonVariables = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogoData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelActiveForm = new System.Windows.Forms.Label();
            this.panelDockingForm = new System.Windows.Forms.Panel();
            this.labelLogoPlotter = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(137)))), ((int)(((byte)(132)))));
            this.panelMenu.Controls.Add(this.buttonPlot);
            this.panelMenu.Controls.Add(this.buttonChart);
            this.panelMenu.Controls.Add(this.buttonVariables);
            this.panelMenu.Controls.Add(this.buttonData);
            this.panelMenu.Controls.Add(this.buttonSet);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(170, 397);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonPlot
            // 
            this.buttonPlot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPlot.FlatAppearance.BorderSize = 0;
            this.buttonPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlot.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.buttonPlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonPlot.Location = new System.Drawing.Point(0, 347);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(170, 50);
            this.buttonPlot.TabIndex = 5;
            this.buttonPlot.Text = "Plot";
            this.buttonPlot.UseVisualStyleBackColor = true;
            // 
            // buttonChart
            // 
            this.buttonChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChart.FlatAppearance.BorderSize = 0;
            this.buttonChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChart.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.buttonChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonChart.Location = new System.Drawing.Point(0, 230);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonChart.Size = new System.Drawing.Size(170, 50);
            this.buttonChart.TabIndex = 4;
            this.buttonChart.Text = "Chart";
            this.buttonChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // buttonVariables
            // 
            this.buttonVariables.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVariables.FlatAppearance.BorderSize = 0;
            this.buttonVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVariables.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.buttonVariables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonVariables.Location = new System.Drawing.Point(0, 180);
            this.buttonVariables.Name = "buttonVariables";
            this.buttonVariables.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonVariables.Size = new System.Drawing.Size(170, 50);
            this.buttonVariables.TabIndex = 3;
            this.buttonVariables.Text = "Variables";
            this.buttonVariables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVariables.UseVisualStyleBackColor = true;
            this.buttonVariables.Click += new System.EventHandler(this.buttonVariables_Click);
            // 
            // buttonData
            // 
            this.buttonData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonData.FlatAppearance.BorderSize = 0;
            this.buttonData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonData.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.buttonData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonData.Location = new System.Drawing.Point(0, 130);
            this.buttonData.Name = "buttonData";
            this.buttonData.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonData.Size = new System.Drawing.Size(170, 50);
            this.buttonData.TabIndex = 2;
            this.buttonData.Text = "Data";
            this.buttonData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSet.FlatAppearance.BorderSize = 0;
            this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonSet.Location = new System.Drawing.Point(0, 80);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonSet.Size = new System.Drawing.Size(170, 50);
            this.buttonSet.TabIndex = 1;
            this.buttonSet.Text = "Set";
            this.buttonSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(119)))));
            this.panelLogo.Controls.Add(this.labelLogoPlotter);
            this.panelLogo.Controls.Add(this.labelLogoData);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // labelLogoData
            // 
            this.labelLogoData.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLogoData.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelLogoData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(92)))), ((int)(((byte)(71)))));
            this.labelLogoData.Location = new System.Drawing.Point(0, 0);
            this.labelLogoData.Margin = new System.Windows.Forms.Padding(0);
            this.labelLogoData.Name = "labelLogoData";
            this.labelLogoData.Size = new System.Drawing.Size(73, 80);
            this.labelLogoData.TabIndex = 0;
            this.labelLogoData.Text = "Data";
            this.labelLogoData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.labelActiveForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(170, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 80);
            this.panel1.TabIndex = 1;
            // 
            // labelActiveForm
            // 
            this.labelActiveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelActiveForm.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.labelActiveForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelActiveForm.Location = new System.Drawing.Point(0, 0);
            this.labelActiveForm.Name = "labelActiveForm";
            this.labelActiveForm.Size = new System.Drawing.Size(774, 80);
            this.labelActiveForm.TabIndex = 0;
            this.labelActiveForm.Text = "SET";
            this.labelActiveForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDockingForm
            // 
            this.panelDockingForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDockingForm.Location = new System.Drawing.Point(170, 80);
            this.panelDockingForm.Name = "panelDockingForm";
            this.panelDockingForm.Size = new System.Drawing.Size(774, 317);
            this.panelDockingForm.TabIndex = 2;
            // 
            // labelLogoPlotter
            // 
            this.labelLogoPlotter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogoPlotter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelLogoPlotter.Location = new System.Drawing.Point(73, 0);
            this.labelLogoPlotter.Name = "labelLogoPlotter";
            this.labelLogoPlotter.Size = new System.Drawing.Size(97, 80);
            this.labelLogoPlotter.TabIndex = 1;
            this.labelLogoPlotter.Text = "Plotter";
            this.labelLogoPlotter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 397);
            this.Controls.Add(this.panelDockingForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(170, 170);
            this.Name = "Home";
            this.Text = "Home";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.Button buttonVariables;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogoData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelActiveForm;
        private System.Windows.Forms.Panel panelDockingForm;
        private System.Windows.Forms.Label labelLogoPlotter;
    }
}