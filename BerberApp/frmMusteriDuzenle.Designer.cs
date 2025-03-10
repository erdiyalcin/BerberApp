namespace BerberApp
{
    partial class frmMusteriDuzenle
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
            lblMusteriDüzenle = new Label();
            btnDuzenle = new Button();
            txtTelefonNo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F);
            txtSoyad.Location = new Point(323, 373);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(528, 61);
            txtSoyad.TabIndex = 29;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F);
            txtAd.Location = new Point(323, 272);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(528, 61);
            txtAd.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Tomato;
            label4.Location = new Point(156, 376);
            label4.Name = "label4";
            label4.Size = new Size(161, 54);
            label4.TabIndex = 35;
            label4.Text = "Soyad : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(213, 275);
            label5.Name = "label5";
            label5.Size = new Size(104, 54);
            label5.TabIndex = 32;
            label5.Text = "Ad : ";
            // 
            // lblMusteriDüzenle
            // 
            lblMusteriDüzenle.AutoSize = true;
            lblMusteriDüzenle.Font = new Font("Segoe UI", 20F);
            lblMusteriDüzenle.ForeColor = Color.Tomato;
            lblMusteriDüzenle.Location = new Point(300, 64);
            lblMusteriDüzenle.Name = "lblMusteriDüzenle";
            lblMusteriDüzenle.Size = new Size(518, 89);
            lblMusteriDüzenle.TabIndex = 34;
            lblMusteriDüzenle.Text = "Müşteri Düzenle";
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.Tomato;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Segoe UI", 12F);
            btnDuzenle.ForeColor = SystemColors.ButtonHighlight;
            btnDuzenle.Location = new Point(554, 634);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(297, 75);
            btnDuzenle.TabIndex = 31;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // txtTelefonNo
            // 
            txtTelefonNo.Font = new Font("Segoe UI", 12F);
            txtTelefonNo.Location = new Point(323, 464);
            txtTelefonNo.Name = "txtTelefonNo";
            txtTelefonNo.Size = new Size(528, 61);
            txtTelefonNo.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(145, 467);
            label1.Name = "label1";
            label1.Size = new Size(182, 54);
            label1.TabIndex = 33;
            label1.Text = "Telefon : ";
            // 
            // frmMusteriDuzenle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 773);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblMusteriDüzenle);
            Controls.Add(btnDuzenle);
            Controls.Add(txtTelefonNo);
            Controls.Add(label1);
            Name = "frmMusteriDuzenle";
            Text = "frmMusteriDuzenle";
            Load += frmMusteriDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label4;
        private Label label5;
        private Label lblMusteriDüzenle;
        private Button btnDuzenle;
        private TextBox txtTelefonNo;
        private Label label1;
    }
}