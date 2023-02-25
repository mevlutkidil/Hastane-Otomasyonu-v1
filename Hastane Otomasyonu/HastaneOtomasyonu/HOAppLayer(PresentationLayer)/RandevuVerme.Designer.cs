namespace HOAppLayer_PresentationLayer_
{
    partial class RandevuVerme
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
            this.lbl_hastaad = new System.Windows.Forms.Label();
            this.lbl_hastasoyad = new System.Windows.Forms.Label();
            this.lbl_hastatel = new System.Windows.Forms.Label();
            this.lbl_brans = new System.Windows.Forms.Label();
            this.lbl_doktor = new System.Windows.Forms.Label();
            this.lbl_randevutime = new System.Windows.Forms.Label();
            this.btn_randevuver = new System.Windows.Forms.Button();
            this.txt_hastaad = new System.Windows.Forms.TextBox();
            this.txt_hastasoyad = new System.Windows.Forms.TextBox();
            this.txt_hastatel = new System.Windows.Forms.TextBox();
            this.dtp_randevu = new System.Windows.Forms.DateTimePicker();
            this.dgv_hastalar = new System.Windows.Forms.DataGridView();
            this.cmbx_doktor = new System.Windows.Forms.ComboBox();
            this.cmbx_brans = new System.Windows.Forms.ComboBox();
            this.txt_hastatcno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hastaid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_doktor = new System.Windows.Forms.DataGridView();
            this.dgv_brans = new System.Windows.Forms.DataGridView();
            this.dgv_randevular = new System.Windows.Forms.DataGridView();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hastalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_randevular)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_hastaad
            // 
            this.lbl_hastaad.AutoSize = true;
            this.lbl_hastaad.Location = new System.Drawing.Point(69, 254);
            this.lbl_hastaad.Name = "lbl_hastaad";
            this.lbl_hastaad.Size = new System.Drawing.Size(66, 16);
            this.lbl_hastaad.TabIndex = 0;
            this.lbl_hastaad.Text = "Hasta Ad:";
            // 
            // lbl_hastasoyad
            // 
            this.lbl_hastasoyad.AutoSize = true;
            this.lbl_hastasoyad.Location = new System.Drawing.Point(69, 316);
            this.lbl_hastasoyad.Name = "lbl_hastasoyad";
            this.lbl_hastasoyad.Size = new System.Drawing.Size(92, 16);
            this.lbl_hastasoyad.TabIndex = 1;
            this.lbl_hastasoyad.Text = "Hasta Soyad :";
            // 
            // lbl_hastatel
            // 
            this.lbl_hastatel.AutoSize = true;
            this.lbl_hastatel.Location = new System.Drawing.Point(69, 378);
            this.lbl_hastatel.Name = "lbl_hastatel";
            this.lbl_hastatel.Size = new System.Drawing.Size(66, 16);
            this.lbl_hastatel.TabIndex = 2;
            this.lbl_hastatel.Text = "Hasa Tel:";
            // 
            // lbl_brans
            // 
            this.lbl_brans.AutoSize = true;
            this.lbl_brans.Location = new System.Drawing.Point(69, 440);
            this.lbl_brans.Name = "lbl_brans";
            this.lbl_brans.Size = new System.Drawing.Size(48, 16);
            this.lbl_brans.TabIndex = 3;
            this.lbl_brans.Text = "Branş :";
            // 
            // lbl_doktor
            // 
            this.lbl_doktor.AutoSize = true;
            this.lbl_doktor.Location = new System.Drawing.Point(69, 502);
            this.lbl_doktor.Name = "lbl_doktor";
            this.lbl_doktor.Size = new System.Drawing.Size(53, 16);
            this.lbl_doktor.TabIndex = 4;
            this.lbl_doktor.Text = "Doktor :";
            // 
            // lbl_randevutime
            // 
            this.lbl_randevutime.AutoSize = true;
            this.lbl_randevutime.Location = new System.Drawing.Point(69, 564);
            this.lbl_randevutime.Name = "lbl_randevutime";
            this.lbl_randevutime.Size = new System.Drawing.Size(116, 16);
            this.lbl_randevutime.TabIndex = 5;
            this.lbl_randevutime.Text = "Randevu Zamanı :";
            // 
            // btn_randevuver
            // 
            this.btn_randevuver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_randevuver.Location = new System.Drawing.Point(191, 604);
            this.btn_randevuver.Name = "btn_randevuver";
            this.btn_randevuver.Size = new System.Drawing.Size(204, 75);
            this.btn_randevuver.TabIndex = 6;
            this.btn_randevuver.Text = "Randevu Oluştur ";
            this.btn_randevuver.UseVisualStyleBackColor = true;
            this.btn_randevuver.Click += new System.EventHandler(this.btn_randevuver_Click);
            // 
            // txt_hastaad
            // 
            this.txt_hastaad.Enabled = false;
            this.txt_hastaad.Location = new System.Drawing.Point(191, 254);
            this.txt_hastaad.Name = "txt_hastaad";
            this.txt_hastaad.Size = new System.Drawing.Size(204, 22);
            this.txt_hastaad.TabIndex = 7;
            // 
            // txt_hastasoyad
            // 
            this.txt_hastasoyad.Enabled = false;
            this.txt_hastasoyad.Location = new System.Drawing.Point(191, 316);
            this.txt_hastasoyad.Name = "txt_hastasoyad";
            this.txt_hastasoyad.Size = new System.Drawing.Size(204, 22);
            this.txt_hastasoyad.TabIndex = 8;
            // 
            // txt_hastatel
            // 
            this.txt_hastatel.Enabled = false;
            this.txt_hastatel.Location = new System.Drawing.Point(191, 378);
            this.txt_hastatel.Name = "txt_hastatel";
            this.txt_hastatel.Size = new System.Drawing.Size(204, 22);
            this.txt_hastatel.TabIndex = 9;
            // 
            // dtp_randevu
            // 
            this.dtp_randevu.Location = new System.Drawing.Point(191, 564);
            this.dtp_randevu.Name = "dtp_randevu";
            this.dtp_randevu.Size = new System.Drawing.Size(200, 22);
            this.dtp_randevu.TabIndex = 12;
            // 
            // dgv_hastalar
            // 
            this.dgv_hastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hastalar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hastalar.Location = new System.Drawing.Point(479, 305);
            this.dgv_hastalar.Name = "dgv_hastalar";
            this.dgv_hastalar.ReadOnly = true;
            this.dgv_hastalar.RowHeadersVisible = false;
            this.dgv_hastalar.RowHeadersWidth = 51;
            this.dgv_hastalar.RowTemplate.Height = 24;
            this.dgv_hastalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hastalar.Size = new System.Drawing.Size(703, 98);
            this.dgv_hastalar.TabIndex = 15;
            this.dgv_hastalar.SelectionChanged += new System.EventHandler(this.dgv_brans_SelectionChanged);
            // 
            // cmbx_doktor
            // 
            this.cmbx_doktor.FormattingEnabled = true;
            this.cmbx_doktor.Location = new System.Drawing.Point(191, 494);
            this.cmbx_doktor.Name = "cmbx_doktor";
            this.cmbx_doktor.Size = new System.Drawing.Size(204, 24);
            this.cmbx_doktor.TabIndex = 21;
            // 
            // cmbx_brans
            // 
            this.cmbx_brans.FormattingEnabled = true;
            this.cmbx_brans.Location = new System.Drawing.Point(191, 442);
            this.cmbx_brans.Name = "cmbx_brans";
            this.cmbx_brans.Size = new System.Drawing.Size(204, 24);
            this.cmbx_brans.TabIndex = 22;
            // 
            // txt_hastatcno
            // 
            this.txt_hastatcno.Enabled = false;
            this.txt_hastatcno.Location = new System.Drawing.Point(191, 192);
            this.txt_hastatcno.Name = "txt_hastatcno";
            this.txt_hastatcno.Size = new System.Drawing.Size(204, 22);
            this.txt_hastatcno.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hasta TC No :";
            // 
            // txt_hastaid
            // 
            this.txt_hastaid.Enabled = false;
            this.txt_hastaid.Location = new System.Drawing.Point(191, 134);
            this.txt_hastaid.Name = "txt_hastaid";
            this.txt_hastaid.Size = new System.Drawing.Size(204, 22);
            this.txt_hastaid.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Hasta ID :";
            // 
            // dgv_doktor
            // 
            this.dgv_doktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_doktor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doktor.Location = new System.Drawing.Point(479, 438);
            this.dgv_doktor.Name = "dgv_doktor";
            this.dgv_doktor.ReadOnly = true;
            this.dgv_doktor.RowHeadersVisible = false;
            this.dgv_doktor.RowHeadersWidth = 51;
            this.dgv_doktor.RowTemplate.Height = 24;
            this.dgv_doktor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doktor.Size = new System.Drawing.Size(703, 98);
            this.dgv_doktor.TabIndex = 27;
            // 
            // dgv_brans
            // 
            this.dgv_brans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_brans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_brans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_brans.Location = new System.Drawing.Point(479, 581);
            this.dgv_brans.Name = "dgv_brans";
            this.dgv_brans.ReadOnly = true;
            this.dgv_brans.RowHeadersVisible = false;
            this.dgv_brans.RowHeadersWidth = 51;
            this.dgv_brans.RowTemplate.Height = 24;
            this.dgv_brans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_brans.Size = new System.Drawing.Size(703, 98);
            this.dgv_brans.TabIndex = 28;
            // 
            // dgv_randevular
            // 
            this.dgv_randevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_randevular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_randevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_randevular.Location = new System.Drawing.Point(479, 86);
            this.dgv_randevular.Name = "dgv_randevular";
            this.dgv_randevular.ReadOnly = true;
            this.dgv_randevular.RowHeadersVisible = false;
            this.dgv_randevular.RowHeadersWidth = 51;
            this.dgv_randevular.RowTemplate.Height = 24;
            this.dgv_randevular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_randevular.Size = new System.Drawing.Size(703, 182);
            this.dgv_randevular.TabIndex = 29;
            // 
            // btn_kapat
            // 
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(1163, 0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(50, 30);
            this.btn_kapat.TabIndex = 31;
            this.btn_kapat.Text = "x";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(1122, 0);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(35, 30);
            this.btn_geri.TabIndex = 30;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_kapat);
            this.panel1.Controls.Add(this.btn_geri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 55);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 55);
            this.panel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Randevular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Hastalar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Doktorlar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Branslar";
            // 
            // RandevuVerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 755);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_brans);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_randevular);
            this.Controls.Add(this.dgv_doktor);
            this.Controls.Add(this.txt_hastaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_hastatcno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_brans);
            this.Controls.Add(this.cmbx_doktor);
            this.Controls.Add(this.dgv_hastalar);
            this.Controls.Add(this.dtp_randevu);
            this.Controls.Add(this.txt_hastatel);
            this.Controls.Add(this.txt_hastasoyad);
            this.Controls.Add(this.txt_hastaad);
            this.Controls.Add(this.btn_randevuver);
            this.Controls.Add(this.lbl_randevutime);
            this.Controls.Add(this.lbl_doktor);
            this.Controls.Add(this.lbl_brans);
            this.Controls.Add(this.lbl_hastatel);
            this.Controls.Add(this.lbl_hastasoyad);
            this.Controls.Add(this.lbl_hastaad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandevuVerme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandevuVerme";
            this.Load += new System.EventHandler(this.RandevuVerme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hastalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_randevular)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hastaad;
        private System.Windows.Forms.Label lbl_hastasoyad;
        private System.Windows.Forms.Label lbl_hastatel;
        private System.Windows.Forms.Label lbl_brans;
        private System.Windows.Forms.Label lbl_doktor;
        private System.Windows.Forms.Label lbl_randevutime;
        private System.Windows.Forms.Button btn_randevuver;
        private System.Windows.Forms.TextBox txt_hastaad;
        private System.Windows.Forms.TextBox txt_hastasoyad;
        private System.Windows.Forms.TextBox txt_hastatel;
        private System.Windows.Forms.DateTimePicker dtp_randevu;
        private System.Windows.Forms.DataGridView dgv_hastalar;
        private System.Windows.Forms.ComboBox cmbx_doktor;
        private System.Windows.Forms.ComboBox cmbx_brans;
        private System.Windows.Forms.TextBox txt_hastatcno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hastaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_doktor;
        private System.Windows.Forms.DataGridView dgv_brans;
        private System.Windows.Forms.DataGridView dgv_randevular;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}