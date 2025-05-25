namespace TinyPOS
{
    partial class Product
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
            this.lblBarcode = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.tbPurchase = new System.Windows.Forms.TextBox();
            this.lblSell = new System.Windows.Forms.Label();
            this.tbSell = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbProduct = new System.Windows.Forms.RadioButton();
            this.rbProductOther = new System.Windows.Forms.RadioButton();
            this.rbProductWeight = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.Location = new System.Drawing.Point(42, 96);
            this.lblBarcode.Margin = new System.Windows.Forms.Padding(8);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(66, 20);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "Barkod :";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbBarcode.Location = new System.Drawing.Point(139, 95);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(10);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(285, 27);
            this.tbBarcode.TabIndex = 0;
            this.tbBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBarcode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı :";
            // 
            // tbProduct
            // 
            this.tbProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbProduct.Location = new System.Drawing.Point(139, 138);
            this.tbProduct.Margin = new System.Windows.Forms.Padding(10);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(285, 27);
            this.tbProduct.TabIndex = 1;
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPurchase.Location = new System.Drawing.Point(503, 96);
            this.lblPurchase.Margin = new System.Windows.Forms.Padding(8);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(82, 20);
            this.lblPurchase.TabIndex = 4;
            this.lblPurchase.Text = "Alış Fiyatı :";
            // 
            // tbPurchase
            // 
            this.tbPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbPurchase.Location = new System.Drawing.Point(603, 95);
            this.tbPurchase.Margin = new System.Windows.Forms.Padding(10);
            this.tbPurchase.Name = "tbPurchase";
            this.tbPurchase.Size = new System.Drawing.Size(285, 27);
            this.tbPurchase.TabIndex = 2;
            this.tbPurchase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPurchase_KeyPress);
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSell.Location = new System.Drawing.Point(503, 141);
            this.lblSell.Margin = new System.Windows.Forms.Padding(8);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(89, 20);
            this.lblSell.TabIndex = 7;
            this.lblSell.Text = "Satış Fiyatı :";
            // 
            // tbSell
            // 
            this.tbSell.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbSell.Location = new System.Drawing.Point(603, 140);
            this.tbSell.Margin = new System.Windows.Forms.Padding(10);
            this.tbSell.Name = "tbSell";
            this.tbSell.Size = new System.Drawing.Size(285, 27);
            this.tbSell.TabIndex = 3;
            this.tbSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSell_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(1275, 825);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kayıt";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(46, 825);
            this.btnBack.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 45);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Listeleme Türü:";
            // 
            // lstProducts
            // 
            this.lstProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstProducts.FullRowSelect = true;
            this.lstProducts.HideSelection = false;
            this.lstProducts.Location = new System.Drawing.Point(45, 203);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(20);
            this.lstProducts.MultiSelect = false;
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(1350, 597);
            this.lstProducts.TabIndex = 10;
            this.lstProducts.UseCompatibleStateImageBehavior = false;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(1135, 825);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 45);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbType.Location = new System.Drawing.Point(1110, 96);
            this.tbType.Margin = new System.Windows.Forms.Padding(10);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(285, 27);
            this.tbType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1005, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Ürün Türü :";
            // 
            // rbProduct
            // 
            this.rbProduct.AutoSize = true;
            this.rbProduct.Location = new System.Drawing.Point(171, 31);
            this.rbProduct.Margin = new System.Windows.Forms.Padding(10);
            this.rbProduct.Name = "rbProduct";
            this.rbProduct.Size = new System.Drawing.Size(80, 24);
            this.rbProduct.TabIndex = 7;
            this.rbProduct.TabStop = true;
            this.rbProduct.Tag = "Product";
            this.rbProduct.Text = "Ürünler";
            this.rbProduct.UseVisualStyleBackColor = true;
            this.rbProduct.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbProductOther
            // 
            this.rbProductOther.AutoSize = true;
            this.rbProductOther.Location = new System.Drawing.Point(271, 31);
            this.rbProductOther.Margin = new System.Windows.Forms.Padding(10);
            this.rbProductOther.Name = "rbProductOther";
            this.rbProductOther.Size = new System.Drawing.Size(155, 24);
            this.rbProductOther.TabIndex = 8;
            this.rbProductOther.TabStop = true;
            this.rbProductOther.Tag = "ProductOther";
            this.rbProductOther.Text = "Barkodsuz Ürünler";
            this.rbProductOther.UseVisualStyleBackColor = true;
            this.rbProductOther.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbProductWeight
            // 
            this.rbProductWeight.AutoSize = true;
            this.rbProductWeight.Location = new System.Drawing.Point(446, 31);
            this.rbProductWeight.Margin = new System.Windows.Forms.Padding(10);
            this.rbProductWeight.Name = "rbProductWeight";
            this.rbProductWeight.Size = new System.Drawing.Size(135, 24);
            this.rbProductWeight.TabIndex = 9;
            this.rbProductWeight.TabStop = true;
            this.rbProductWeight.Tag = "ProductWeight";
            this.rbProductWeight.Text = "Tartımlı Ürünler";
            this.rbProductWeight.UseVisualStyleBackColor = true;
            this.rbProductWeight.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.rbProductWeight);
            this.Controls.Add(this.rbProductOther);
            this.Controls.Add(this.rbProduct);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.tbPurchase);
            this.Controls.Add(this.tbSell);
            this.Controls.Add(this.lblSell);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Product";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Product_Load);
            this.Shown += new System.EventHandler(this.Product_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.TextBox tbPurchase;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.TextBox tbSell;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstProducts;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbProduct;
        private System.Windows.Forms.RadioButton rbProductOther;
        private System.Windows.Forms.RadioButton rbProductWeight;
    }
}

