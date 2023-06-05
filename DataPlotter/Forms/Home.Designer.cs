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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonVariables = new System.Windows.Forms.Button();
            this.buttonChart = new System.Windows.Forms.Button();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(137)))), ((int)(((byte)(132)))));
            this.panelMenu.Controls.Add(this.buttonPlot);
            this.panelMenu.Controls.Add(this.buttonChart);
            this.panelMenu.Controls.Add(this.buttonVariables);
            this.panelMenu.Controls.Add(this.buttonData);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(170, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(119)))));
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonHome.Location = new System.Drawing.Point(0, 80);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(170, 50);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonData
            // 
            this.buttonData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonData.FlatAppearance.BorderSize = 0;
            this.buttonData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonData.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonData.Location = new System.Drawing.Point(0, 130);
            this.buttonData.Name = "buttonData";
            this.buttonData.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonData.Size = new System.Drawing.Size(170, 50);
            this.buttonData.TabIndex = 2;
            this.buttonData.Text = "Data";
            this.buttonData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonData.UseVisualStyleBackColor = true;
            // 
            // buttonVariables
            // 
            this.buttonVariables.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVariables.FlatAppearance.BorderSize = 0;
            this.buttonVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVariables.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVariables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonVariables.Location = new System.Drawing.Point(0, 180);
            this.buttonVariables.Name = "buttonVariables";
            this.buttonVariables.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonVariables.Size = new System.Drawing.Size(170, 50);
            this.buttonVariables.TabIndex = 3;
            this.buttonVariables.Text = "Variables";
            this.buttonVariables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVariables.UseVisualStyleBackColor = true;
            // 
            // buttonChart
            // 
            this.buttonChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChart.FlatAppearance.BorderSize = 0;
            this.buttonChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonChart.Location = new System.Drawing.Point(0, 230);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonChart.Size = new System.Drawing.Size(170, 50);
            this.buttonChart.TabIndex = 4;
            this.buttonChart.Text = "Chart";
            this.buttonChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChart.UseVisualStyleBackColor = true;
            // 
            // buttonPlot
            // 
            this.buttonPlot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPlot.FlatAppearance.BorderSize = 0;
            this.buttonPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlot.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.buttonPlot.Location = new System.Drawing.Point(0, 400);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(170, 50);
            this.buttonPlot.TabIndex = 5;
            this.buttonPlot.Text = "Plot";
            this.buttonPlot.UseVisualStyleBackColor = true;
            // 
            // labelLogo
            // 
            this.labelLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelLogo.Location = new System.Drawing.Point(0, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(170, 80);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "DataPlotter";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(170, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 80);
            this.panel1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Home";
            this.Text = "Home";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.Button buttonVariables;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panel1;
    }
}