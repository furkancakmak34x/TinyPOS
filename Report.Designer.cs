namespace TinyPOS
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.lstReport = new System.Windows.Forms.ListView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(50, 820);
            this.btnBack.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 45);
            this.btnBack.TabIndex = 101;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstReport
            // 
            this.lstReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstReport.FullRowSelect = true;
            this.lstReport.HideSelection = false;
            this.lstReport.Location = new System.Drawing.Point(50, 50);
            this.lstReport.Margin = new System.Windows.Forms.Padding(20);
            this.lstReport.MultiSelect = false;
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(1345, 745);
            this.lstReport.TabIndex = 111;
            this.lstReport.UseCompatibleStateImageBehavior = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(239, 832);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 20);
            this.lblTotal.TabIndex = 113;
            this.lblTotal.Text = "Toplam Tutar :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1135, 820);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 114;
            this.button1.Text = "Önceki Gün";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(1275, 820);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 115;
            this.button2.Text = "Sonraki Gün";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Report
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Report";
            this.Padding = new System.Windows.Forms.Padding(40, 30, 40, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Raporları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lstReport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

