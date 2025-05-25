using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TinyPOS.Processes;

namespace TinyPOS
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.tinypos_ico;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            rbProduct.Checked = true;
            RefreshListView(lstProducts, "Product");
            ListProducts("Product");
        }

        private void TextBoxClear()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox tb && tb.Enabled)
                    tb.Clear();
            }
        }

        private void TextBoxFill(string table)
        {
            TextBoxClear();
            if (lstProducts.SelectedItems.Count > 0)
            {
                var items = lstProducts.SelectedItems[0];

                if (table == "Product")
                {
                    tbBarcode.Text = items.SubItems[1].Text;
                    tbProduct.Text = items.SubItems[2].Text;
                    tbPurchase.Text = items.SubItems[3].Text;
                    tbSell.Text = items.SubItems[4].Text;
                    tbType.Text = items.SubItems[5].Text;
                }

                else
                {
                    tbProduct.Text = items.SubItems[1].Text;
                    tbPurchase.Text = items.SubItems[2].Text;
                    tbSell.Text = items.SubItems[3].Text;
                    tbType.Text = items.SubItems[4].Text;
                }
            }
        }
        private void ListProducts(string table)
        {
            TextBoxClear();
            lstProducts.Items.Clear();

            List<ListViewItem> items = new List<ListViewItem>();

            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new SQLiteCommand($"SELECT * FROM {table}", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader[0].ToString());
                            for (int i = 1; i < reader.FieldCount; i++)
                            {
                                item.SubItems.Add(reader[i].ToString());
                            }
                            items.Add(item);
                        }
                    }

                    if (table == "Product")
                    {
                        items = items.OrderBy(x => x.SubItems[2].Text, StringComparer.Create(new CultureInfo("tr-TR"), false)).ToList();
                    }

                    else
                    {
                        items = items.OrderBy(x => x.SubItems[1].Text, StringComparer.Create(new CultureInfo("tr-TR"), false)).ToList();
                    }

                    lstProducts.Items.AddRange(items.ToArray());

                    if (lstProducts.Items.Count > 0)
                    {
                        lstProducts.Items[0].Selected = true;
                        lstProducts.Select();
                        TextBoxFill(table);
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

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbProduct.Checked)
            {
                TextBoxFill("Product");
            }

            else
            {
                TextBoxFill("Other");
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var checkedRb = this.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (checkedRb != null)
            {
                var tag = checkedRb.Tag?.ToString();
                InsertOrUpdateProduct(tag.ToString(),tbBarcode.Text,tbProduct.Text,Convert.ToDecimal(tbPurchase.Text),Convert.ToDecimal(tbSell.Text),tbType.Text);
                RefreshListView(lstProducts, tag.ToString());
                ListProducts(tag.ToString());
            }        
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?", "İşlem Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (question == DialogResult.Yes)
            {
                var checkedRb = this.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
                var tag = checkedRb.Tag?.ToString();

                if (checkedRb != null)
                {
                    if (rbProduct.Checked)
                    {
                        DeleteProduct(tag.ToString(), tbBarcode.Text);
                        RefreshListView(lstProducts, tag.ToString());
                        ListProducts(tag.ToString());
                    }

                    else
                    {
                        DeleteProduct(tag.ToString(), tbBarcode.Text);
                        RefreshListView(lstProducts, tag.ToString());
                        ListProducts(tag.ToString());
                    }

                }
            }

            else
            {
                return;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbPurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void tbSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void Product_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                RefreshListView(lstProducts, rb.Tag.ToString());
                ListProducts(rb.Tag.ToString());
            }

            if (rbProduct.Checked)
            {
                tbBarcode.Enabled = true; 
                tbBarcode.Show();
                lblBarcode.Show();
            }

            else
            {
                tbBarcode.Enabled = false;
                tbBarcode.Hide();
                lblBarcode.Hide();
            }
        }
    }
}
