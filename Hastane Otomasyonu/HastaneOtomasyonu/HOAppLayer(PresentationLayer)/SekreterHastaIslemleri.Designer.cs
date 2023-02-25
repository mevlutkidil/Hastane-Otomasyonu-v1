namespace HOAppLayer_PresentationLayer_
{
    partial class SekreterHastaIslemleri
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.brn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.txt_hastatel = new System.Windows.Forms.TextBox();
            this.txt_hastasoyad = new System.Windows.Forms.TextBox();
            this.txt_hastaad = new System.Windows.Forms.TextBox();
            this.txt_hastaid = new System.Windows.Forms.TextBox();
            this.lbl_hastatel = new System.Windows.Forms.Label();
            this.lbl_hastasoyad = new System.Windows.Forms.Label();
            this.lbl_hastaad = new System.Windows.Forms.Label();
            this.lbl_hastaid = new System.Windows.Forms.Label();
            this.dgv_hasta = new System.Windows.Forms.DataGridView();
            this.txt_hastatcno = new System.Windows.Forms.TextBox();
            this.lbl_hastatc = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hasta)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.Location = new System.Drawing.Point(539, 419);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(215, 53);
            this.btn_ekle.TabIndex = 44;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // brn_sil
            // 
            this.brn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brn_sil.Location = new System.Drawing.Point(539, 354);
            this.brn_sil.Name = "brn_sil";
            this.brn_sil.Size = new System.Drawing.Size(215, 53);
            this.brn_sil.TabIndex = 43;
            this.brn_sil.Text = "Sil";
            this.brn_sil.UseVisualStyleBackColor = true;
            this.brn_sil.Click += new System.EventHandler(this.brn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.Location = new System.Drawing.Point(539, 292);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(215, 53);
            this.btn_guncelle.TabIndex = 42;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txt_hastatel
            // 
            this.txt_hastatel.Location = new System.Drawing.Point(250, 449);
            this.txt_hastatel.Multiline = true;
            this.txt_hastatel.Name = "txt_hastatel";
            this.txt_hastatel.Size = new System.Drawing.Size(194, 23);
            this.txt_hastatel.TabIndex = 38;
            // 
            // txt_hastasoyad
            // 
            this.txt_hastasoyad.Location = new System.Drawing.Point(250, 409);
            this.txt_hastasoyad.Multiline = true;
            this.txt_hastasoyad.Name = "txt_hastasoyad";
            this.txt_hastasoyad.Size = new System.Drawing.Size(194, 23);
            this.txt_hastasoyad.TabIndex = 37;
            // 
            // txt_hastaad
            // 
            this.txt_hastaad.Location = new System.Drawing.Point(250, 369);
            this.txt_hastaad.Multiline = true;
            this.txt_hastaad.Name = "txt_hastaad";
            this.txt_hastaad.Size = new System.Drawing.Size(194, 23);
            this.txt_hastaad.TabIndex = 36;
            // 
            // txt_hastaid
            // 
            this.txt_hastaid.Enabled = false;
            this.txt_hastaid.Location = new System.Drawing.Point(250, 289);
            this.txt_hastaid.Multiline = true;
            this.txt_hastaid.Name = "txt_hastaid";
            this.txt_hastaid.Size = new System.Drawing.Size(194, 23);
            this.txt_hastaid.TabIndex = 35;
            // 
            // lbl_hastatel
            // 
            this.lbl_hastatel.AutoSize = true;
            this.lbl_hastatel.Location = new System.Drawing.Point(127, 449);
            this.lbl_hastatel.Name = "lbl_hastatel";
            this.lbl_hastatel.Size = new System.Drawing.Size(66, 16);
            this.lbl_hastatel.TabIndex = 31;
            this.lbl_hastatel.Text = "HastaTel:";
            // 
            // lbl_hastasoyad
            // 
            this.lbl_hastasoyad.AutoSize = true;
            this.lbl_hastasoyad.Location = new System.Drawing.Point(127, 409);
            this.lbl_hastasoyad.Name = "lbl_hastasoyad";
            this.lbl_hastasoyad.Size = new System.Drawing.Size(92, 16);
            this.lbl_hastasoyad.TabIndex = 30;
            this.lbl_hastasoyad.Text = "Hasta Soyad :";
            // 
            // lbl_hastaad
            // 
            this.lbl_hastaad.AutoSize = true;
            this.lbl_hastaad.Location = new System.Drawing.Point(128, 369);
            this.lbl_hastaad.Name = "lbl_hastaad";
            this.lbl_hastaad.Size = new System.Drawing.Size(69, 16);
            this.lbl_hastaad.TabIndex = 29;
            this.lbl_hastaad.Text = "Hasta Ad :";
            // 
            // lbl_hastaid
            // 
            this.lbl_hastaid.AutoSize = true;
            this.lbl_hastaid.Location = new System.Drawing.Point(132, 289);
            this.lbl_hastaid.Name = "lbl_hastaid";
            this.lbl_hastaid.Size = new System.Drawing.Size(65, 16);
            this.lbl_hastaid.TabIndex = 28;
            this.lbl_hastaid.Text = "Hasta ID :";
            // 
            // dgv_hasta
            // 
            this.dgv_hasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hasta.Location = new System.Drawing.Point(131, 86);
            this.dgv_hasta.Name = "dgv_hasta";
            this.dgv_hasta.RowHeadersVisible = false;
            this.dgv_hasta.RowHeadersWidth = 51;
            this.dgv_hasta.RowTemplate.Height = 24;
            this.dgv_hasta.Size = new System.Drawing.Size(623, 177);
            this.dgv_hasta.TabIndex = 27;
            this.dgv_hasta.SelectionChanged += new System.EventHandler(this.dgv_hasta_SelectionChanged);
            // 
            // txt_hastatcno
            // 
            this.txt_hastatcno.Location = new System.Drawing.Point(250, 329);
            this.txt_hastatcno.Multiline = true;
            this.txt_hastatcno.Name = "txt_hastatcno";
            this.txt_hastatcno.Size = new System.Drawing.Size(194, 23);
            this.txt_hastatcno.TabIndex = 46;
            // 
            // lbl_hastatc
            // 
            this.lbl_hastatc.AutoSize = true;
            this.lbl_hastatc.Location = new System.Drawing.Point(132, 329);
            this.lbl_hastatc.Name = "lbl_hastatc";
            this.lbl_hastatc.Size = new System.Drawing.Size(91, 16);
            this.lbl_hastatc.TabIndex = 45;
            this.lbl_hastatc.Text = "Hasta TC No :";
            // 
            // btn_kapat
            // 
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(809, 4);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(70, 53);
            this.btn_kapat.TabIndex = 54;
            this.btn_kapat.Text = "x";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(732, 4);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(61, 56);
            this.btn_geri.TabIndex = 53;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 63);
            this.panel1.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 63);
            this.panel2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.btn_kapat);
            this.panel3.Controls.Add(this.btn_geri);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 63);
            this.panel3.TabIndex = 56;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 514);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(892, 63);
            this.panel4.TabIndex = 56;
            // 
            // SekreterHastaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 577);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_hastatcno);
            this.Controls.Add(this.lbl_hastatc);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.brn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txt_hastatel);
            this.Controls.Add(this.txt_hastasoyad);
            this.Controls.Add(this.txt_hastaad);
            this.Controls.Add(this.txt_hastaid);
            this.Controls.Add(this.lbl_hastatel);
            this.Controls.Add(this.lbl_hastasoyad);
            this.Controls.Add(this.lbl_hastaad);
            this.Controls.Add(this.lbl_hastaid);
            this.Controls.Add(this.dgv_hasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SekreterHastaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterHastaIslemleri";
            this.Load += new System.EventHandler(this.SekreterHastaIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hasta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button brn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TextBox txt_hastatel;
        private System.Windows.Forms.TextBox txt_hastasoyad;
        private System.Windows.Forms.TextBox txt_hastaad;
        private System.Windows.Forms.TextBox txt_hastaid;
        private System.Windows.Forms.Label lbl_hastatel;
        private System.Windows.Forms.Label lbl_hastasoyad;
        private System.Windows.Forms.Label lbl_hastaad;
        private System.Windows.Forms.Label lbl_hastaid;
        private System.Windows.Forms.DataGridView dgv_hasta;
        private System.Windows.Forms.TextBox txt_hastatcno;
        private System.Windows.Forms.Label lbl_hastatc;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}