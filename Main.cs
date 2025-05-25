using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyPOS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.tinypos_ico;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Form frm = new Sale();
            frm.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Form frm = new Product();
            frm.ShowDialog();
        }

        private void btnReceivables_Click(object sender, EventArgs e)
        {
            Form frm = new Receivables();
            frm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form frm = new Report();
            frm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
