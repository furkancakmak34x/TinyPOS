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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TinyPOS.Processes;

namespace TinyPOS
{
    public partial class Report : Form
    {
        DateTime selectedDate = DateTime.Today;
        DateTime minDate;
        DateTime maxDate;
        public Report()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.tinypos_ico;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal UpdateCash()
        {
            decimal toplam = 0;
            CultureInfo culture = new CultureInfo("tr-TR");

            foreach (ListViewItem item in lstReport.Items)
            {
                if (decimal.TryParse(item.SubItems[3].Text, NumberStyles.Any, culture, out decimal deger))
                {
                    toplam += deger;
                }
            }
            return toplam;
        }

        private void LoadReport()
        {
            lstReport.Items.Clear();

            using (var conn = new SQLiteConnection(constr))
            {
                conn.Open();

                using (var cmd = new SQLiteCommand($"SELECT * FROM Report WHERE Date BETWEEN @start AND @end ORDER BY Date DESC", conn))
                {
                    DateTime start = selectedDate.Date;
                    DateTime end = selectedDate.Date.AddDays(1).AddSeconds(-1);

                    cmd.Parameters.AddWithValue("@start", start.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@end", end.ToString("yyyy-MM-dd HH:mm:ss"));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["Id"].ToString());
                            item.SubItems.Add(reader["Product"].ToString());
                            item.SubItems.Add(reader["Count"].ToString());
                            item.SubItems.Add(reader["Price"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["Date"]).ToString("dd MMMM yyyy HH:mm", new CultureInfo("tr-TR")));
                            lstReport.Items.Add(item);
                        }
                    }
                }
            }
            button1.Enabled = selectedDate > minDate;
            button2.Enabled = selectedDate < maxDate;
            lblTotal.Text = "Toplam Tutar: " + UpdateCash().ToString() + " ₺";
        }


        private void Report_Load(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(constr))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT MIN(Date), MAX(Date) FROM Report", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        minDate = Convert.ToDateTime(reader[0]).Date;
                        maxDate = Convert.ToDateTime(reader[1]).Date;
                    }
                }
            }
            selectedDate = maxDate;
            RefreshListView(lstReport, "Report");
            LoadReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedDate > minDate)
            {
                selectedDate = selectedDate.AddDays(-1);
                LoadReport();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedDate < maxDate)
            {
                selectedDate = selectedDate.AddDays(1);
                LoadReport();
            }
        }
    }
}