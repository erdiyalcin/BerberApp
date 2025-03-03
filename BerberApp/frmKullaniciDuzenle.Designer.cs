namespace BerberApp
{
    partial class frmKullaniciDuzenle
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
            cbYetki = new ComboBox();
            label6 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            btnKaydet = new Button();
            txtSifre = new TextBox();
            txtEposta = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbYetki
            // 
            cbYetki.Font = new Font("Segoe UI", 14F);
            cbYetki.FormattingEnabled = true;
            cbYetki.Location = new Point(387, 792);
            cbYetki.Margin = new Padding(4);
            cbYetki.Name = "cbYetki";
            cbYetki.Size = new Size(620, 82);
            cbYetki.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(219, 804);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(164, 65);
            label6.TabIndex = 28;
            label6.Text = "Yetki : ";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F);
            txtSoyad.Location = new Point(387, 457);
            txtSoyad.Margin = new Padding(4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(620, 71);
            txtSoyad.TabIndex = 19;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F);
            txtAd.Location = new Point(387, 339);
            txtAd.Margin = new Padding(4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(620, 71);
            txtAd.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Tomato;
            label4.Location = new Point(191, 461);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(193, 65);
            label4.TabIndex = 27;
            label4.Text = "Soyad : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(258, 342);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 65);
            label5.TabIndex = 23;
            label5.Text = "Ad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(360, 95);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(642, 106);
            label3.TabIndex = 26;
            label3.Text = "Kullanıcı Düzenle";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Tomato;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12F);
            btnKaydet.ForeColor = SystemColors.ButtonHighlight;
            btnKaydet.Location = new Point(659, 942);
            btnKaydet.Margin = new Padding(4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(349, 88);
            btnKaydet.TabIndex = 22;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F);
            txtSifre.Location = new Point(387, 682);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(620, 71);
            txtSifre.TabIndex = 21;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI", 12F);
            txtEposta.Location = new Point(387, 564);
            txtEposta.Margin = new Padding(4);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(620, 71);
            txtEposta.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(223, 685);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 65);
            label2.TabIndex = 25;
            label2.Text = "Şifre : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(178, 567);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 65);
            label1.TabIndex = 24;
            label1.Text = "Eposta : ";
            // 
            // frmKullaniciDuzenle
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1384, 1188);
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
            Name = "frmKullaniciDuzenle";
            Text = "frmKullaniciDuzenle";
            Load += frmKullaniciDuzenle_Load;
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
        private Label label3;
        private Button btnKaydet;
        private TextBox txtSifre;
        private TextBox txtEposta;
        private Label label2;
        private Label label1;
    }
}