namespace TinyPOS
{
    partial class Receivables
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstReceivables = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFee = new System.Windows.Forms.TextBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(1120, 820);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 45);
            this.btnRemove.TabIndex = 90;
            this.btnRemove.Text = "Kaydı Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstReceivables
            // 
            this.lstReceivables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstReceivables.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstReceivables.FullRowSelect = true;
            this.lstReceivables.HideSelection = false;
            this.lstReceivables.Location = new System.Drawing.Point(60, 145);
            this.lstReceivables.Margin = new System.Windows.Forms.Padding(20);
            this.lstReceivables.MultiSelect = false;
            this.lstReceivables.Name = "lstReceivables";
            this.lstReceivables.Size = new System.Drawing.Size(836, 650);
            this.lstReceivables.TabIndex = 89;
            this.lstReceivables.UseCompatibleStateImageBehavior = false;
            this.lstReceivables.SelectedIndexChanged += new System.EventHandler(this.lstReceivables_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(1260, 820);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Kayıt Güncelle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(60, 820);
            this.btnBack.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 45);
            this.btnBack.TabIndex = 84;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.Location = new System.Drawing.Point(56, 82);
            this.lblBarcode.Margin = new System.Windows.Forms.Padding(8);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(96, 20);
            this.lblBarcode.TabIndex = 76;
            this.lblBarcode.Text = "Müşteri Adı: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(478, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Borç Tutarı:";
            // 
            // tbFee
            // 
            this.tbFee.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbFee.Location = new System.Drawing.Point(583, 79);
            this.tbFee.Margin = new System.Windows.Forms.Padding(10);
            this.tbFee.Name = "tbFee";
            this.tbFee.Size = new System.Drawing.Size(250, 27);
            this.tbFee.TabIndex = 92;
            this.tbFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFee_KeyPress);
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbCustomer.Location = new System.Drawing.Point(170, 79);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(10);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(250, 27);
            this.tbCustomer.TabIndex = 99;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(233, 832);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 20);
            this.lblTotal.TabIndex = 100;
            this.lblTotal.Text = "Toplam Tutar:";
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 20;
            this.lstCart.Location = new System.Drawing.Point(919, 145);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(461, 644);
            this.lstCart.TabIndex = 101;
            // 
            // Receivables
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFee);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstReceivables);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBarcode);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Receivables";
            this.Padding = new System.Windows.Forms.Padding(40, 30, 40, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tahsilat Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Receivables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView lstReceivables;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFee;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lstCart;
    }
}

