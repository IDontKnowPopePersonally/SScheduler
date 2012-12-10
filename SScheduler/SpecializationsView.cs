using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SScheduler
{
    public partial class SpecializationsView : Form
    {
        public SpecializationsView()
        {
            InitializeComponent();
        }
        private Form1 MotherForm;
        public SpecializationsView(Form1 mother)
        {                        
            InitializeComponent();
            MotherForm = mother;
        }
        
        List<Guid> checkedSpecs;
        DataGridViewCheckBoxColumn check;
        private void SpecializationsView_Load(object sender, EventArgs e)
        {
            check = new DataGridViewCheckBoxColumn();
            check.Name = "checkCol";
            check.HeaderText = "Zaznacz";
            check.IndeterminateValue = false;
            check.ReadOnly = false;
            check.IndeterminateValue = false;            
            DG_specs.Columns.Add(check);

            DataClassesDataContext dcdc = new DataClassesDataContext();
            var dSource = (from spec in dcdc.przedmiots select spec);
            DG_specs.DataSource = dSource;

            foreach (DataGridViewColumn col in DG_specs.Columns)
                if (col.Equals(check))
                    continue;
                else col.ReadOnly = true;

            for (int i = 0; i < DG_specs.Rows.Count; i++)
                ((DataGridViewCheckBoxCell)DG_specs.Rows[i].Cells[check.Name]).Value = false;                                
        }
        private bool canBeClosed = false;
        private void BT_confirm_specs_Click(object sender, EventArgs e)
        {
            if (areSpecsChecked())
            {
                MotherForm.checkedSpecs = new List<Guid>(checkedSpecs);
                canBeClosed = true;
                this.Dispose();
            }    
            else
                MessageBox.Show("Nauczyciel musi być uprawniony do prowadzenia co najmniej jednego przedmiotu !", "Ogarnij się!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

        private bool areSpecsChecked()
        {
            checkedSpecs = new List<Guid>();

            for (int i = 0; i < DG_specs.Rows.Count; i++)
                if (Convert.ToBoolean(DG_specs.Rows[i].Cells[check.Name].Value) == true)
                    checkedSpecs.Add((Guid)DG_specs.Rows[i].Cells[1].Value);

            if (checkedSpecs.Count == 0)
                return false;
            else
                return true;            
        }

        private void SpecializationsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!canBeClosed)
            {
                MessageBox.Show("Zaznacz odpowiednie przedmioty a następnie wciśnij przycisk Zatwierdź!", "Ogarnij się!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Cancel = true;
            }
        }
    }
}
