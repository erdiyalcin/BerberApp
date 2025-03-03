namespace BerberApp
{
    partial class frmYonetici
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvKullanicilar = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuDuzenle = new ToolStripMenuItem();
            menuSil = new ToolStripMenuItem();
            btnKullaniciEkle = new Button();
            txtArama = new TextBox();
            btnArama = new Button();
            cbYetki = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvKullanicilar.DefaultCellStyle = dataGridViewCellStyle1;
            dgvKullanicilar.Location = new Point(114, 144);
            dgvKullanicilar.Margin = new Padding(4);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKullanicilar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKullanicilar.RowHeadersWidth = 102;
            dgvKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullanicilar.Size = new Size(1820, 904);
            dgvKullanicilar.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(40, 40);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuDuzenle, menuSil });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(229, 116);
            // 
            // menuDuzenle
            // 
            menuDuzenle.Name = "menuDuzenle";
            menuDuzenle.Size = new Size(228, 56);
            menuDuzenle.Text = "Düzenle";
            menuDuzenle.Click += menuDuzenle_Click;
            // 
            // menuSil
            // 
            menuSil.Name = "menuSil";
            menuSil.Size = new Size(228, 56);
            menuSil.Text = "Sil";
            menuSil.Click += menuSil_Click;
            // 
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.Location = new Point(114, 26);
            btnKullaniciEkle.Margin = new Padding(4);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(476, 84);
            btnKullaniciEkle.TabIndex = 1;
            btnKullaniciEkle.Text = "Kullanıcı Ekle";
            btnKullaniciEkle.UseVisualStyleBackColor = true;
            btnKullaniciEkle.Click += btnKullaniciEkle_Click;
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Segoe UI", 12F);
            txtArama.Location = new Point(630, 32);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(419, 71);
            txtArama.TabIndex = 2;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // btnArama
            // 
            btnArama.Location = new Point(1099, 32);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(225, 69);
            btnArama.TabIndex = 3;
            btnArama.Text = "Ara";
            btnArama.UseVisualStyleBackColor = true;
            btnArama.Click += btnArama_Click;
            // 
            // cbYetki
            // 
            cbYetki.Font = new Font("Segoe UI", 14F);
            cbYetki.FormattingEnabled = true;
            cbYetki.Location = new Point(1366, 32);
            cbYetki.Margin = new Padding(4);
            cbYetki.Name = "cbYetki";
            cbYetki.Size = new Size(568, 82);
            cbYetki.TabIndex = 18;
            cbYetki.SelectedIndexChanged += cbYetki_SelectedIndexChanged;
            // 
            // frmYonetici
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2624, 1461);
            Controls.Add(cbYetki);
            Controls.Add(btnArama);
            Controls.Add(txtArama);
            Controls.Add(btnKullaniciEkle);
            Controls.Add(dgvKullanicilar);
            Margin = new Padding(4);
            Name = "frmYonetici";
            Text = "frmYonetici";
            FormClosed += frmYonetici_FormClosed;
            Load += frmYonetici_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKullanicilar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuDuzenle;
        private ToolStripMenuItem menuSil;
        private Button btnKullaniciEkle;
        private TextBox txtArama;
        private Button btnArama;
        private ComboBox cbYetki;
    }
}