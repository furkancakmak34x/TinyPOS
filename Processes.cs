using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using static TinyPOS.Processes;
using System.Diagnostics.Eventing.Reader;
using System.Data.Common;
using System.Collections;
using System.Text.RegularExpressions;

namespace TinyPOS
{
    public class Processes
    {
        public static string constr = @"Data Source=|DataDirectory|\Database.db;";
        public static void RefreshListView(ListView lst, string type)
        {
            lst.Items.Clear();
            lst.Columns.Clear();
            lst.View = View.Details;

            if (type == "Sale")
            {
                lst.Columns.Add("Ürün Adı", 500);
                lst.Columns.Add("Satış Fiyatı", 200);
                lst.Columns.Add("Adet", 60);
                lst.Columns.Add("Toplam Tutar", 200);
            }

            else if (type == "Receivables")
            {
                lst.Columns.Add("Id", 0);
                lst.Columns.Add("Müşteri Adı", 300);
                lst.Columns.Add("Borç Tutarı", 235);
                lst.Columns.Add("Tarih", 300);
            }

            else if (type == "Report")
            {
                lst.Columns.Add("Id", 0);
                lst.Columns.Add("Satılan Ürün", 300);
                lst.Columns.Add("Satış Adeti", 150);
                lst.Columns.Add("Toplam Tutar", 150);
                lst.Columns.Add("Tarih", 150);
            }

            else if (type == "Product")
            {
                lst.Columns.Add("Id", 0);
                lst.Columns.Add("Barkod", 150);
                lst.Columns.Add("Ürün Adı", 500);
                lst.Columns.Add("Alış Fiyatı", 100);
                lst.Columns.Add("Satış Fiyatı", 100);
                lst.Columns.Add("Ürün Türü", 150);
            }

            else if (type == "ProductOther")
            {
                lst.Columns.Add("Id", 0);
                lst.Columns.Add("Ürün Adı", 500);
                lst.Columns.Add("Alış Fiyatı", 100);
                lst.Columns.Add("Satış Fiyatı", 100);
                lst.Columns.Add("Ürün Türü", 150);
            }

            else if (type == "ProductWeight")
            {
                lst.Columns.Add("Id", 0);
                lst.Columns.Add("Ürün Adı", 500);
                lst.Columns.Add("Alış Fiyatı", 100);
                lst.Columns.Add("Satış Fiyatı", 100);
                lst.Columns.Add("Ürün Türü", 150);
            }
        }
        public static bool CheckQuery(string table, string column, string value)
        {

            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new SQLiteCommand($"SELECT COUNT(*) FROM {table} WHERE {column} = @{column};", conn))
                    {
                        cmd.Parameters.AddWithValue($"@{column}", value);

                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                        {
                            return false;
                        }

                        else
                        {
                            return true;
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                finally
                {
                    conn.Close();
                }
            }
        }

