namespace BerberApp
{
    partial class frmKullaniciEkle
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
            label3 = new Label();
            btnKaydet = new Button();
            txtSifre = new TextBox();
            txtEposta = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbYetki = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(283, 72);
            label3.Name = "label3";
            label3.Size = new Size(502, 89);
            label3.TabIndex = 11;
            label3.Text = "Kullanıcı Kaydet";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Tomato;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12F);
            btnKaydet.ForeColor = SystemColors.ButtonHighlight;
            btnKaydet.Location = new Point(537, 795);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(297, 75);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F);
            txtSifre.Location = new Point(306, 573);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(528, 61);
            txtSifre.TabIndex = 3;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI", 12F);
            txtEposta.Location = new Point(306, 472);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(528, 61);
            txtEposta.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(167, 576);
            label2.Name = "label2";
            label2.Size = new Size(133, 54);
            label2.TabIndex = 7;
            label2.Text = "Şifre : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(128, 475);
            label1.Name = "label1";
            label1.Size = new Size(172, 54);
            label1.TabIndex = 6;
            label1.Text = "Eposta : ";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F);
            txtSoyad.Location = new Point(306, 381);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(528, 61);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F);
            txtAd.Location = new Point(306, 280);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(528, 61);
            txtAd.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Tomato;
            label4.Location = new Point(139, 384);
            label4.Name = "label4";
            label4.Size = new Size(161, 54);
            label4.TabIndex = 13;
            label4.Text = "Soyad : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(196, 283);
            label5.Name = "label5";
            label5.Size = new Size(104, 54);
            label5.TabIndex = 6;
            label5.Text = "Ad : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(163, 677);
            label6.Name = "label6";
            label6.Size = new Size(137, 54);
            label6.TabIndex = 16;
            label6.Text = "Yetki : ";
            // 
            // cbYetki
            // 
            cbYetki.Font = new Font("Segoe UI", 14F);
            cbYetki.FormattingEnabled = true;
            cbYetki.Location = new Point(306, 667);
            cbYetki.Name = "cbYetki";
            cbYetki.Size = new Size(528, 70);
            cbYetki.TabIndex = 17;
            // 
            // frmKullaniciEkle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(971, 1012);
            Controls.Add(cbYetki);
            Controls.Add(label6);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnKaydet);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKullaniciEkle";
            Text = "frmKullaniciEkle";
            Load += frmKullaniciEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnKaydet;
        private TextBox txtSifre;
        private TextBox txtEposta;
        private Label label2;
        private Label label1;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbYetki;
    }
}