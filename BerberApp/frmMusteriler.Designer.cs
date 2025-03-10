namespace BerberApp
{
    partial class frmMusteriler
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
            btnMusteriEkle = new Button();
            menuDuzenle = new ToolStripMenuItem();
            menuSil = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            randevularToolStripMenuItem = new ToolStripMenuItem();
            menuRandevuEkle = new ToolStripMenuItem();
            menuRandevuListele = new ToolStripMenuItem();
            dgvKullanicilar = new DataGridView();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // cbYetki
            // 
            cbYetki.Font = new Font("Segoe UI", 14F);
            cbYetki.FormattingEnabled = true;
            cbYetki.Location = new Point(1189, 100);
            cbYetki.Name = "cbYetki";
            cbYetki.Size = new Size(483, 70);
            cbYetki.TabIndex = 23;
            // 
            // btnArama
            // 
            btnArama.Location = new Point(962, 100);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(191, 59);
            btnArama.TabIndex = 22;
            btnArama.Text = "Ara";
            btnArama.UseVisualStyleBackColor = true;
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Segoe UI", 12F);
            txtArama.Location = new Point(564, 100);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(357, 61);
            txtArama.TabIndex = 21;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Location = new Point(125, 95);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(405, 72);
            btnMusteriEkle.TabIndex = 20;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // menuDuzenle
            // 
            menuDuzenle.Name = "menuDuzenle";
            menuDuzenle.Size = new Size(211, 48);
            menuDuzenle.Text = "Düzenle";
            menuDuzenle.Click += menuDuzenle_Click;
            // 
            // menuSil
            // 
            menuSil.Name = "menuSil";
            menuSil.Size = new Size(211, 48);
            menuSil.Text = "Sil";
            menuSil.Click += menuSil_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(40, 40);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { randevularToolStripMenuItem, menuDuzenle, menuSil });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(212, 148);
            // 
            // randevularToolStripMenuItem
            // 
            randevularToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuRandevuEkle, menuRandevuListele });
            randevularToolStripMenuItem.Name = "randevularToolStripMenuItem";
            randevularToolStripMenuItem.Size = new Size(211, 48);
            randevularToolStripMenuItem.Text = "Randevu";
            // 
            // menuRandevuEkle
            // 
            menuRandevuEkle.Name = "menuRandevuEkle";
            menuRandevuEkle.Size = new Size(448, 54);
            menuRandevuEkle.Text = "Ekle";
            menuRandevuEkle.Click += menuRandevuEkle_Click;
            // 
            // menuRandevuListele
            // 
            menuRandevuListele.Name = "menuRandevuListele";
            menuRandevuListele.Size = new Size(448, 54);
            menuRandevuListele.Text = "Listele";
            menuRandevuListele.Click += menuRandevuListele_Click;
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
            dgvKullanicilar.Location = new Point(125, 196);
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
            dgvKullanicilar.TabIndex = 19;
            // 
            // frmMusteriler
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2230, 1248);
            Controls.Add(cbYetki);
            Controls.Add(btnArama);
            Controls.Add(txtArama);
            Controls.Add(btnMusteriEkle);
            Controls.Add(dgvKullanicilar);
            Name = "frmMusteriler";
            Text = "frmMusteriler";
            Load += frmMusteriler_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbYetki;
        private Button btnArama;
        private TextBox txtArama;
        private Button btnMusteriEkle;
        private ToolStripMenuItem menuDuzenle;
        private ToolStripMenuItem menuSil;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgvKullanicilar;
        private ToolStripMenuItem randevularToolStripMenuItem;
        private ToolStripMenuItem menuRandevuEkle;
        private ToolStripMenuItem menuRandevuListele;
    }
}