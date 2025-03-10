namespace BerberApp
{
    partial class frmMusteriEkle
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
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lblMusteriKaydet = new Label();
            btnKaydet = new Button();
            txtTelefonNo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F);
            txtSoyad.Location = new Point(252, 383);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(528, 61);
            txtSoyad.TabIndex = 19;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F);
            txtAd.Location = new Point(252, 282);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(528, 61);
            txtAd.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Tomato;
            label4.Location = new Point(85, 386);
            label4.Name = "label4";
            label4.Size = new Size(161, 54);
            label4.TabIndex = 27;
            label4.Text = "Soyad : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(142, 285);
            label5.Name = "label5";
            label5.Size = new Size(104, 54);
            label5.TabIndex = 23;
            label5.Text = "Ad : ";
            // 
            // lblMusteriKaydet
            // 
            lblMusteriKaydet.AutoSize = true;
            lblMusteriKaydet.Font = new Font("Segoe UI", 20F);
            lblMusteriKaydet.ForeColor = Color.Tomato;
            lblMusteriKaydet.Location = new Point(229, 74);
            lblMusteriKaydet.Name = "lblMusteriKaydet";
            lblMusteriKaydet.Size = new Size(481, 89);
            lblMusteriKaydet.TabIndex = 26;
            lblMusteriKaydet.Text = "Müşteri Kaydet";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Tomato;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12F);
            btnKaydet.ForeColor = SystemColors.ButtonHighlight;
            btnKaydet.Location = new Point(483, 644);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(297, 75);
            btnKaydet.TabIndex = 22;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtTelefonNo
            // 
            txtTelefonNo.Font = new Font("Segoe UI", 12F);
            txtTelefonNo.Location = new Point(252, 474);
            txtTelefonNo.Name = "txtTelefonNo";
            txtTelefonNo.Size = new Size(528, 61);
            txtTelefonNo.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(74, 477);
            label1.Name = "label1";
            label1.Size = new Size(182, 54);
            label1.TabIndex = 24;
            label1.Text = "Telefon : ";
            // 
            // frmMusteriEkle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 1012);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblMusteriKaydet);
            Controls.Add(btnKaydet);
            Controls.Add(txtTelefonNo);
            Controls.Add(label1);
            Name = "frmMusteriEkle";
            Text = "frmMusteriEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbYetki;
        private Label label6;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label4;
        private Label label5;
        private Label lblMusteriKaydet;
        private Button btnKaydet;
        private TextBox txtSifre;
        private TextBox txtTelefonNo;
        private Label label2;
        private Label label1;
    }
}