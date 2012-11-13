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
        public string connectionString = "Data Source=148.81.130.59;Initial Catalog=db143275;User ID=st143275;Password=p143275";


        public Form1()
        {
            InitializeComponent();
        }
        string[] co_zrobic;
        string[] ktore_dane;
        List<GroupBox> grupery_input;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "School Scheduler";
            this.Height = 116;
            this.Width = 340;


            GB_Dodaj_dane.Visible = false;
            BT_dodaj_dane.Visible = false;

            co_zrobic = new string[]{
                "Wygenerować plan!",
                "Dodać dane do bazy!"};
            ktore_dane = new string[]{
                "Klasę",
                "Salę",
                "Nauczyciela",
                "Przedmiot"};
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

            for(int i = 0 ; i<co_zrobic.Length ; i++)
                CB_co_zrobic.Items.Add(co_zrobic[i]);

            for (int i = 0; i < ktore_dane.Length; i++)
                CB_jakie_dodac_dane.Items.Add(ktore_dane[i]);
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            dcdc = new DataClassesDataContext(connectionString);

            try
            {
                if (CB_jakie_dodac_dane.SelectedItem == ktore_dane[0])
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
                    if (CB_jakie_dodac_dane.SelectedItem == ktore_dane[1])
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
                        if (CB_jakie_dodac_dane.SelectedItem == ktore_dane[2])
                        {
                            nauczyciel nowy_nauczyciel = new nauczyciel();
                            nowy_nauczyciel.id_nauczyciel = Guid.NewGuid();
                            nowy_nauczyciel.imie = TB_N_imie.Text;
                            nowy_nauczyciel.nazwisko = TB_N_nazwisko.Text;
                            //nowy_nauczyciel.id_specjalizacja =  ((przedmiot)dcdc.przedmiots.Where(przdmt => przdmt.nazwa == CB_spec_nauczyciel.SelectedText)).id_przedmiot;
                            dcdc.nauczyciels.InsertOnSubmit(nowy_nauczyciel);
                            TB_N_imie.Text = string.Empty;
                            TB_N_nazwisko.Text = string.Empty;
                            CB_spec_nauczyciel.Text = "Wybierz przedmiot";
                        }
                        else
                            if (CB_jakie_dodac_dane.SelectedItem == ktore_dane[3])
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

        private void CB_co_zrobic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.Height < 200)
                for (int i = 0; i < 125; i++)
                {
                    this.Height += 1;
                    Thread.Sleep(1);
                }

            if (CB_co_zrobic.SelectedItem == co_zrobic[0])
                throw new NotImplementedException();

            if (CB_co_zrobic.SelectedItem == co_zrobic[1])
                GB_Dodaj_dane.Visible = true;
        }

        private void CB_jakie_dodac_dane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Width < 350)
                for (int i = 0; i < 230; i++)
                {
                    this.Width += 1;
                    Thread.Sleep(1);
                }
            if (CB_jakie_dodac_dane.SelectedItem == ktore_dane[0])
            {
                grupery_input.ForEach(gb => gb.Visible = false);
                GB_Klasa.Visible = true;
            }
            if (CB_jakie_dodac_dane.SelectedItem == ktore_dane[1])
            {
                grupery_input.ForEach(gb => gb.Visible = false);
                GB_Sala.Visible = true;
            }
            if (CB_jakie_dodac_dane.SelectedItem == ktore_dane[2])
            {
                grupery_input.ForEach(gb => gb.Visible = false);
                GB_Nauczyciel.Visible = true;
                dcdc = new DataClassesDataContext(connectionString);
                dcdc.przedmiots.ToList<object>();
            }
            if (CB_jakie_dodac_dane.SelectedItem == ktore_dane[3])
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

    }
}
