namespace TinyPOS
{
    partial class Main
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
            this.btnSale = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnReceivables = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(50, 471);
            this.btnSale.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(120, 45);
            this.btnSale.TabIndex = 0;
            this.btnSale.Text = "Satış";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(190, 471);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(120, 45);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Ürün Listesi";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnReceivables
            // 
            this.btnReceivables.Location = new System.Drawing.Point(330, 471);
            this.btnReceivables.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnReceivables.Name = "btnReceivables";
            this.btnReceivables.Size = new System.Drawing.Size(124, 45);
            this.btnReceivables.TabIndex = 3;
            this.btnReceivables.Text = "Tahsilat Kayıtları";
            this.btnReceivables.UseVisualStyleBackColor = true;
            this.btnReceivables.Click += new System.EventHandler(this.btnReceivables_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(474, 471);
            this.btnReport.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(120, 45);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Satış Raporu";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(614, 471);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(120, 45);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TinyPOS.Properties.Resources.tinypos;
            this.pictureBox1.Location = new System.Drawing.Point(190, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnReceivables);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnSale);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(40, 30, 40, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TinyPOS - Esnaf Satış Otomasyonu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnReceivables;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

