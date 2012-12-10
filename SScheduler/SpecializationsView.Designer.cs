namespace SScheduler
{
    partial class SpecializationsView
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
            this.DG_specs = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BT_confirm_specs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_specs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_specs
            // 
            this.DG_specs.AllowUserToAddRows = false;
            this.DG_specs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_specs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_specs.Location = new System.Drawing.Point(0, 0);
            this.DG_specs.Name = "DG_specs";
            this.DG_specs.Size = new System.Drawing.Size(351, 379);
            this.DG_specs.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DG_specs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BT_confirm_specs);
            this.splitContainer1.Size = new System.Drawing.Size(351, 423);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 1;
            // 
            // BT_confirm_specs
            // 
            this.BT_confirm_specs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_confirm_specs.Location = new System.Drawing.Point(0, 0);
            this.BT_confirm_specs.Name = "BT_confirm_specs";
            this.BT_confirm_specs.Size = new System.Drawing.Size(351, 40);
            this.BT_confirm_specs.TabIndex = 0;
            this.BT_confirm_specs.Text = "Zatwierdź !";
            this.BT_confirm_specs.UseVisualStyleBackColor = true;
            this.BT_confirm_specs.Click += new System.EventHandler(this.BT_confirm_specs_Click);
            // 
            // SpecializationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 423);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SpecializationsView";
            this.Text = "Wybierz specjalizację!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpecializationsView_FormClosing);
            this.Load += new System.EventHandler(this.SpecializationsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_specs)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_specs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BT_confirm_specs;
    }
}