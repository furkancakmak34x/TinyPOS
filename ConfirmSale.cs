using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TinyPOS.Processes;

namespace TinyPOS
{
    public partial class ConfirmSale : Form
    {
        public string customerName { get; set; }
        public decimal customerFee { get; set; }
        public bool status { get; set; }
        public decimal total { get; set; }
        public ConfirmSale(decimal cash)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.tinypos_ico;
            total = cash;
            lbCash.Text = "Ödenecek Tutar: " + cash.ToString() + " ₺";
        }

        private void rbPaid_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Size = new Size(338, 72);
        }

        private void tbNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Size = new Size(338, 155);
            tbCash.Text = total.ToString();
        }

        private void ConfirmSale_Load(object sender, EventArgs e)
        {
            tbName.Enabled = false;
            tbName.Hide();
            rbPaid.Checked = true;

            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand($"SELECT Customer FROM Receivables ORDER BY Customer ASC", conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbName.Items.Add(reader["Customer"].ToString());
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                    cbName.Items.Add("**Yeni Kayıt**");
                }
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (rbPaid.Checked)
            {
                status = true;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }

            else if (rbNotPaid.Checked)
            {
                if (cbName.Enabled)
                {
                    if (!string.IsNullOrWhiteSpace(cbName.Text) && !string.IsNullOrWhiteSpace(tbCash.Text))
                    {
                        status = false;
                        customerName = cbName.Text;
                        customerFee = Convert.ToDecimal(tbCash.Text);

                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                else
                {
                    if (!string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbCash.Text))
                    {
                        status = false;
                        customerName = tbName.Text;
                        customerFee = Convert.ToDecimal(tbCash.Text);

                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void tbCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbName.SelectedItem.ToString() == "**Yeni Kayıt**")
            {
                tbName.Enabled = true;
                tbName.Show();
                cbName.Enabled = false;
                cbName.Hide();
            }
        }
    }
}
