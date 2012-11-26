namespace SScheduler
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.klasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db143275DataSet = new SScheduler.db143275DataSet();
            this.klasaTableAdapter = new SScheduler.db143275DataSetTableAdapters.klasaTableAdapter();
            this.BT_dodaj_dane = new System.Windows.Forms.Button();
            this.TB_K_identyfikator_klasy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_K_rok_klasy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_K_liczebnosc_klasy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Klasa = new System.Windows.Forms.GroupBox();
            this.GB_Nauczyciel = new System.Windows.Forms.GroupBox();
            this.CB_spec_nauczyciel = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_N_imie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_N_nazwisko = new System.Windows.Forms.TextBox();
            this.GB_Przedmiot = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_P_nazwa = new System.Windows.Forms.TextBox();
            this.GB_Sala = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_S_pojemnosc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_S_numer = new System.Windows.Forms.TextBox();
            this.CB_menu1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GB_menu2 = new System.Windows.Forms.GroupBox();
            this.BT_generateSchedule = new System.Windows.Forms.Button();
            this.LB_menu2 = new System.Windows.Forms.Label();
            this.CB_menu2 = new System.Windows.Forms.ComboBox();
            this.BW_generateSchedule = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.klasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db143275DataSet)).BeginInit();
            this.GB_Klasa.SuspendLayout();
            this.GB_Nauczyciel.SuspendLayout();
            this.GB_Przedmiot.SuspendLayout();
            this.GB_Sala.SuspendLayout();
            this.GB_menu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // klasaBindingSource
            // 
            this.klasaBindingSource.DataMember = "klasa";
            this.klasaBindingSource.DataSource = this.db143275DataSet;
            // 
            // db143275DataSet
            // 
            this.db143275DataSet.DataSetName = "db143275DataSet";
            this.db143275DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klasaTableAdapter
            // 
            this.klasaTableAdapter.ClearBeforeFill = true;
            // 
            // BT_dodaj_dane
            // 
            this.BT_dodaj_dane.Location = new System.Drawing.Point(323, 163);
            this.BT_dodaj_dane.Name = "BT_dodaj_dane";
            this.BT_dodaj_dane.Size = new System.Drawing.Size(221, 23);
            this.BT_dodaj_dane.TabIndex = 13;
            this.BT_dodaj_dane.Text = "Dodaj!";
            this.BT_dodaj_dane.UseVisualStyleBackColor = true;
            this.BT_dodaj_dane.Visible = false;
            this.BT_dodaj_dane.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_K_identyfikator_klasy
            // 
            this.TB_K_identyfikator_klasy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klasaBindingSource, "rok", true));
            this.TB_K_identyfikator_klasy.Location = new System.Drawing.Point(113, 80);
            this.TB_K_identyfikator_klasy.Name = "TB_K_identyfikator_klasy";
            this.TB_K_identyfikator_klasy.Size = new System.Drawing.Size(100, 20);
            this.TB_K_identyfikator_klasy.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Identyfikator klasy";
            // 
            // TB_K_rok_klasy
            // 
            this.TB_K_rok_klasy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klasaBindingSource, "rok", true));
            this.TB_K_rok_klasy.Location = new System.Drawing.Point(113, 54);
            this.TB_K_rok_klasy.Name = "TB_K_rok_klasy";
            this.TB_K_rok_klasy.Size = new System.Drawing.Size(100, 20);
            this.TB_K_rok_klasy.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rok klasy";
            // 
            // TB_K_liczebnosc_klasy
            // 
            this.TB_K_liczebnosc_klasy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klasaBindingSource, "liczebnosc", true));
            this.TB_K_liczebnosc_klasy.Location = new System.Drawing.Point(113, 28);
            this.TB_K_liczebnosc_klasy.Name = "TB_K_liczebnosc_klasy";
            this.TB_K_liczebnosc_klasy.Size = new System.Drawing.Size(100, 20);
            this.TB_K_liczebnosc_klasy.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Liczebność klasy";
            // 
            // GB_Klasa
            // 
            this.GB_Klasa.Controls.Add(this.label1);
            this.GB_Klasa.Controls.Add(this.TB_K_identyfikator_klasy);
            this.GB_Klasa.Controls.Add(this.TB_K_liczebnosc_klasy);
            this.GB_Klasa.Controls.Add(this.label3);
            this.GB_Klasa.Controls.Add(this.label2);
            this.GB_Klasa.Controls.Add(this.TB_K_rok_klasy);
            this.GB_Klasa.Location = new System.Drawing.Point(323, 43);
            this.GB_Klasa.Name = "GB_Klasa";
            this.GB_Klasa.Size = new System.Drawing.Size(221, 114);
            this.GB_Klasa.TabIndex = 14;
            this.GB_Klasa.TabStop = false;
            this.GB_Klasa.Text = "Klasa";
            // 
            // GB_Nauczyciel
            // 
            this.GB_Nauczyciel.Controls.Add(this.CB_spec_nauczyciel);
            this.GB_Nauczyciel.Controls.Add(this.label12);
            this.GB_Nauczyciel.Controls.Add(this.label4);
            this.GB_Nauczyciel.Controls.Add(this.TB_N_imie);
            this.GB_Nauczyciel.Controls.Add(this.label6);
            this.GB_Nauczyciel.Controls.Add(this.TB_N_nazwisko);
            this.GB_Nauczyciel.Location = new System.Drawing.Point(611, 132);
            this.GB_Nauczyciel.Name = "GB_Nauczyciel";
            this.GB_Nauczyciel.Size = new System.Drawing.Size(221, 114);
            this.GB_Nauczyciel.TabIndex = 15;
            this.GB_Nauczyciel.TabStop = false;
            this.GB_Nauczyciel.Text = "Nauczyciel";
            // 
            // CB_spec_nauczyciel
            // 
            this.CB_spec_nauczyciel.FormattingEnabled = true;
            this.CB_spec_nauczyciel.Location = new System.Drawing.Point(103, 80);
            this.CB_spec_nauczyciel.Name = "CB_spec_nauczyciel";
            this.CB_spec_nauczyciel.Size = new System.Drawing.Size(110, 21);
            this.CB_spec_nauczyciel.TabIndex = 13;
            this.CB_spec_nauczyciel.Text = "Wybierz przedmiot..";
            this.CB_spec_nauczyciel.Click += new System.EventHandler(this.CB_spec_nauczyciel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Uprawniony do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Imię";
            // 
            // TB_N_imie
            // 
            this.TB_N_imie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klasaBindingSource, "liczebnosc", true));
            this.TB_N_imie.Location = new System.Drawing.Point(113, 28);
            this.TB_N_imie.Name = "TB_N_imie";
            this.TB_N_imie.Size = new System.Drawing.Size(100, 20);
            this.TB_N_imie.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nazwisko";
            // 
            // TB_N_nazwisko
            // 
            this.TB_N_nazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klasaBindingSource, "rok", true));
            this.TB_N_nazwisko.Location = new System.Drawing.Point(113, 54);
            this.TB_N_nazwisko.Name = "TB_N_nazwisko";
            this.TB_N_nazwisko.Size = new System.Drawing.Size(100, 20);
            this.TB_N_nazwisko.TabIndex = 10;
            // 
            // GB_Przedmiot
            // 
            this.GB_Przedmiot.Controls.Add(this.label7);
            this.GB_Przedmiot.Controls.Add(this.TB_P_nazwa);
            this.GB_Przedmiot.Location = new System.Drawing.Point(611, 252);
            this.GB_Przedmiot.Name = "GB_Przedmiot";
            this.GB_Przedmiot.Size = new System.Drawing.Size(221, 114);
            this.GB_Przedmiot.TabIndex = 15;
            this.GB_Przedmiot.TabStop = false;
            this.GB_Przedmiot.Text = "Przedmiot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nazwa";
            // 
            // TB_P_nazwa
            // 
            this.TB_P_nazwa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klasaBindingSource, "liczebnosc", true));
            this.TB_P_nazwa.Location = new System.Drawing.Point(113, 28);
            this.TB_P_nazwa.Name = "TB_P_nazwa";
            this.TB_P_nazwa.Size = new System.Drawing.Size(100, 20);
            this.TB_P_nazwa.TabIndex = 8;
            // 
            // GB_Sala
            // 
            this.GB_Sala.Controls.Add(this.label8);
            this.GB_Sala.Controls.Add(this.TB_S_pojemnosc);
            this.GB_Sala.Controls.Add(this.label10);
            this.GB_Sala.Controls.Add(this.TB_S_numer);
            this.GB_Sala.Location = new System.Drawing.Point(611, 12);
            this.GB_Sala.Name = "GB_Sala";
            this.GB_Sala.Size = new System.Drawing.Size(221, 114);
            this.GB_Sala.TabIndex = 15;
            this.GB_Sala.TabStop = false;
            this.GB_Sala.Text = "Sala";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pojemność";
            // 
            // TB_S_pojemnosc
            // 
            this.TB_S_pojemnosc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klasaBindingSource, "liczebnosc", true));
            this.TB_S_pojemnosc.Location = new System.Drawing.Point(113, 28);
            this.TB_S_pojemnosc.Name = "TB_S_pojemnosc";
            this.TB_S_pojemnosc.Size = new System.Drawing.Size(100, 20);
            this.TB_S_pojemnosc.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Numer";
            // 
            // TB_S_numer
            // 
            this.TB_S_numer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klasaBindingSource, "rok", true));
            this.TB_S_numer.Location = new System.Drawing.Point(113, 54);
            this.TB_S_numer.Name = "TB_S_numer";
            this.TB_S_numer.Size = new System.Drawing.Size(100, 20);
            this.TB_S_numer.TabIndex = 10;
            // 
            // CB_menu1
            // 
            this.CB_menu1.FormattingEnabled = true;
            this.CB_menu1.Location = new System.Drawing.Point(132, 43);
            this.CB_menu1.Name = "CB_menu1";
            this.CB_menu1.Size = new System.Drawing.Size(158, 21);
            this.CB_menu1.TabIndex = 16;
            this.CB_menu1.Text = "Wybierz opcję..";
            this.CB_menu1.SelectedIndexChanged += new System.EventHandler(this.CB_menu1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Witaj w School Scheduler!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Co chcesz zrobić ?";
            // 
            // GB_menu2
            // 
            this.GB_menu2.Controls.Add(this.BT_generateSchedule);
            this.GB_menu2.Controls.Add(this.LB_menu2);
            this.GB_menu2.Controls.Add(this.CB_menu2);
            this.GB_menu2.Location = new System.Drawing.Point(32, 86);
            this.GB_menu2.Name = "GB_menu2";
            this.GB_menu2.Size = new System.Drawing.Size(258, 100);
            this.GB_menu2.TabIndex = 19;
            this.GB_menu2.TabStop = false;
            this.GB_menu2.Text = "Dodaj dane";
            this.GB_menu2.Visible = false;
            // 
            // BT_generateSchedule
            // 
            this.BT_generateSchedule.Location = new System.Drawing.Point(142, 67);
            this.BT_generateSchedule.Name = "BT_generateSchedule";
            this.BT_generateSchedule.Size = new System.Drawing.Size(110, 23);
            this.BT_generateSchedule.TabIndex = 2;
            this.BT_generateSchedule.Text = "Generuj !";
            this.BT_generateSchedule.UseVisualStyleBackColor = true;
            this.BT_generateSchedule.Visible = false;
            this.BT_generateSchedule.Click += new System.EventHandler(this.BT_generateSchedule_Click);
            // 
            // LB_menu2
            // 
            this.LB_menu2.AutoSize = true;
            this.LB_menu2.Location = new System.Drawing.Point(6, 43);
            this.LB_menu2.Name = "LB_menu2";
            this.LB_menu2.Size = new System.Drawing.Size(96, 13);
            this.LB_menu2.TabIndex = 1;
            this.LB_menu2.Text = "Co chcesz dodać?";
            // 
            // CB_menu2
            // 
            this.CB_menu2.FormattingEnabled = true;
            this.CB_menu2.Location = new System.Drawing.Point(142, 40);
            this.CB_menu2.Name = "CB_menu2";
            this.CB_menu2.Size = new System.Drawing.Size(110, 21);
            this.CB_menu2.TabIndex = 0;
            this.CB_menu2.Text = "Wybierz opcję..";
            this.CB_menu2.SelectedIndexChanged += new System.EventHandler(this.CB_jakie_dodac_dane_SelectedIndexChanged);
            // 
            // BW_generateSchedule
            // 
            this.BW_generateSchedule.WorkerReportsProgress = true;
            this.BW_generateSchedule.WorkerSupportsCancellation = true;
            this.BW_generateSchedule.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_generateSchedule_DoWork);
            this.BW_generateSchedule.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_generateSchedule_ProgressChanged);
            this.BW_generateSchedule.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_generateSchedule_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 345);
            this.Controls.Add(this.GB_menu2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_menu1);
            this.Controls.Add(this.GB_Sala);
            this.Controls.Add(this.GB_Przedmiot);
            this.Controls.Add(this.GB_Nauczyciel);
            this.Controls.Add(this.BT_dodaj_dane);
            this.Controls.Add(this.GB_Klasa);
            this.Name = "Form1";
            this.Text = "School Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db143275DataSet)).EndInit();
            this.GB_Klasa.ResumeLayout(false);
            this.GB_Klasa.PerformLayout();
            this.GB_Nauczyciel.ResumeLayout(false);
            this.GB_Nauczyciel.PerformLayout();
            this.GB_Przedmiot.ResumeLayout(false);
            this.GB_Przedmiot.PerformLayout();
            this.GB_Sala.ResumeLayout(false);
            this.GB_Sala.PerformLayout();
            this.GB_menu2.ResumeLayout(false);
            this.GB_menu2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource klasaBindingSource;
        private db143275DataSetTableAdapters.klasaTableAdapter klasaTableAdapter;
        private System.Windows.Forms.Button BT_dodaj_dane;
        private System.Windows.Forms.TextBox TB_K_identyfikator_klasy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_K_rok_klasy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_K_liczebnosc_klasy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_Klasa;
        public db143275DataSet db143275DataSet;
        private System.Windows.Forms.GroupBox GB_Nauczyciel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_N_imie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_N_nazwisko;
        private System.Windows.Forms.GroupBox GB_Przedmiot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_P_nazwa;
        private System.Windows.Forms.GroupBox GB_Sala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_S_pojemnosc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_S_numer;
        private System.Windows.Forms.ComboBox CB_menu1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GB_menu2;
        private System.Windows.Forms.Label LB_menu2;
        private System.Windows.Forms.ComboBox CB_menu2;
        private System.Windows.Forms.ComboBox CB_spec_nauczyciel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BT_generateSchedule;
        public System.ComponentModel.BackgroundWorker BW_generateSchedule;
    }
}

