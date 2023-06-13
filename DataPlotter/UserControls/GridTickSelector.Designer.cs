namespace DataPlotter.UserControls
{
    partial class GridTickSelector
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
            this.listBoxTicks = new System.Windows.Forms.ListBox();
            this.labelTicks = new System.Windows.Forms.Label();
            this.textBoxTick = new System.Windows.Forms.TextBox();
            this.buttonAddTick = new System.Windows.Forms.Button();
            this.tableLayoutPanelAddRemoveTick = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemoveTick = new System.Windows.Forms.Button();
            this.tableLayoutPanelMinorTicks = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMinorTicks = new System.Windows.Forms.TextBox();
            this.labelMinorTick = new System.Windows.Forms.Label();
            this.tableLayoutPanelAddRemoveTick.SuspendLayout();
            this.tableLayoutPanelMinorTicks.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTicks
            // 
            this.listBoxTicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.listBoxTicks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTicks.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxTicks.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.listBoxTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.listBoxTicks.FormattingEnabled = true;
            this.listBoxTicks.ItemHeight = 19;
            this.listBoxTicks.Location = new System.Drawing.Point(73, 0);
            this.listBoxTicks.Name = "listBoxTicks";
            this.listBoxTicks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTicks.Size = new System.Drawing.Size(110, 378);
            this.listBoxTicks.TabIndex = 0;
            this.listBoxTicks.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxTicks_KeyUp);
            // 
            // labelTicks
            // 
            this.labelTicks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTicks.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelTicks.Location = new System.Drawing.Point(0, 378);
            this.labelTicks.Name = "labelTicks";
            this.labelTicks.Size = new System.Drawing.Size(183, 37);
            this.labelTicks.TabIndex = 1;
            this.labelTicks.Text = "X-axis ticks";
            this.labelTicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTick
            // 
            this.textBoxTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxTick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTick.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTick.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxTick.Location = new System.Drawing.Point(0, 0);
            this.textBoxTick.Name = "textBoxTick";
            this.textBoxTick.Size = new System.Drawing.Size(73, 19);
            this.textBoxTick.TabIndex = 3;
            this.textBoxTick.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxTick_KeyUp);
            // 
            // buttonAddTick
            // 
            this.buttonAddTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddTick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTick.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonAddTick.Location = new System.Drawing.Point(3, 3);
            this.buttonAddTick.Name = "buttonAddTick";
            this.buttonAddTick.Size = new System.Drawing.Size(25, 32);
            this.buttonAddTick.TabIndex = 0;
            this.buttonAddTick.Text = "+";
            this.buttonAddTick.UseVisualStyleBackColor = true;
            this.buttonAddTick.Click += new System.EventHandler(this.buttonAddTick_Click);
            // 
            // tableLayoutPanelAddRemoveTick
            // 
            this.tableLayoutPanelAddRemoveTick.ColumnCount = 2;
            this.tableLayoutPanelAddRemoveTick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddRemoveTick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddRemoveTick.Controls.Add(this.buttonRemoveTick, 1, 0);
            this.tableLayoutPanelAddRemoveTick.Controls.Add(this.buttonAddTick, 0, 0);
            this.tableLayoutPanelAddRemoveTick.Location = new System.Drawing.Point(4, 25);
            this.tableLayoutPanelAddRemoveTick.Name = "tableLayoutPanelAddRemoveTick";
            this.tableLayoutPanelAddRemoveTick.RowCount = 1;
            this.tableLayoutPanelAddRemoveTick.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAddRemoveTick.Size = new System.Drawing.Size(63, 38);
            this.tableLayoutPanelAddRemoveTick.TabIndex = 4;
            // 
            // buttonRemoveTick
            // 
            this.buttonRemoveTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveTick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveTick.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonRemoveTick.Location = new System.Drawing.Point(34, 3);
            this.buttonRemoveTick.Name = "buttonRemoveTick";
            this.buttonRemoveTick.Size = new System.Drawing.Size(26, 32);
            this.buttonRemoveTick.TabIndex = 1;
            this.buttonRemoveTick.Text = "-";
            this.buttonRemoveTick.UseVisualStyleBackColor = true;
            this.buttonRemoveTick.Click += new System.EventHandler(this.buttonRemoveTick_Click);
            // 
            // tableLayoutPanelMinorTicks
            // 
            this.tableLayoutPanelMinorTicks.ColumnCount = 1;
            this.tableLayoutPanelMinorTicks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMinorTicks.Controls.Add(this.labelMinorTick, 0, 1);
            this.tableLayoutPanelMinorTicks.Controls.Add(this.textBoxMinorTicks, 0, 0);
            this.tableLayoutPanelMinorTicks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelMinorTicks.Location = new System.Drawing.Point(0, 312);
            this.tableLayoutPanelMinorTicks.Name = "tableLayoutPanelMinorTicks";
            this.tableLayoutPanelMinorTicks.RowCount = 2;
            this.tableLayoutPanelMinorTicks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMinorTicks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelMinorTicks.Size = new System.Drawing.Size(73, 66);
            this.tableLayoutPanelMinorTicks.TabIndex = 5;
            // 
            // textBoxMinorTicks
            // 
            this.textBoxMinorTicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.textBoxMinorTicks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinorTicks.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxMinorTicks.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMinorTicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.textBoxMinorTicks.Location = new System.Drawing.Point(3, 3);
            this.textBoxMinorTicks.Name = "textBoxMinorTicks";
            this.textBoxMinorTicks.Size = new System.Drawing.Size(67, 19);
            this.textBoxMinorTicks.TabIndex = 4;
            this.textBoxMinorTicks.TextChanged += new System.EventHandler(this.textBoxMinorTicks_TextChanged);
            // 
            // labelMinorTick
            // 
            this.labelMinorTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinorTick.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.labelMinorTick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.labelMinorTick.Location = new System.Drawing.Point(3, 23);
            this.labelMinorTick.Name = "labelMinorTick";
            this.labelMinorTick.Size = new System.Drawing.Size(67, 43);
            this.labelMinorTick.TabIndex = 5;
            this.labelMinorTick.Text = "Minor division";
            this.labelMinorTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridTickSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.tableLayoutPanelMinorTicks);
            this.Controls.Add(this.tableLayoutPanelAddRemoveTick);
            this.Controls.Add(this.textBoxTick);
            this.Controls.Add(this.listBoxTicks);
            this.Controls.Add(this.labelTicks);
            this.Name = "GridTickSelector";
            this.Size = new System.Drawing.Size(183, 415);
            this.tableLayoutPanelAddRemoveTick.ResumeLayout(false);
            this.tableLayoutPanelMinorTicks.ResumeLayout(false);
            this.tableLayoutPanelMinorTicks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTicks;
        private System.Windows.Forms.Label labelTicks;
        private System.Windows.Forms.TextBox textBoxTick;
        private System.Windows.Forms.Button buttonAddTick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddRemoveTick;
        private System.Windows.Forms.Button buttonRemoveTick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMinorTicks;
        private System.Windows.Forms.Label labelMinorTick;
        private System.Windows.Forms.TextBox textBoxMinorTicks;
    }
}
