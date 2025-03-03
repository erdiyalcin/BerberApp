namespace BerberApp
{
    partial class frmGiris
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
            label1 = new Label();
            label2 = new Label();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(127, 321);
            label1.Name = "label1";
            label1.Size = new Size(204, 65);
            label1.TabIndex = 0;
            label1.Text = "Eposta : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(172, 436);
            label2.Name = "label2";
            label2.Size = new Size(159, 65);
            label2.TabIndex = 1;
            label2.Text = "Şifre : ";
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI", 12F);
            txtEposta.Location = new Point(337, 315);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(621, 71);
            txtEposta.TabIndex = 2;
            txtEposta.Text = "erdi@gmail.com";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F);
            txtSifre.Location = new Point(337, 433);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(621, 71);
            txtSifre.TabIndex = 3;
            txtSifre.Text = "1234";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Tomato;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Segoe UI", 12F);
            btnGirisYap.ForeColor = SystemColors.ButtonHighlight;
            btnGirisYap.Location = new Point(609, 553);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(349, 88);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(338, 120);
            label3.Name = "label3";
            label3.Size = new Size(405, 106);
            label3.TabIndex = 5;
            label3.Text = "Kel BerBer";
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1038, 791);
            Controls.Add(label3);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGiris";
            Text = "Kullanıcı Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private Button btnGirisYap;
        private Label label3;
    }
}