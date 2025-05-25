namespace TinyPOS
{
    partial class Sale
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
            this.components = new System.ComponentModel.Container();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.lstCart = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnUpCount = new System.Windows.Forms.Button();
            this.btnDownCount = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbCash = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Scheduler = new System.Windows.Forms.Timer(this.components);
            this.lbProduct = new System.Windows.Forms.Label();
            this.cbOtherProduct = new System.Windows.Forms.ComboBox();
            this.btnAddWeight = new System.Windows.Forms.Button();
            this.btnAddOther = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(355, 236);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(10);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(200, 27);
            this.tbBarcode.TabIndex = 1;
            this.tbBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBarcode_KeyPress);
            // 
            // lstCart
            // 
            this.lstCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCart.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstCart.FullRowSelect = true;
            this.lstCart.HideSelection = false;
            this.lstCart.Location = new System.Drawing.Point(60, 192);
            this.lstCart.Margin = new System.Windows.Forms.Padding(20);
            this.lstCart.MultiSelect = false;
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(1320, 456);
            this.lstCart.TabIndex = 6;
            this.lstCart.UseCompatibleStateImageBehavior = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(60, 830);
            this.btnBack.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 45);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSale.Location = new System.Drawing.Point(1260, 830);
            this.btnSale.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(120, 45);
            this.btnSale.TabIndex = 14;
            this.btnSale.Text = "Satış İşlemi";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnUpCount
            // 
            this.btnUpCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpCount.Location = new System.Drawing.Point(1120, 673);
            this.btnUpCount.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnUpCount.Name = "btnUpCount";
            this.btnUpCount.Size = new System.Drawing.Size(120, 45);
            this.btnUpCount.TabIndex = 33;
            this.btnUpCount.Text = "Adet Ekle";
            this.btnUpCount.UseVisualStyleBackColor = true;
            this.btnUpCount.Click += new System.EventHandler(this.btnUpCount_Click);
            // 
            // btnDownCount
            // 
            this.btnDownCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDownCount.Location = new System.Drawing.Point(1260, 673);
            this.btnDownCount.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnDownCount.Name = "btnDownCount";
            this.btnDownCount.Size = new System.Drawing.Size(120, 45);
            this.btnDownCount.TabIndex = 34;
            this.btnDownCount.Text = "Adet Çıkar";
            this.btnDownCount.UseVisualStyleBackColor = true;
            this.btnDownCount.Click += new System.EventHandler(this.btnDownCount_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(980, 673);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 45);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "Listeden Kaldır";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbCash
            // 
            this.lbCash.AutoSize = true;
            this.lbCash.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCash.Location = new System.Drawing.Point(56, 684);
            this.lbCash.Name = "lbCash";
            this.lbCash.Size = new System.Drawing.Size(156, 21);
            this.lbCash.TabIndex = 38;
            this.lbCash.Text = "Ödenecek Tutar: 0 ₺";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1304, 45);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ürün Satış İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Scheduler
            // 
            this.Scheduler.Interval = 2000;
            this.Scheduler.Tick += new System.EventHandler(this.Scheduler_Tick);
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(917, 142);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(180, 20);
            this.lbProduct.TabIndex = 56;
            this.lbProduct.Text = "Barkodsuz Ürün Ekleme :";
            // 
            // cbOtherProduct
            // 
            this.cbOtherProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOtherProduct.Location = new System.Drawing.Point(1110, 139);
            this.cbOtherProduct.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbOtherProduct.Name = "cbOtherProduct";
            this.cbOtherProduct.Size = new System.Drawing.Size(190, 28);
            this.cbOtherProduct.TabIndex = 55;
            this.cbOtherProduct.DropDown += new System.EventHandler(this.cbOtherProduct_DropDown);
            this.cbOtherProduct.DropDownClosed += new System.EventHandler(this.cbOtherProduct_DropDownClosed);
            // 
            // btnAddWeight
            // 
            this.btnAddWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddWeight.Location = new System.Drawing.Point(840, 673);
            this.btnAddWeight.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnAddWeight.Name = "btnAddWeight";
            this.btnAddWeight.Size = new System.Drawing.Size(120, 45);
            this.btnAddWeight.TabIndex = 59;
            this.btnAddWeight.Text = "Tartım";
            this.btnAddWeight.UseVisualStyleBackColor = true;
            this.btnAddWeight.Click += new System.EventHandler(this.btnAddWeight_Click);
            // 
            // btnAddOther
            // 
            this.btnAddOther.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddOther.Location = new System.Drawing.Point(1310, 139);
            this.btnAddOther.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnAddOther.Name = "btnAddOther";
            this.btnAddOther.Size = new System.Drawing.Size(70, 28);
            this.btnAddOther.TabIndex = 60;
            this.btnAddOther.Text = "Ekle";
            this.btnAddOther.UseVisualStyleBackColor = true;
            this.btnAddOther.Click += new System.EventHandler(this.btnAddOther_Click);
            // 
            // Sale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.btnAddOther);
            this.Controls.Add(this.btnAddWeight);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.cbOtherProduct);
            this.Controls.Add(this.lbCash);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDownCount);
            this.Controls.Add(this.btnUpCount);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Sale";
            this.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.ListView lstCart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnUpCount;
        private System.Windows.Forms.Button btnDownCount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lbCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Scheduler;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.ComboBox cbOtherProduct;
        private System.Windows.Forms.Button btnAddWeight;
        private System.Windows.Forms.Button btnAddOther;
    }
}

