namespace HOAppLayer_PresentationLayer_
{
    partial class SekreterDoktorİslemleri
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
            this.dgv_doktor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_doktorad = new System.Windows.Forms.TextBox();
            this.txt_doktorsoyad = new System.Windows.Forms.TextBox();
            this.txt_doktortel = new System.Windows.Forms.TextBox();
            this.txt_doktorsifre = new System.Windows.Forms.TextBox();
            this.txt_doktorusername = new System.Windows.Forms.TextBox();
            this.btn_doktorguncelle = new System.Windows.Forms.Button();
            this.brn_doktorsil = new System.Windows.Forms.Button();
            this.btn_doktorekle = new System.Windows.Forms.Button();
            this.cmbx_brans = new System.Windows.Forms.ComboBox();
            this.dgv_brans = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_doktorid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brans)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_doktor
            // 
            this.dgv_doktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doktor.Location = new System.Drawing.Point(176, 115);
            this.dgv_doktor.Name = "dgv_doktor";
            this.dgv_doktor.RowHeadersVisible = false;
            this.dgv_doktor.RowHeadersWidth = 51;
            this.dgv_doktor.RowTemplate.Height = 24;
            this.dgv_doktor.Size = new System.Drawing.Size(956, 204);
            this.dgv_doktor.TabIndex = 1;
            this.dgv_doktor.SelectionChanged += new System.EventHandler(this.dgv_doktor_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doktor Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doktor Tel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Doktor Sifre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Doktor Kullanıcı Adı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Doktor Brans :";
            // 
            // txt_doktorad
            // 
            this.txt_doktorad.Location = new System.Drawing.Point(308, 373);
            this.txt_doktorad.Multiline = true;
            this.txt_doktorad.Name = "txt_doktorad";
            this.txt_doktorad.Size = new System.Drawing.Size(194, 24);
            this.txt_doktorad.TabIndex = 16;
            // 
            // txt_doktorsoyad
            // 
            this.txt_doktorsoyad.Location = new System.Drawing.Point(308, 403);
            this.txt_doktorsoyad.Multiline = true;
            this.txt_doktorsoyad.Name = "txt_doktorsoyad";
            this.txt_doktorsoyad.Size = new System.Drawing.Size(194, 24);
            this.txt_doktorsoyad.TabIndex = 17;
            // 
            // txt_doktortel
            // 
            this.txt_doktortel.Location = new System.Drawing.Point(308, 433);
            this.txt_doktortel.Multiline = true;
            this.txt_doktortel.Name = "txt_doktortel";
            this.txt_doktortel.Size = new System.Drawing.Size(194, 24);
            this.txt_doktortel.TabIndex = 18;
            // 
            // txt_doktorsifre
            // 
            this.txt_doktorsifre.Location = new System.Drawing.Point(308, 523);
            this.txt_doktorsifre.Multiline = true;
            this.txt_doktorsifre.Name = "txt_doktorsifre";
            this.txt_doktorsifre.Size = new System.Drawing.Size(194, 24);
            this.txt_doktorsifre.TabIndex = 21;
            // 
            // txt_doktorusername
            // 
            this.txt_doktorusername.Location = new System.Drawing.Point(308, 493);
            this.txt_doktorusername.Multiline = true;
            this.txt_doktorusername.Name = "txt_doktorusername";
            this.txt_doktorusername.Size = new System.Drawing.Size(194, 24);
            this.txt_doktorusername.TabIndex = 20;
            // 
            // btn_doktorguncelle
            // 
            this.btn_doktorguncelle.Location = new System.Drawing.Point(944, 329);
            this.btn_doktorguncelle.Name = "btn_doktorguncelle";
            this.btn_doktorguncelle.Size = new System.Drawing.Size(188, 60);
            this.btn_doktorguncelle.TabIndex = 23;
            this.btn_doktorguncelle.Text = "Güncelle";
            this.btn_doktorguncelle.UseVisualStyleBackColor = true;
            this.btn_doktorguncelle.Click += new System.EventHandler(this.btn_doktorguncelle_Click);
            // 
            // brn_doktorsil
            // 
            this.brn_doktorsil.Location = new System.Drawing.Point(944, 405);
            this.brn_doktorsil.Name = "brn_doktorsil";
            this.brn_doktorsil.Size = new System.Drawing.Size(188, 60);
            this.brn_doktorsil.TabIndex = 24;
            this.brn_doktorsil.Text = "Sil";
            this.brn_doktorsil.UseVisualStyleBackColor = true;
            this.brn_doktorsil.Click += new System.EventHandler(this.brn_doktorsil_Click);
            // 
            // btn_doktorekle
            // 
            this.btn_doktorekle.Location = new System.Drawing.Point(944, 479);
            this.btn_doktorekle.Name = "btn_doktorekle";
            this.btn_doktorekle.Size = new System.Drawing.Size(188, 60);
            this.btn_doktorekle.TabIndex = 25;
            this.btn_doktorekle.Text = "Ekle";
            this.btn_doktorekle.UseVisualStyleBackColor = true;
            this.btn_doktorekle.Click += new System.EventHandler(this.btn_doktorekle_Click);
            // 
            // cmbx_brans
            // 
            this.cmbx_brans.FormattingEnabled = true;
            this.cmbx_brans.Location = new System.Drawing.Point(308, 460);
            this.cmbx_brans.Name = "cmbx_brans";
            this.cmbx_brans.Size = new System.Drawing.Size(194, 24);
            this.cmbx_brans.TabIndex = 26;
            // 
            // dgv_brans
            // 
            this.dgv_brans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_brans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_brans.Location = new System.Drawing.Point(19, 37);
            this.dgv_brans.Name = "dgv_brans";
            this.dgv_brans.RowHeadersVisible = false;
            this.dgv_brans.RowHeadersWidth = 51;
            this.dgv_brans.RowTemplate.Height = 24;
            this.dgv_brans.Size = new System.Drawing.Size(408, 156);
            this.dgv_brans.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_geri);
            this.panel1.Controls.Add(this.btn_kapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 43);
            this.panel1.TabIndex = 52;
            // 
            // btn_geri
            // 
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(1067, 3);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(65, 30);
            this.btn_geri.TabIndex = 21;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(1143, 3);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(65, 30);
            this.btn_kapat.TabIndex = 20;
            this.btn_kapat.Text = "x";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 648);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 43);
            this.panel2.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doktor ID :";
            // 
            // txt_doktorid
            // 
            this.txt_doktorid.Enabled = false;
            this.txt_doktorid.Location = new System.Drawing.Point(308, 343);
            this.txt_doktorid.Multiline = true;
            this.txt_doktorid.Name = "txt_doktorid";
            this.txt_doktorid.Size = new System.Drawing.Size(194, 24);
            this.txt_doktorid.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 22);
            this.label5.TabIndex = 54;
            this.label5.Text = "Brans Id\'yi Tablodan seçerek giriniz.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_brans);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(508, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 196);
            this.panel3.TabIndex = 55;
            // 
            // SekreterDoktorİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 691);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbx_brans);
            this.Controls.Add(this.btn_doktorekle);
            this.Controls.Add(this.brn_doktorsil);
            this.Controls.Add(this.btn_doktorguncelle);
            this.Controls.Add(this.txt_doktorsifre);
            this.Controls.Add(this.txt_doktorusername);
            this.Controls.Add(this.txt_doktortel);
            this.Controls.Add(this.txt_doktorsoyad);
            this.Controls.Add(this.txt_doktorad);
            this.Controls.Add(this.txt_doktorid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_doktor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SekreterDoktorİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterDoktorİslemleri";
            this.Load += new System.EventHandler(this.SekreterDoktorİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brans)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_doktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_doktorad;
        private System.Windows.Forms.TextBox txt_doktorsoyad;
        private System.Windows.Forms.TextBox txt_doktortel;
        private System.Windows.Forms.TextBox txt_doktorsifre;
        private System.Windows.Forms.TextBox txt_doktorusername;
        private System.Windows.Forms.Button btn_doktorguncelle;
        private System.Windows.Forms.Button brn_doktorsil;
        private System.Windows.Forms.Button btn_doktorekle;
        private System.Windows.Forms.ComboBox cmbx_brans;
        private System.Windows.Forms.DataGridView dgv_brans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_doktorid;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
    }
}