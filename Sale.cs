using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using static TinyPOS.Processes;

namespace TinyPOS
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.tinypos_ico;
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            Scheduler.Start();
            RefreshListView(lstCart, "Sale");
            ComboBoxFilter(cbOtherProduct, "ProductOther");
        }

        public static decimal UpdateCash(ListView lst)
        {
            decimal total = 0;

            foreach (ListViewItem item in lst.Items)
            {
                decimal rowTotal = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                total += rowTotal;
            }
                
            return Math.Round(total, 2);
        }

        private void UpdateItemCount(bool increase)
        {
            if (lstCart.SelectedItems.Count > 0)
            {
                var item = lstCart.SelectedItems[0];
                decimal currentCount = decimal.Parse(item.SubItems[2].Text);

                if (increase && currentCount % 1 == 0)
                {
                    currentCount++;
                }
                else if (currentCount > 1 && currentCount % 1 == 0)
                {
                    currentCount--;
                }
                else
                {
                    return;
                }

                item.SubItems[2].Text = currentCount.ToString();
                decimal price = decimal.Parse(item.SubItems[1].Text, NumberStyles.Currency);
                item.SubItems[3].Text = (price * currentCount).ToString();

                lbCash.Text = "Ödenecek Tutar: " + UpdateCash(lstCart) + " ₺";
            }
        }

        private void tbBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string barcode = tbBarcode.Text.Trim();
                ProductSearch(lstCart, barcode);
                tbBarcode.Clear();
                lbCash.Text = "Ödenecek Tutar: " + UpdateCash(lstCart) + " ₺";
                e.Handled = true;
            }
        }

        private void btnUpCount_Click(object sender, EventArgs e)
        {
            UpdateItemCount(true);
        }

        private void btnDownCount_Click(object sender, EventArgs e)
        {
            UpdateItemCount(false);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedItems.Count == 0) return;

            else
            {
                var item = lstCart.SelectedItems[0];
                lstCart.Items.Remove(lstCart.SelectedItems[0]);
            }

            lbCash.Text = "Ödenecek Tutar: " + UpdateCash(lstCart) + " ₺";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Scheduler_Tick(object sender, EventArgs e)
        {
            if (!tbBarcode.Focused)
                tbBarcode.Focus();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (lstCart.Items.Count > 0)
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ConfirmSale frm = new ConfirmSale(UpdateCash(lstCart));
                DialogResult result = frm.ShowDialog();

                if (result != DialogResult.Yes) return;

                foreach (ListViewItem item in lstCart.Items)
                {
                    string product = item.SubItems[0].Text;
                    decimal count = Convert.ToDecimal(item.SubItems[2].Text);
                    decimal price = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                    InsertReport(product, count, price, date);
                }

                if (frm.status)
                {
                    MessageBox.Show("Satış işlemi başarılı.", "Ürün Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    InsertCustomer(lstCart, frm.customerName, frm.customerFee, date, "Update");
                }

                lstCart.Items.Clear();
                RefreshListView(lstCart, "Sale");
                lbCash.Text = "Ödenecek Tutar: " + UpdateCash(lstCart) + " ₺";
            }           
        }

        private void InsertReport(string product, decimal count, decimal price, string date)
        {
            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("INSERT INTO Report (Product,Count,Price,Date) VALUES (@product,@count,@price,@date)", conn))
                    {
                        cmd.Parameters.AddWithValue("@product", product);
                        cmd.Parameters.AddWithValue("@count", count);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddOther_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbOtherProduct.Text))
            {
                bool status = false;

                foreach (ListViewItem item in lstCart.Items)
                {
                    if (item.SubItems[0].Text == cbOtherProduct.SelectedItem.ToString())
                    {
                        status = true;
                        break;
                    }
                }

                if (status)
                {
                    return;
                }

                else
                {
                    AddOtherProducts(lstCart, lbCash, "ProductOther", cbOtherProduct.Text);
                }

                lbCash.Text = "Ödenecek Tutar: " + UpdateCash(lstCart) + " ₺";
            }

        }


        private void btnAddWeight_Click(object sender, EventArgs e)
        {
            ProductWeight frm = new ProductWeight();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                var listItem = new ListViewItem(frm.name);
                listItem.SubItems.Add(frm.price.ToString());
                listItem.SubItems.Add(frm.weight.ToString());
                listItem.SubItems.Add(frm.total.ToString());
                lstCart.Items.Add(listItem);
            }

            else
            {
                return;
            }

            lbCash.Text = "Ödenecek Tutar: " + UpdateCash(lstCart) + " ₺";
        }

        private void cbOtherProduct_DropDown(object sender, EventArgs e)
        {
            Scheduler.Stop();
        }

        private void cbOtherProduct_DropDownClosed(object sender, EventArgs e)
        {
            Scheduler.Start();
        }
    }
}
