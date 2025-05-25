namespace TinyPOS
{
    partial class ConfirmSale
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbNotPaid = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lbCash = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCash);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbPaid);
            this.groupBox1.Controls.Add(this.rbNotPaid);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 168);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Durumu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ücret :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Kalan Tutar :";
            // 
            // tbCash
            // 
            this.tbCash.Location = new System.Drawing.Point(113, 124);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(179, 27);
            this.tbCash.TabIndex = 49;
            this.tbCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCash_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "İsim :";
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Location = new System.Drawing.Point(91, 38);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(77, 24);
            this.rbPaid.TabIndex = 45;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Ödendi";
            this.rbPaid.UseVisualStyleBackColor = true;
            this.rbPaid.CheckedChanged += new System.EventHandler(this.rbPaid_CheckedChanged);
            // 
            // rbNotPaid
            // 
            this.rbNotPaid.AutoSize = true;
            this.rbNotPaid.Location = new System.Drawing.Point(194, 38);
            this.rbNotPaid.Name = "rbNotPaid";
            this.rbNotPaid.Size = new System.Drawing.Size(98, 24);
            this.rbNotPaid.TabIndex = 46;
            this.rbNotPaid.TabStop = true;
            this.rbNotPaid.Text = "Ödenmedi";
            this.rbNotPaid.UseVisualStyleBackColor = true;
            this.rbNotPaid.CheckedChanged += new System.EventHandler(this.tbNotPaid_CheckedChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(113, 86);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 27);
            this.tbName.TabIndex = 47;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYes.Location = new System.Drawing.Point(261, 288);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 40);
            this.btnYes.TabIndex = 57;
            this.btnYes.Text = "Kayıt";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNo.Location = new System.Drawing.Point(23, 288);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 40);
            this.btnNo.TabIndex = 56;
            this.btnNo.Text = "Geri";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lbCash
            // 
            this.lbCash.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbCash.Location = new System.Drawing.Point(23, 228);
            this.lbCash.Name = "lbCash";
            this.lbCash.Size = new System.Drawing.Size(338, 20);
            this.lbCash.TabIndex = 67;
            this.lbCash.Text = "Ödenecek Tutar :";
            this.lbCash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbName
            // 
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(113, 86);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(179, 28);
            this.cbName.TabIndex = 68;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // ConfirmSale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lbCash);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConfirmSale";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış İşlemi - Onay";
            this.Load += new System.EventHandler(this.ConfirmSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.RadioButton rbNotPaid;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCash;
        private System.Windows.Forms.ComboBox cbName;
    }
}

