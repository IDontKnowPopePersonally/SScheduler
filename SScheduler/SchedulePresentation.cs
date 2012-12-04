using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SScheduler
{
    public partial class SchedulePresentation : Form
    {
        public SchedulePresentation()
        {
            InitializeComponent();
        }

        List<RadioButton> rButtons;            
        private void SchedulePresentation_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.Name = "checkCol";
            check.HeaderText = "Zaznacz";
            check.IndeterminateValue = false;
            check.ReadOnly = false;
            DG_elements.Columns.Add(check); 

            rButtons = new List<RadioButton>(){
                RB_klasa,
                RB_nauczyciel,
                RB_sala
                };
             this.WindowState = FormWindowState.Maximized;
             TB_Path.Text = Directory.GetCurrentDirectory();
             
        }

        RadioButton checkedRB;
        string template;
        List<object> contextLocal;
        private void rButtons_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = rButtons.Where(rb => rb.Checked == true).First();

            IQueryable<object> context;
            
            var dcdc = new DataClassesDataContext(Form1.connectionString);
            if (checkedRB == RB_klasa)
            {
                context = from element in dcdc.klasas
                          select element;
                contextLocal = new List<object>(context);
                template = SScheduler.Properties.Resources.tabela_klasy;
            }
            else
                if (checkedRB == RB_nauczyciel)
                {
                    context = from element in dcdc.nauczyciels
                              select element;
                    contextLocal = new List<object>(context);
                    template = SScheduler.Properties.Resources.tabela_nauczyciel;
                }
                else
                    if (checkedRB == RB_sala)
                    {
                        context = from element in dcdc.salas
                                  select element;
                        contextLocal = new List<object>(context);
                        template = SScheduler.Properties.Resources.tabela_sala;
                    }
                    else context = null;

            DG_elements.DataSource = context;


            foreach (var col in DG_elements.Columns)
                if (((DataGridViewColumn)col).Name == "checkCol")
                    continue;
                else
                    ((DataGridViewColumn)col).ReadOnly = true;

            webBrowser1.SendToBack();
        }

        List<DataGridViewRow> checkedRows;
        private void BT_utworzPlan_Click(object sender, EventArgs e)
        {
            checkedRows = new List<DataGridViewRow>();
            for (int i = 0; i < DG_elements.Rows.Count; i++)
            {
                if (Convert.ToBoolean(DG_elements.Rows[i].Cells["checkCol"].Value) == true)
                {
                    checkedRows.Add(DG_elements.Rows[i]);
                }
            }

            if (checkedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz konkretną salę/nauczyciela/klasę aby utorzyć wizualizację planu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // tu wypełnij odpowiednio szablon

            webBrowser1.DocumentText = template;            
            DG_elements.SendToBack();

            checkedRows.ForEach(row =>
            {
                var item = GetScheduleName(fromRowToEntity(row));
                if (!LBox_generatedSchedules.Items.Contains(item))
                    LBox_generatedSchedules.Items.Add(item);
            });

        }

        private string GetScheduleName(object row)
        {       
            StringBuilder SB_name = new StringBuilder();
            if (checkedRB == RB_nauczyciel)
                SB_name.Append(RB_nauczyciel.Text + "_" + ((nauczyciel)row).nazwisko.Trim() + "_" + ((nauczyciel)row).imie);
            else
                if (checkedRB == RB_klasa)
                    SB_name.Append(RB_klasa.Text + "_" + ((klasa)row).rok + ((klasa)row).identyfikator);
                else
                    if (checkedRB == RB_sala)
                        SB_name.Append(RB_sala.Text + "_" + ((sala)row).numer);

            return SB_name.ToString();
        }

        private object fromRowToEntity(DataGridViewRow row)
        {

            StringBuilder SB_name = new StringBuilder();
            if (checkedRB == RB_nauczyciel)
            {                
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell.GetType() == typeof(DataGridViewTextBoxCell))
                        if(cell.ValueType == typeof(System.Guid))
                            return contextLocal.Where(obj => ((nauczyciel)obj).id_nauczyciel == (Guid)cell.Value).First();   // OPTIMIZATION FFS !!!
            }
            else
                if (checkedRB == RB_klasa)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        if (cell.GetType() == typeof(DataGridViewTextBoxCell))
                            if (cell.ValueType == typeof(System.Guid))
                                return contextLocal.Where(obj => ((klasa)obj).id_klasa == (Guid)cell.Value).First();   // OPTIMIZATION FFS !!!
                }
                else
                    if (checkedRB == RB_sala)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                            if (cell.GetType() == typeof(DataGridViewTextBoxCell))
                                if (cell.ValueType == typeof(System.Guid))
                                    return contextLocal.Where(obj => ((sala)obj).id_sala == (Guid)cell.Value).First();   // OPTIMIZATION FFS !!!
                    }
            throw new InvalidOperationException();
        }

        private void BT_ChangePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                TB_Path.Text = folderBrowserDialog1.SelectedPath;
        }

    }
}