        public static void InsertCustomer(ListView lst, string customer, decimal total, string date, string proc)
        {
            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();

                    string cartItems = string.Join(" ", lst.Items.Cast<ListViewItem>()
                        .Select(item => $"{item.SubItems[0].Text} ({item.SubItems[2].Text} Adet - {item.SubItems[3].Text} ₺)"));

                    string cart = $"[{date}]" + " " + $"#{total}#" + " " + cartItems;

                    string queryUpdate = CheckQuery("Receivables", "Customer", customer)
                        ? "INSERT INTO Receivables (Customer, Total, Date, Cart) VALUES (@customer, @total, @date, @cart)"
                        : "UPDATE Receivables SET Total = Total + @total, Date = @date, Cart = Cart || @cart WHERE Customer = @customer";

                    string queryInsert = CheckQuery("Receivables", "Customer", customer)
                        ? "INSERT INTO Receivables (Customer, Total, Date, Cart) VALUES (@customer, @total, @date, @cart)"
                        : "UPDATE Receivables SET Total = @total, Date = @date WHERE Customer = @customer";

                    if (proc == "Update")
                    {
                        using (var cmd = new SQLiteCommand(queryUpdate, conn))
                        {
                            cmd.Parameters.AddWithValue("@customer", customer);
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@cart", cart);
                            cmd.ExecuteNonQuery();
                        }

                        string msg = queryUpdate.StartsWith("INSERT")

                        ? "Kayıt işlemi başarılı. Borç eklendi."
                        : "Kayıt işlemi başarılı. Borç güncellendi.";

                        MessageBox.Show(msg, "İşlem Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        using (var cmd = new SQLiteCommand(queryInsert, conn))
                        {
                            cmd.Parameters.AddWithValue("@customer", customer);
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@cart", cart);
                            cmd.ExecuteNonQuery();
                        }

                        string msg = queryInsert.StartsWith("INSERT")

                        ? "Kayıt işlemi başarılı. Borç eklendi."
                        : "Kayıt işlemi başarılı. Borç güncellendi.";

                        MessageBox.Show(msg, "İşlem Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                }
             
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void CustomerCart(ListBox lstbox, ListView lst)
        {
            lstbox.Items.Clear();
            ListViewItem item = lst.SelectedItems[0];
            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("SELECT Cart FROM Receivables WHERE Customer = @customer", conn))
                    {
                        cmd.Parameters.AddWithValue("@customer", item.SubItems[1].Text);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            lstbox.Items.Clear();
                            while (reader.Read())
                            {
                                string cart = reader["Cart"].ToString().Trim();

                                var matches = Regex.Matches(cart, @"\[(\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2})\]\s*#([\d.,]+)#\s*([^\[]+)")
                                    .Cast<Match>();

                                foreach (var match in matches)
                                {
                                    string dateRaw = match.Groups[1].Value.Trim();
                                    string amountRaw = match.Groups[2].Value.Trim();
                                    decimal amount = decimal.Parse(amountRaw, new CultureInfo("tr-TR"));
                                    string cartStr = match.Groups[3].Value.Trim();

                                    DateTime dt = DateTime.ParseExact(dateRaw, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                                    string date = dt.ToString("dd MMMM yyyy HH:mm", new CultureInfo("tr-TR"));

                                    lstbox.Items.Add($"Tarih: {date}");
                                    lstbox.Items.Add($"Tutar: {amount} TL");

                                    var cartItems = Regex.Matches(cartStr, @"(.+?\(\d+ Adet - [\d.,]+ ₺\))")
                                        .Cast<Match>()
                                        .Select(m => m.Value.Trim());

                                    foreach (var product in cartItems)
                                        lstbox.Items.Add(product);

                                    lstbox.Items.Add("");
                                }
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
                }
            }
        }
        public static void SearchQuery(string table, string column, string value, Action<SQLiteDataReader> onItemFound)
        {
            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM {table} WHERE {column} = @{column}";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue($"@{column}", value);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                onItemFound(reader);
                            }
                            else
                            {
                                MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
            }
        }
        public static void ProductSearch(ListView lst, string barcode)
        {
            SearchQuery("Product", "Barcode", barcode, reader =>
            {
                string name = reader["Product"].ToString();
                decimal price = Convert.ToDecimal(reader["Sell"]);
                int count = 1;
                decimal total = price;

                foreach (ListViewItem item in lst.Items)
                {
                    if (item.Text == name)
                    {
                        decimal newPrice = decimal.Parse(item.SubItems[1].Text);
                        int newCount = int.Parse(item.SubItems[2].Text);
                        total = total + (newPrice * newCount);
                        item.SubItems[2].Text = (newCount + 1).ToString();
                        item.SubItems[3].Text = (total.ToString("0.##", new CultureInfo("tr-TR")));
                        return;
                    }
                }

                var listItem = new ListViewItem(name);
                listItem.SubItems.Add(price.ToString("0.##", new CultureInfo("tr-TR")));
                listItem.SubItems.Add(count.ToString());
                listItem.SubItems.Add(total.ToString("0.##", new CultureInfo("tr-TR")));
                lst.Items.Add(listItem);

            });
        }
        public static void ComboBoxFilter(ComboBox cb, string table)
        {
            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand($"SELECT Product FROM {table} ORDER BY Product ASC", conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cb.Items.Add(reader["Product"].ToString());
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
                }
            }
        }
        public static void InsertOrUpdateProduct(string table, string barcode, string product, decimal purchase, decimal sell, string type)
        {
            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();

                    string productQuery = CheckQuery("Product", "Barcode", barcode)
                        ? "INSERT INTO Product (Barcode, Product, Purchase, Sell, Type) VALUES (@barcode, @product, @purchase, @sell, @type)"
                        : "UPDATE Product SET Barcode = @barcode, Product = @product, Purchase = @purchase, Sell = @sell, Type = @type WHERE Barcode = @barcode";


                    string productOtherQuery = CheckQuery("ProductOther", "Product", product)
                        ? "INSERT INTO ProductOther (Product, Purchase, Sell, Type) VALUES (@product, @purchase, @sell, @type)"
                        : "UPDATE ProductOther SET Product = @product, Purchase = @purchase, Sell = @sell, Type = @type WHERE Product = @product";


                    string productWeightQuery = CheckQuery("ProductWeight", "Product", product)
                        ? "INSERT INTO ProductWeight (Product, Purchase, Sell, Type) VALUES (@product, @purchase, @sell, @type)"
                        : "UPDATE ProductWeight SET Product = @product, Purchase = @purchase, Sell = @sell, Type = @type WHERE Product = @product";



                    if (table == "Product")
                    {
                        using (var cmd = new SQLiteCommand(productQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@barcode", barcode);
                            cmd.Parameters.AddWithValue("@product", product);
                            cmd.Parameters.AddWithValue("@purchase", purchase);
                            cmd.Parameters.AddWithValue("@sell", sell);
                            cmd.Parameters.AddWithValue("@type", type);
                            cmd.ExecuteNonQuery();
                        }

                        string msg = productQuery.StartsWith("INSERT")

                            ? "Ürün ekleme işlemi başarılı."
                            : "Ürün güncelleme işlemi başarılı.";


                        MessageBox.Show(msg, "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (table == "ProductOther")
                    {
                        using (var cmd = new SQLiteCommand(productOtherQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@product", product);
                            cmd.Parameters.AddWithValue("@purchase", purchase);
                            cmd.Parameters.AddWithValue("@sell", sell);
                            cmd.Parameters.AddWithValue("@type", type);
                            cmd.ExecuteNonQuery();
                        }

                        string msg = productOtherQuery.StartsWith("INSERT")
                            ? "Ürün ekleme işlemi başarılı."
                            : "Ürün güncelleme işlemi başarılı.";

                        MessageBox.Show(msg, "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (table == "ProductWeight")
                    {
                        using (var cmd = new SQLiteCommand(productWeightQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@product", product);
                            cmd.Parameters.AddWithValue("@purchase", purchase);
                            cmd.Parameters.AddWithValue("@sell", sell);
                            cmd.Parameters.AddWithValue("@type", type);
                            cmd.ExecuteNonQuery();
                        }

                        string msg = productWeightQuery.StartsWith("INSERT")
                            ? "Ürün ekleme işlemi başarılı."
                            : "Ürün güncelleme işlemi başarılı.";

                        MessageBox.Show(msg, "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void DeleteProduct(string table, string value)
        {
            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();

                    if (table == "Product")
                    {
                        using (var cmd = new SQLiteCommand("DELETE FROM Product WHERE Barcode = @value", conn))
                        {
                            cmd.Parameters.AddWithValue("@value", value);
                            cmd.ExecuteNonQuery();
                        }

                    }

                    else if (table == "ProductOther")
                    {
                        using (var cmd = new SQLiteCommand("DELETE FROM ProductOther WHERE Product = @value", conn))
                        {
                            cmd.Parameters.AddWithValue("@value", value);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    else if (table == "ProductWeight")
                    {
                        using (var cmd = new SQLiteCommand("DELETE FROM ProductWeight WHERE Product = @value", conn))
                        {
                            cmd.Parameters.AddWithValue("@value", value);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Kayıt silme işlemi başarılı.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void AddOtherProducts(ListView lst, Label lb, string table, string product)
        {
            using (var conn = new SQLiteConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand($"SELECT * FROM {table} WHERE Product = @product", conn))
                    {
                        cmd.Parameters.AddWithValue("@product", product);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["Product"].ToString();
                                decimal price = Convert.ToDecimal(reader["Sell"]);
                                int count = 1;
                                decimal total = price;

                                foreach (ListViewItem item in lst.Items)
                                {
                                    if (item.Text == name)
                                    {
                                        decimal newPrice = decimal.Parse(item.SubItems[2].Text, NumberStyles.Currency);
                                        int newCount = int.Parse(item.SubItems[3].Text);
                                        total = total + (newPrice * newCount);
                                        item.SubItems[2].Text = (newCount + 1).ToString();
                                        item.SubItems[3].Text = total.ToString("0.##", new CultureInfo("tr-TR"));
                                        return;
                                    }
                                }

                                var listItem = new ListViewItem(name);
                                listItem.SubItems.Add(price.ToString("0.##", new CultureInfo("tr-TR")));
                                listItem.SubItems.Add(count.ToString());
                                listItem.SubItems.Add(total.ToString("0.##", new CultureInfo("tr-TR")));
                                lst.Items.Add(listItem);
                            }

                            else
                            {
                                MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
            }
        }
    }
}
