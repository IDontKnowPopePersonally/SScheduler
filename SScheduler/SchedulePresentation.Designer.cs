namespace SScheduler
{
    partial class SchedulePresentation
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LB_description2 = new System.Windows.Forms.Label();
            this.LB_path = new System.Windows.Forms.Label();
            this.BT_ChangePath = new System.Windows.Forms.Button();
            this.LB_description1 = new System.Windows.Forms.Label();
            this.TB_Path = new System.Windows.Forms.TextBox();
            this.BT_utworzPlan = new System.Windows.Forms.Button();
            this.RB_nauczyciel = new System.Windows.Forms.RadioButton();
            this.RB_sala = new System.Windows.Forms.RadioButton();
            this.RB_klasa = new System.Windows.Forms.RadioButton();
            this.DG_elements = new System.Windows.Forms.DataGridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.LBox_generatedSchedules = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_elements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DG_elements);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(814, 616);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // LB_description2
            // 
            this.LB_description2.Location = new System.Drawing.Point(21, 75);
            this.LB_description2.Name = "LB_description2";
            this.LB_description2.Size = new System.Drawing.Size(181, 28);
            this.LB_description2.TabIndex = 8;
            this.LB_description2.Text = "2. Zaznacz konkretne podmioty dla których chesz wygenerować plan.";
            // 
            // LB_path
            // 
            this.LB_path.AutoSize = true;
            this.LB_path.Location = new System.Drawing.Point(21, 163);
            this.LB_path.Name = "LB_path";
            this.LB_path.Size = new System.Drawing.Size(182, 13);
            this.LB_path.TabIndex = 7;
            this.LB_path.Text = "Wygenerowane plany znajdują się w:";
            // 
            // BT_ChangePath
            // 
            this.BT_ChangePath.Location = new System.Drawing.Point(65, 208);
            this.BT_ChangePath.Name = "BT_ChangePath";
            this.BT_ChangePath.Size = new System.Drawing.Size(85, 23);
            this.BT_ChangePath.TabIndex = 6;
            this.BT_ChangePath.Text = "Zmień katalog";
            this.BT_ChangePath.UseVisualStyleBackColor = true;
            this.BT_ChangePath.Click += new System.EventHandler(this.BT_ChangePath_Click);
            // 
            // LB_description1
            // 
            this.LB_description1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LB_description1.Location = new System.Drawing.Point(12, 9);
            this.LB_description1.Name = "LB_description1";
            this.LB_description1.Size = new System.Drawing.Size(194, 31);
            this.LB_description1.TabIndex = 3;
            this.LB_description1.Text = "1. Wybierz dla jakiej grupy chcesz wygenerować graficzną wersję planu:";
            this.LB_description1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Path
            // 
            this.TB_Path.Location = new System.Drawing.Point(18, 182);
            this.TB_Path.Name = "TB_Path";
            this.TB_Path.ReadOnly = true;
            this.TB_Path.Size = new System.Drawing.Size(187, 20);
            this.TB_Path.TabIndex = 5;
            // 
            // BT_utworzPlan
            // 
            this.BT_utworzPlan.Location = new System.Drawing.Point(40, 119);
            this.BT_utworzPlan.Name = "BT_utworzPlan";
            this.BT_utworzPlan.Size = new System.Drawing.Size(133, 23);
            this.BT_utworzPlan.TabIndex = 4;
            this.BT_utworzPlan.Text = "Utwórz";
            this.BT_utworzPlan.UseVisualStyleBackColor = true;
            this.BT_utworzPlan.Click += new System.EventHandler(this.BT_utworzPlan_Click);
            // 
            // RB_nauczyciel
            // 
            this.RB_nauczyciel.AutoSize = true;
            this.RB_nauczyciel.Location = new System.Drawing.Point(119, 43);
            this.RB_nauczyciel.Name = "RB_nauczyciel";
            this.RB_nauczyciel.Size = new System.Drawing.Size(77, 17);
            this.RB_nauczyciel.TabIndex = 2;
            this.RB_nauczyciel.TabStop = true;
            this.RB_nauczyciel.Text = "Nauczyciel";
            this.RB_nauczyciel.UseVisualStyleBackColor = true;
            this.RB_nauczyciel.CheckedChanged += new System.EventHandler(this.rButtons_CheckedChanged);
            this.RB_nauczyciel.Click += new System.EventHandler(this.rButtons_CheckedChanged);
            // 
            // RB_sala
            // 
            this.RB_sala.AutoSize = true;
            this.RB_sala.Location = new System.Drawing.Point(71, 43);
            this.RB_sala.Name = "RB_sala";
            this.RB_sala.Size = new System.Drawing.Size(46, 17);
            this.RB_sala.TabIndex = 1;
            this.RB_sala.TabStop = true;
            this.RB_sala.Text = "Sala";
            this.RB_sala.UseVisualStyleBackColor = true;
            this.RB_sala.CheckedChanged += new System.EventHandler(this.rButtons_CheckedChanged);
            this.RB_sala.Click += new System.EventHandler(this.rButtons_CheckedChanged);
            // 
            // RB_klasa
            // 
            this.RB_klasa.AutoSize = true;
            this.RB_klasa.Location = new System.Drawing.Point(15, 43);
            this.RB_klasa.Name = "RB_klasa";
            this.RB_klasa.Size = new System.Drawing.Size(51, 17);
            this.RB_klasa.TabIndex = 0;
            this.RB_klasa.TabStop = true;
            this.RB_klasa.Text = "Klasa";
            this.RB_klasa.UseVisualStyleBackColor = true;
            this.RB_klasa.CheckedChanged += new System.EventHandler(this.rButtons_CheckedChanged);
            this.RB_klasa.Click += new System.EventHandler(this.rButtons_CheckedChanged);
            // 
            // DG_elements
            // 
            this.DG_elements.AllowUserToAddRows = false;
            this.DG_elements.AllowUserToDeleteRows = false;
            this.DG_elements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_elements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_elements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_elements.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DG_elements.Location = new System.Drawing.Point(0, 0);
            this.DG_elements.Name = "DG_elements";
            this.DG_elements.Size = new System.Drawing.Size(598, 616);
            this.DG_elements.TabIndex = 5;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(598, 616);
            this.webBrowser1.TabIndex = 0;
            // 
            // LBox_generatedSchedules
            // 
            this.LBox_generatedSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBox_generatedSchedules.FormattingEnabled = true;
            this.LBox_generatedSchedules.Location = new System.Drawing.Point(0, 0);
            this.LBox_generatedSchedules.Name = "LBox_generatedSchedules";
            this.LBox_generatedSchedules.Size = new System.Drawing.Size(212, 357);
            this.LBox_generatedSchedules.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.BT_ChangePath);
            this.splitContainer2.Panel1.Controls.Add(this.LB_description2);
            this.splitContainer2.Panel1.Controls.Add(this.RB_klasa);
            this.splitContainer2.Panel1.Controls.Add(this.LB_path);
            this.splitContainer2.Panel1.Controls.Add(this.RB_sala);
            this.splitContainer2.Panel1.Controls.Add(this.RB_nauczyciel);
            this.splitContainer2.Panel1.Controls.Add(this.LB_description1);
            this.splitContainer2.Panel1.Controls.Add(this.BT_utworzPlan);
            this.splitContainer2.Panel1.Controls.Add(this.TB_Path);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.LBox_generatedSchedules);
            this.splitContainer2.Size = new System.Drawing.Size(212, 616);
            this.splitContainer2.SplitterDistance = 255;
            this.splitContainer2.TabIndex = 10;
            // 
            // SchedulePresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 616);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SchedulePresentation";
            this.Text = "Utwórz graficzną wersję planu!";
            this.Load += new System.EventHandler(this.SchedulePresentation_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_elements)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BT_utworzPlan;
        private System.Windows.Forms.Label LB_description1;
        private System.Windows.Forms.RadioButton RB_nauczyciel;
        private System.Windows.Forms.RadioButton RB_sala;
        private System.Windows.Forms.RadioButton RB_klasa;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView DG_elements;
        private System.Windows.Forms.Label LB_path;
        private System.Windows.Forms.Button BT_ChangePath;
        private System.Windows.Forms.TextBox TB_Path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label LB_description2;
        private System.Windows.Forms.ListBox LBox_generatedSchedules;
        private System.Windows.Forms.SplitContainer splitContainer2;


    }
}