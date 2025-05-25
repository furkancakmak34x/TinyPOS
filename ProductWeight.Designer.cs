namespace TinyPOS
{
    partial class ProductWeight
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
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lbProduct = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(161, 40);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(190, 25);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            this.cbProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProduct_KeyPress);
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(161, 85);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(190, 25);
            this.tbWeight.TabIndex = 1;
            this.tbWeight.TextChanged += new System.EventHandler(this.tbWeight_TextChanged);
            this.tbWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWeight_KeyPress);
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(30, 43);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(45, 17);
            this.lbProduct.TabIndex = 2;
            this.lbProduct.Text = "Ürün :";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(30, 88);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(53, 17);
            this.lbWeight.TabIndex = 3;
            this.lbWeight.Text = "Ağırlık :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(33, 243);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(276, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kayıt";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(30, 133);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(79, 17);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Satış Fiyatı :";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(161, 130);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(190, 25);
            this.tbPrice.TabIndex = 6;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(161, 175);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(190, 25);
            this.tbTotal.TabIndex = 8;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(30, 178);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(110, 17);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Ödenecek Tutar :";
            // 
            // ProductWeight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.cbProduct);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ProductWeight";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Tartım İşlemi";
            this.Load += new System.EventHandler(this.ProductWeight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
    }
}

