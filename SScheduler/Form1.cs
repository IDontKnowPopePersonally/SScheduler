using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SScheduler
{
    public partial class Form1 : Form
    {
        public DataClassesDataContext dcdc;
        public static readonly string connectionString = "Data Source=148.81.130.59;Initial Catalog=db143275;User ID=st143275;Password=p143275";

        public enum opcjeGlowne
        {
            Wygeneruj_plan = 0x01,
            Dodaj_dane_do_bazy = 0x02
        }

        public enum atomy
        {
            Klasa = 0x01,
            Sala = 0x02,
            Nauczyciel = 0x03,
            Przedmiot = 0x04
        }

        public Form1()
        {
            InitializeComponent();
        }

        List<GroupBox> grupery_input;
        private bool isInitialized = false;
        private void Form1_Load(object sender, EventArgs e)
        {            
            this.Height = 116;
            this.Width = 340;
            
            grupery_input = new List<GroupBox>(){ 
                GB_Klasa,
                GB_Nauczyciel,
                GB_Przedmiot,
                GB_Sala};

            grupery_input.ForEach(gb =>
            {
                gb.Visible = false;
                gb.Top = 43;
                gb.Left = 323;
            });

            CB_menu1.DataSource = Enum.GetValues(typeof(opcjeGlowne)); 
            CB_menu2.DataSource = Enum.GetValues(typeof(atomy));
            CB_menu1.Text = "Wybierz opcję..";
            CB_menu2.Text = "Wybierz opcję..";
            isInitialized = true;          
        }

        public List<Guid> checkedSpecs;
        private void button1_Click(object sender, EventArgs e)
        {            
            dcdc = new DataClassesDataContext(connectionString);

            try
            {
                if ((atomy)CB_menu2.SelectedItem == atomy.Klasa)
                {
                    klasa nowa_klasa = new klasa();
                    nowa_klasa.identyfikator = TB_K_identyfikator_klasy.Text[0];
                    nowa_klasa.liczebnosc = short.Parse(TB_K_liczebnosc_klasy.Text);
                    nowa_klasa.rok = byte.Parse(TB_K_rok_klasy.Text);
                    nowa_klasa.id_klasa = Guid.NewGuid();
                    dcdc.klasas.InsertOnSubmit(nowa_klasa);
                    TB_K_identyfikator_klasy.Text = string.Empty;
                    TB_K_liczebnosc_klasy.Text = string.Empty;
                    TB_K_rok_klasy.Text = string.Empty;
                }
                else
                    if ((atomy)CB_menu2.SelectedItem == atomy.Sala)
                    {
                        sala nowa_sala = new sala();
                        nowa_sala.id_sala = Guid.NewGuid();
                        nowa_sala.numer = short.Parse(TB_S_numer.Text);
                        nowa_sala.pojemnosc = byte.Parse(TB_S_pojemnosc.Text);
                        dcdc.salas.InsertOnSubmit(nowa_sala);
                        TB_S_numer.Text = string.Empty;
                        TB_S_pojemnosc.Text = string.Empty;
                    }
                    else
                        if ((atomy)CB_menu2.SelectedItem == atomy.Nauczyciel)
                        {
                            nauczyciel nowy_nauczyciel = new nauczyciel();
                            nowy_nauczyciel.id_nauczyciel = Guid.NewGuid();
                            nowy_nauczyciel.imie = TB_N_imie.Text;
                            nowy_nauczyciel.nazwisko = TB_N_nazwisko.Text;
                            //nowy_nauczyciel.id_specjalizacja =  ((przedmiot)dcdc.przedmiots.Where(przdmt => przdmt.nazwa == CB_spec_nauczyciel.SelectedText)).id_przedmiot;
                            dcdc.nauczyciels.InsertOnSubmit(nowy_nauczyciel);
                            foreach (Guid specID in checkedSpecs)
                            {
                                nauczyciel_przedmiot naucz_przdmt = new nauczyciel_przedmiot();
                                naucz_przdmt.id_nauczyciel_przedmiot = Guid.NewGuid();
                                naucz_przdmt.id_nauczyciel = nowy_nauczyciel.id_nauczyciel;
                                naucz_przdmt.id_przedmiot = specID;
                                dcdc.nauczyciel_przedmiots.InsertOnSubmit(naucz_przdmt);
                            }
                            TB_N_imie.Text = string.Empty;
                            TB_N_nazwisko.Text = string.Empty;
                            CB_spec_nauczyciel.Text = "Wybierz przedmiot";
                        }
                        else
                            if ((atomy)CB_menu2.SelectedItem == atomy.Przedmiot)
                            {
                                przedmiot nowy_przedmiot = new przedmiot();
                                nowy_przedmiot.id_przedmiot = Guid.NewGuid();
                                nowy_przedmiot.nazwa = TB_P_nazwa.Text;
                                dcdc.przedmiots.InsertOnSubmit(nowy_przedmiot);
                                TB_P_nazwa.Text = string.Empty;
                            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane !","", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            dcdc.SubmitChanges();            
        }

        private void CB_menu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitialized)
            {
                if (this.Height < 200)
                    for (int i = 0; i < 125; i++)
                    {
                        this.Height += 1;
                        Thread.Sleep(1);
                    }

                if ((opcjeGlowne)CB_menu1.SelectedItem == opcjeGlowne.Wygeneruj_plan)
                {
                    if (this.Width > 350)
                        for (int i = 0; i < 230; i++)
                        {
                            this.Width -= 1;
                            Thread.Sleep(1);
                        }

                    //LB_menu2.Text = "Dla kogo wygenerować?";
                    CB_menu2.Visible = false;
                    LB_menu2.Visible = false;
                    GB_menu2.Text = "Generuj plan";
                    BT_generateSchedule.Visible = true;
                    GB_menu2.Visible = true;
                    
                }

                if ((opcjeGlowne)CB_menu1.SelectedItem == opcjeGlowne.Dodaj_dane_do_bazy)
                {
                    CB_menu2.Text = "Wybierz opcję...";
                    GB_menu2.Text = "Dodaj dane";
                    LB_menu2.Text = "Co chcesz dodać?";
                    BT_generateSchedule.Visible = false;
                    CB_menu2.Visible = true;
                    LB_menu2.Visible = true;
                    GB_menu2.Visible = true;                    
                }
            }
        }

        private void CB_jakie_dodac_dane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitialized)
            {

                if ((opcjeGlowne)CB_menu1.SelectedItem == opcjeGlowne.Dodaj_dane_do_bazy)
                {                    
                    dodajAct();
                }
                else
                    if ((opcjeGlowne)CB_menu1.SelectedItem == opcjeGlowne.Wygeneruj_plan)
                    {
                        BT_generateSchedule.Visible = true;
                    }
            }
        }

        private void dodajAct()
        {
            if (this.Width < 350)
                for (int i = 0; i < 230; i++)
                {
                    this.Width += 1;
                    Thread.Sleep(1);
                }

            if ((atomy)CB_menu2.SelectedItem == atomy.Klasa)
            {
                grupery_input.ForEach(gb => gb.Visible = false);
                GB_Klasa.Visible = true;
            }
            else
                if ((atomy)CB_menu2.SelectedItem == atomy.Sala)
                {
                    grupery_input.ForEach(gb => gb.Visible = false);
                    GB_Sala.Visible = true;
                }
                else
                    if ((atomy)CB_menu2.SelectedItem == atomy.Nauczyciel)
                    {
                        grupery_input.ForEach(gb => gb.Visible = false);
                        GB_Nauczyciel.Visible = true;
                        dcdc = new DataClassesDataContext(connectionString);
                        dcdc.przedmiots.ToList<object>();
                    }
                    else
                        if ((atomy)CB_menu2.SelectedItem == atomy.Przedmiot)
                        {
                            grupery_input.ForEach(gb => gb.Visible = false);
                            GB_Przedmiot.Visible = true;
                        }

            BT_dodaj_dane.Visible = true;
        }

        private void CB_spec_nauczyciel_Click(object sender, EventArgs e)
        {
            dcdc =  new DataClassesDataContext(connectionString);
            List<object> nazwy_przedmiotow = new List<object>();
            dcdc.przedmiots.ToList().ForEach( przdmt => nazwy_przedmiotow.Add(przdmt.nazwa));
            if (!nazwy_przedmiotow.All(przdmt => CB_spec_nauczyciel.Items.Contains(przdmt)))
            {
                CB_spec_nauczyciel.Items.Clear();
                CB_spec_nauczyciel.Items.AddRange(nazwy_przedmiotow.ToArray());
            }
        }
                
        GenerateSchedule genSch;
        private void BT_generateSchedule_Click(object sender, EventArgs e)
        {
            BW_generateSchedule.RunWorkerAsync();
            
            genSch = new GenerateSchedule(this);
            genSch.ShowDialog();                          
        }

        private void BW_generateSchedule_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 101; i++)
            {
                if (BW_generateSchedule.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                // tu plan się tworzyć będzie.

                Thread.Sleep(50);
                BW_generateSchedule.ReportProgress(i);                              
            }
            
        }

        private void BW_generateSchedule_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            genSch.progressBar1.Value = e.ProgressPercentage;
            genSch.Text = e.ProgressPercentage.ToString() + "%";            
        }

        private void BW_generateSchedule_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            genSch.Dispose();
            if (e.Cancelled)
                return;

            SchedulePresentation schPresentation = new SchedulePresentation();
            schPresentation.ShowDialog();
        }

        private void BT_chose_spec_Click(object sender, EventArgs e)
        {
            if (TB_N_imie.Text != String.Empty && TB_N_nazwisko.Text != String.Empty)
            {
                SpecializationsView specView = new SpecializationsView(this);
                specView.ShowDialog();
            }
            else
                MessageBox.Show("Najpierw wypełnij pola Imię oraz Nazwisko!", "Ogarnij się!", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
        }




    }
}
