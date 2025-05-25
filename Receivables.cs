using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static TinyPOS.Processes;

namespace TinyPOS
{
    public partial class Receivables : Form
    {
        public Receivables()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.tinypos_ico;
        }

        private void TotalReceivable()
        {
            decimal total = 0;

            foreach (ListViewItem item in lstReceivables.Items)
            {
                if (decimal.TryParse(item.SubItems[2].Text, out decimal value))
                {
                    total += value;
                }
            }

            lblTotal.Text = "Toplam Tutar: " + total + " ₺";
        }

        private void LoadReceivables()
        {
            lstReceivables.Items.Clear();
            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("SELECT * FROM Receivables ORDER BY Customer ASC", conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var listItem = new ListViewItem(Convert.ToInt32(reader["Id"]).ToString());
                                listItem.SubItems.Add(reader["Customer"].ToString());
                                listItem.SubItems.Add(reader["Total"].ToString());
                                listItem.SubItems.Add(Convert.ToDateTime(reader["Date"]).ToString("dd MMMM yyyy HH:mm", new CultureInfo("tr-TR")));
                                lstReceivables.Items.Add(listItem);
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
                    TotalReceivable();
                }
            }
        }

        private void Receivables_Load(object sender, EventArgs e)
        {
            RefreshListView(lstReceivables, "Receivables");
            LoadReceivables();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            InsertCustomer(lstReceivables, tbCustomer.Text, Convert.ToDecimal(tbFee.Text), date, "Insert");
            LoadReceivables();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("DELETE FROM Receivables WHERE Customer = @customer", conn))
                    {
                        cmd.Parameters.AddWithValue("@customer", tbCustomer.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt silme işlemi başarılı.", "Borç Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                finally
                {
                    conn.Close();
                }
            }

            RefreshListView(lstReceivables, "Receivables");
            LoadReceivables();
        }

        private void lstReceivables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReceivables.SelectedItems.Count > 0)
            {
                ListViewItem item = lstReceivables.SelectedItems[0];
                tbCustomer.Text = item.SubItems[1].Text;
                tbFee.Text = item.SubItems[2].Text;
                CustomerCart(lstCart, lstReceivables);
            }
        }

        private void tbFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
