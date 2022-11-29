namespace DataPlotter
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_xVar = new System.Windows.Forms.Label();
            this.btn_dataFilePath = new System.Windows.Forms.Button();
            this.label_dataPath = new System.Windows.Forms.Label();
            this.btn_InfoPath = new System.Windows.Forms.Button();
            this.label_infoPath = new System.Windows.Forms.Label();
            this.listBox_xVar = new System.Windows.Forms.ListBox();
            this.label_yVar = new System.Windows.Forms.Label();
            this.listBox_yVar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_yVar2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_yVar2Levels = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label_xVar
            // 
            this.label_xVar.AutoSize = true;
            this.label_xVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_xVar.Location = new System.Drawing.Point(8, 339);
            this.label_xVar.Name = "label_xVar";
            this.label_xVar.Size = new System.Drawing.Size(131, 19);
            this.label_xVar.TabIndex = 1;
            this.label_xVar.Text = "X-axis variable";
            // 
            // btn_dataFilePath
            // 
            this.btn_dataFilePath.Location = new System.Drawing.Point(12, 12);
            this.btn_dataFilePath.Name = "btn_dataFilePath";
            this.btn_dataFilePath.Size = new System.Drawing.Size(95, 30);
            this.btn_dataFilePath.TabIndex = 2;
            this.btn_dataFilePath.Text = "Data File";
            this.btn_dataFilePath.UseVisualStyleBackColor = true;
            this.btn_dataFilePath.Click += new System.EventHandler(this.btn_dataFilePath_Click);
            // 
            // label_dataPath
            // 
            this.label_dataPath.AutoSize = true;
            this.label_dataPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_dataPath.Location = new System.Drawing.Point(113, 18);
            this.label_dataPath.Name = "label_dataPath";
            this.label_dataPath.Size = new System.Drawing.Size(133, 19);
            this.label_dataPath.TabIndex = 3;
            this.label_dataPath.Text = "No loaded data";
            // 
            // btn_InfoPath
            // 
            this.btn_InfoPath.Location = new System.Drawing.Point(12, 62);
            this.btn_InfoPath.Name = "btn_InfoPath";
            this.btn_InfoPath.Size = new System.Drawing.Size(95, 30);
            this.btn_InfoPath.TabIndex = 2;
            this.btn_InfoPath.Text = "Info File";
            this.btn_InfoPath.UseVisualStyleBackColor = true;
            this.btn_InfoPath.Click += new System.EventHandler(this.btn_InfoPath_Click);
            // 
            // label_infoPath
            // 
            this.label_infoPath.AutoSize = true;
            this.label_infoPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_infoPath.Location = new System.Drawing.Point(113, 68);
            this.label_infoPath.Name = "label_infoPath";
            this.label_infoPath.Size = new System.Drawing.Size(133, 19);
            this.label_infoPath.TabIndex = 3;
            this.label_infoPath.Text = "No loaded data";
            // 
            // listBox_xVar
            // 
            this.listBox_xVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.listBox_xVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.listBox_xVar.FormattingEnabled = true;
            this.listBox_xVar.ItemHeight = 19;
            this.listBox_xVar.Location = new System.Drawing.Point(12, 123);
            this.listBox_xVar.Name = "listBox_xVar";
            this.listBox_xVar.Size = new System.Drawing.Size(230, 213);
            this.listBox_xVar.TabIndex = 4;
            // 
            // label_yVar
            // 
            this.label_yVar.AutoSize = true;
            this.label_yVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label_yVar.Location = new System.Drawing.Point(244, 339);
            this.label_yVar.Name = "label_yVar";
            this.label_yVar.Size = new System.Drawing.Size(140, 38);
            this.label_yVar.TabIndex = 1;
            this.label_yVar.Text = "Y-axis variable\r\n(distinct curves)";
            // 
            // listBox_yVar
            // 
            this.listBox_yVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.listBox_yVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.listBox_yVar.FormattingEnabled = true;
            this.listBox_yVar.ItemHeight = 19;
            this.listBox_yVar.Location = new System.Drawing.Point(248, 123);
            this.listBox_yVar.Name = "listBox_yVar";
            this.listBox_yVar.Size = new System.Drawing.Size(230, 213);
            this.listBox_yVar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(480, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "2nd y-axis variable";
            // 
            // listBox_yVar2
            // 
            this.listBox_yVar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.listBox_yVar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.listBox_yVar2.FormattingEnabled = true;
            this.listBox_yVar2.ItemHeight = 19;
            this.listBox_yVar2.Location = new System.Drawing.Point(484, 123);
            this.listBox_yVar2.Name = "listBox_yVar2";
            this.listBox_yVar2.Size = new System.Drawing.Size(230, 80);
            this.listBox_yVar2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(480, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "2nd y-axis variable level";
            // 
            // listBox_yVar2Levels
            // 
            this.listBox_yVar2Levels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.listBox_yVar2Levels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.listBox_yVar2Levels.FormattingEnabled = true;
            this.listBox_yVar2Levels.ItemHeight = 19;
            this.listBox_yVar2Levels.Location = new System.Drawing.Point(484, 256);
            this.listBox_yVar2Levels.Name = "listBox_yVar2Levels";
            this.listBox_yVar2Levels.Size = new System.Drawing.Size(230, 80);
            this.listBox_yVar2Levels.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.listBox_yVar2Levels);
            this.Controls.Add(this.listBox_yVar2);
            this.Controls.Add(this.listBox_yVar);
            this.Controls.Add(this.listBox_xVar);
            this.Controls.Add(this.label_infoPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_dataPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_InfoPath);
            this.Controls.Add(this.label_yVar);
            this.Controls.Add(this.btn_dataFilePath);
            this.Controls.Add(this.label_xVar);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Home";
            this.Text = "DataPlotter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_xVar;
        private System.Windows.Forms.Button btn_dataFilePath;
        private System.Windows.Forms.Label label_dataPath;
        private System.Windows.Forms.Button btn_InfoPath;
        private System.Windows.Forms.Label label_infoPath;
        private System.Windows.Forms.ListBox listBox_xVar;
        private System.Windows.Forms.Label label_yVar;
        private System.Windows.Forms.ListBox listBox_yVar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_yVar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_yVar2Levels;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

