using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TinyPOS.Processes;

namespace TinyPOS
{
    public partial class ProductWeight : Form
    {
        public string name { get; set; }
        public decimal weight { get; set; }
        public decimal price { get; set; }
        public decimal total { get; set; }

        public ProductWeight()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.tinypos_ico;
        }

        private void ProductWeight_Load(object sender, EventArgs e)
        {
            ComboBoxFilter(cbProduct, "ProductWeight");

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.BackColor = SystemColors.Window;
                    tb.TabStop = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem == null)
            {
                return;
            }

            name = cbProduct.SelectedItem.ToString();
            weight = Convert.ToDecimal(tbWeight.Text);
            price = Convert.ToDecimal(tbPrice.Text);
            total = Convert.ToDecimal(tbTotal.Text);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void cbProduct_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string product = cbProduct.SelectedItem.ToString();

            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("SELECT Sell From ProductWeight WHERE Product = @product", conn))
                    {
                        cmd.Parameters.AddWithValue("@product", product);
                        tbPrice.Text = cmd.ExecuteScalar().ToString();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                }
            }
        } 

        private void tbWeight_TextChanged(object sender, EventArgs e)
        {
            decimal a, b;

            if (decimal.TryParse(tbWeight.Text, out a) && decimal.TryParse(tbPrice.Text, out b))
            {
                decimal result = a * b;
                tbTotal.Text = result.ToString("F0");
            }
        }
    }
}
