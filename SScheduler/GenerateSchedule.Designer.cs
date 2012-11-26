namespace SScheduler
{
    partial class GenerateSchedule
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BT_AbortGenerating = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // BT_AbortGenerating
            // 
            this.BT_AbortGenerating.Location = new System.Drawing.Point(301, 38);
            this.BT_AbortGenerating.Name = "BT_AbortGenerating";
            this.BT_AbortGenerating.Size = new System.Drawing.Size(84, 23);
            this.BT_AbortGenerating.TabIndex = 1;
            this.BT_AbortGenerating.Text = "Przerwij";
            this.BT_AbortGenerating.UseVisualStyleBackColor = true;
            this.BT_AbortGenerating.Click += new System.EventHandler(this.BT_AbortGenerating_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Twój plan jest w trakcie tworzenia. Może to potrwać chwilę..";
            // 
            // GenerateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 73);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_AbortGenerating);
            this.Controls.Add(this.progressBar1);
            this.Name = "GenerateSchedule";
            this.Text = "Tworzenie planu...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenerateSchedule_FormClosed);
            this.Load += new System.EventHandler(this.GenerateSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Button BT_AbortGenerating;
    }
}