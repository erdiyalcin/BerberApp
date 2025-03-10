namespace BerberApp
{
    partial class frmRandevuEkle
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
            cbIslem = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            btnKaydet = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpRandevuTarihi = new DateTimePicker();
            chkGeldiMi = new CheckBox();
            txtBahsis = new TextBox();
            txtUcret = new TextBox();
            lblMusteri = new Label();
            SuspendLayout();
            // 
            // cbIslem
            // 
            cbIslem.Font = new Font("Segoe UI", 14F);
            cbIslem.FormattingEnabled = true;
            cbIslem.Location = new Point(476, 471);
            cbIslem.Name = "cbIslem";
            cbIslem.Size = new Size(528, 70);
            cbIslem.TabIndex = 29;
            cbIslem.SelectedIndexChanged += cbIslem_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(323, 689);
            label6.Name = "label6";
            label6.Size = new Size(133, 54);
            label6.TabIndex = 28;
            label6.Text = "Bahşiş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Tomato;
            label4.Location = new Point(157, 385);
            label4.Name = "label4";
            label4.Size = new Size(313, 54);
            label4.TabIndex = 27;
            label4.Text = "Randevu Tarihi : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(284, 294);
            label5.Name = "label5";
            label5.Size = new Size(189, 54);
            label5.TabIndex = 23;
            label5.Text = "Müşteri : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(252, 88);
            label3.Name = "label3";
            label3.Size = new Size(430, 89);
            label3.TabIndex = 26;
            label3.Text = "Randevu Ekle";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Tomato;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12F);
            btnKaydet.ForeColor = SystemColors.ButtonHighlight;
            btnKaydet.Location = new Point(707, 904);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(297, 75);
            btnKaydet.TabIndex = 22;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(322, 582);
            label2.Name = "label2";
            label2.Size = new Size(148, 54);
            label2.TabIndex = 25;
            label2.Text = "Ücret : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(323, 481);
            label1.Name = "label1";
            label1.Size = new Size(147, 54);
            label1.TabIndex = 24;
            label1.Text = "İşlem : ";
            // 
            // dtpRandevuTarihi
            // 
            dtpRandevuTarihi.Font = new Font("Segoe UI", 12F);
            dtpRandevuTarihi.Location = new Point(476, 380);
            dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            dtpRandevuTarihi.Size = new Size(776, 61);
            dtpRandevuTarihi.TabIndex = 30;
            // 
            // chkGeldiMi
            // 
            chkGeldiMi.AutoSize = true;
            chkGeldiMi.Checked = true;
            chkGeldiMi.CheckState = CheckState.Checked;
            chkGeldiMi.Font = new Font("Segoe UI", 12F);
            chkGeldiMi.Location = new Point(476, 804);
            chkGeldiMi.Name = "chkGeldiMi";
            chkGeldiMi.Size = new Size(228, 58);
            chkGeldiMi.TabIndex = 31;
            chkGeldiMi.Text = "Geldi Mi?";
            chkGeldiMi.UseVisualStyleBackColor = true;
            // 
            // txtBahsis
            // 
            txtBahsis.Font = new Font("Segoe UI", 12F);
            txtBahsis.Location = new Point(476, 686);
            txtBahsis.Name = "txtBahsis";
            txtBahsis.Size = new Size(528, 61);
            txtBahsis.TabIndex = 20;
            // 
            // txtUcret
            // 
            txtUcret.Font = new Font("Segoe UI", 12F);
            txtUcret.Location = new Point(476, 579);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(528, 61);
            txtUcret.TabIndex = 21;
            // 
            // lblMusteri
            // 
            lblMusteri.AutoSize = true;
            lblMusteri.Font = new Font("Segoe UI", 12F);
            lblMusteri.Location = new Point(476, 294);
            lblMusteri.Name = "lblMusteri";
            lblMusteri.Size = new Size(50, 54);
            lblMusteri.TabIndex = 32;
            lblMusteri.Text = "...";
            // 
            // frmRandevuEkle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1720, 1238);
            Controls.Add(lblMusteri);
            Controls.Add(chkGeldiMi);
            Controls.Add(dtpRandevuTarihi);
            Controls.Add(cbIslem);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnKaydet);
            Controls.Add(txtUcret);
            Controls.Add(txtBahsis);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRandevuEkle";
            Text = "frmRandevuEkle";
            Load += frmRandevuEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbIslem;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private Button btnKaydet;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpRandevuTarihi;
        private CheckBox chkGeldiMi;
        private TextBox txtBahsis;
        private TextBox txtUcret;
        private Label lblMusteri;
    }
}