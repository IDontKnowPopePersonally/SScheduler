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
    public partial class GenerateSchedule : Form
    {
        private Form1 parent { get; set; }
        public GenerateSchedule()
        {
            InitializeComponent();
        }
        public GenerateSchedule(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void GenerateSchedule_Load(object sender, EventArgs e)
        {                   
        }
       
        public void BT_AbortGenerating_Click(object sender, EventArgs e)
        {
            if (parent != null)
            {
                parent.BW_generateSchedule.CancelAsync();
                this.Dispose();
            }
        }

        private void GenerateSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            BT_AbortGenerating_Click(sender,e);
        }
    }
}
