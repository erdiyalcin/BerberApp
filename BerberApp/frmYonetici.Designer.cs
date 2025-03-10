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
            cbYetki = new ComboBox();
            btnArama = new Button();
            txtArama = new TextBox();
            btnKullaniciEkle = new Button();
            menuDuzenle = new ToolStripMenuItem();
            menuSil = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgvKullanicilar = new DataGridView();
            btnMusteriler = new Button();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // cbYetki
            // 
            cbYetki.Font = new Font("Segoe UI", 14F);
            cbYetki.FormattingEnabled = true;
            cbYetki.Location = new Point(1161, 27);
            cbYetki.Name = "cbYetki";
            cbYetki.Size = new Size(483, 70);
            cbYetki.TabIndex = 18;
            cbYetki.SelectedIndexChanged += cbYetki_SelectedIndexChanged;
            // 
            // btnArama
            // 
            btnArama.Location = new Point(934, 27);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(191, 59);
            btnArama.TabIndex = 3;
            btnArama.Text = "Ara";
            btnArama.UseVisualStyleBackColor = true;
            btnArama.Click += btnArama_Click;
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Segoe UI", 12F);
            txtArama.Location = new Point(536, 27);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(357, 61);
            txtArama.TabIndex = 2;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.Location = new Point(97, 22);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(405, 72);
            btnKullaniciEkle.TabIndex = 1;
            btnKullaniciEkle.Text = "Kullanıcı Ekle";
            btnKullaniciEkle.UseVisualStyleBackColor = true;
            btnKullaniciEkle.Click += btnKullaniciEkle_Click;
            // 
            // menuDuzenle
            // 
            menuDuzenle.Name = "menuDuzenle";
            menuDuzenle.Size = new Size(204, 48);
            menuDuzenle.Text = "Düzenle";
            menuDuzenle.Click += menuDuzenle_Click;
            // 
            // menuSil
            // 
            menuSil.Name = "menuSil";
            menuSil.Size = new Size(204, 48);
            menuSil.Text = "Sil";
            menuSil.Click += menuSil_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(40, 40);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuDuzenle, menuSil });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(205, 100);
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
            dgvKullanicilar.Location = new Point(97, 123);
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
            dgvKullanicilar.Size = new Size(1547, 772);
            dgvKullanicilar.TabIndex = 0;
            // 
            // btnMusteriler
            // 
            btnMusteriler.Location = new Point(1722, 22);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(285, 90);
            btnMusteriler.TabIndex = 19;
            btnMusteriler.Text = "Müşteriler";
            btnMusteriler.UseVisualStyleBackColor = true;
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // frmYonetici
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2230, 1248);
            Controls.Add(btnMusteriler);
            Controls.Add(cbYetki);
            Controls.Add(btnArama);
            Controls.Add(txtArama);
            Controls.Add(btnKullaniciEkle);
            Controls.Add(dgvKullanicilar);
            Name = "frmYonetici";
            Text = "frmYonetici";
            FormClosed += frmYonetici_FormClosed;
            Load += frmYonetici_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbYetki;
        private Button btnArama;
        private TextBox txtArama;
        private Button btnKullaniciEkle;
        private ToolStripMenuItem menuDuzenle;
        private ToolStripMenuItem menuSil;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgvKullanicilar;
        private Button btnMusteriler;
    }
}