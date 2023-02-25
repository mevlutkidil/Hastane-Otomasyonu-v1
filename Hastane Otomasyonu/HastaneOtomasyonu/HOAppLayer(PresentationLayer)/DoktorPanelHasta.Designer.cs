namespace HOAppLayer_PresentationLayer_
{
    partial class DoktorPanelHasta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hastaid = new System.Windows.Forms.TextBox();
            this.txt_hastaad = new System.Windows.Forms.TextBox();
            this.txt_hastasoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hastatel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_muayeneyegit = new System.Windows.Forms.Button();
            this.txt_hastatcno = new System.Windows.Forms.TextBox();
            this.lbl_hastatc = new System.Windows.Forms.Label();
            this.txt_doktorfiltre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_hastalar = new System.Windows.Forms.DataGridView();
            this.txt_tblhastaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_bransid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_muayenetime = new System.Windows.Forms.TextBox();
            this.txt_doktorid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_randevuid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_doktor
            // 
            this.dgv_doktor.AllowUserToAddRows = false;
            this.dgv_doktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doktor.Location = new System.Drawing.Point(43, 75);
            this.dgv_doktor.Name = "dgv_doktor";
            this.dgv_doktor.ReadOnly = true;
            this.dgv_doktor.RowHeadersVisible = false;
            this.dgv_doktor.RowHeadersWidth = 51;
            this.dgv_doktor.RowTemplate.Height = 24;
            this.dgv_doktor.Size = new System.Drawing.Size(491, 176);
            this.dgv_doktor.TabIndex = 5;
            this.dgv_doktor.SelectionChanged += new System.EventHandler(this.dgv_doktor_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta Soyad:";
            // 
            // txt_hastaid
            // 
            this.txt_hastaid.Enabled = false;
            this.txt_hastaid.Location = new System.Drawing.Point(715, 273);
            this.txt_hastaid.Name = "txt_hastaid";
            this.txt_hastaid.Size = new System.Drawing.Size(153, 22);
            this.txt_hastaid.TabIndex = 7;
            // 
            // txt_hastaad
            // 
            this.txt_hastaad.Enabled = false;
            this.txt_hastaad.Location = new System.Drawing.Point(715, 346);
            this.txt_hastaad.Name = "txt_hastaad";
            this.txt_hastaad.Size = new System.Drawing.Size(153, 22);
            this.txt_hastaad.TabIndex = 8;
            // 
            // txt_hastasoyad
            // 
            this.txt_hastasoyad.Enabled = false;
            this.txt_hastasoyad.Location = new System.Drawing.Point(715, 391);
            this.txt_hastasoyad.Name = "txt_hastasoyad";
            this.txt_hastasoyad.Size = new System.Drawing.Size(153, 22);
            this.txt_hastasoyad.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Randevular";
            // 
            // txt_hastatel
            // 
            this.txt_hastatel.Enabled = false;
            this.txt_hastatel.Location = new System.Drawing.Point(715, 432);
            this.txt_hastatel.Name = "txt_hastatel";
            this.txt_hastatel.Size = new System.Drawing.Size(153, 22);
            this.txt_hastatel.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hasta Telefon No :";
            // 
            // btn_muayeneyegit
            // 
            this.btn_muayeneyegit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_muayeneyegit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muayeneyegit.Location = new System.Drawing.Point(930, 332);
            this.btn_muayeneyegit.Name = "btn_muayeneyegit";
            this.btn_muayeneyegit.Size = new System.Drawing.Size(133, 134);
            this.btn_muayeneyegit.TabIndex = 13;
            this.btn_muayeneyegit.Text = "Hastanın Randevusunu Aç";
            this.btn_muayeneyegit.UseVisualStyleBackColor = true;
            this.btn_muayeneyegit.Click += new System.EventHandler(this.btn_muayeneyegit_Click);
            // 
            // txt_hastatcno
            // 
            this.txt_hastatcno.Enabled = false;
            this.txt_hastatcno.Location = new System.Drawing.Point(715, 308);
            this.txt_hastatcno.Multiline = true;
            this.txt_hastatcno.Name = "txt_hastatcno";
            this.txt_hastatcno.Size = new System.Drawing.Size(153, 22);
            this.txt_hastatcno.TabIndex = 48;
            // 
            // lbl_hastatc
            // 
            this.lbl_hastatc.AutoSize = true;
            this.lbl_hastatc.Location = new System.Drawing.Point(569, 317);
            this.lbl_hastatc.Name = "lbl_hastatc";
            this.lbl_hastatc.Size = new System.Drawing.Size(91, 16);
            this.lbl_hastatc.TabIndex = 47;
            this.lbl_hastatc.Text = "Hasta TC No :";
            // 
            // txt_doktorfiltre
            // 
            this.txt_doktorfiltre.Location = new System.Drawing.Point(0, 140);
            this.txt_doktorfiltre.Name = "txt_doktorfiltre";
            this.txt_doktorfiltre.Size = new System.Drawing.Size(40, 22);
            this.txt_doktorfiltre.TabIndex = 50;
            this.txt_doktorfiltre.Visible = false;
            this.txt_doktorfiltre.TextChanged += new System.EventHandler(this.txt_doktorfiltre_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_kapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 54);
            this.panel1.TabIndex = 51;
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(1019, 0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(81, 51);
            this.btn_kapat.TabIndex = 20;
            this.btn_kapat.Text = "x";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 54);
            this.panel2.TabIndex = 52;
            // 
            // dgv_hastalar
            // 
            this.dgv_hastalar.AllowUserToAddRows = false;
            this.dgv_hastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hastalar.Location = new System.Drawing.Point(572, 75);
            this.dgv_hastalar.Name = "dgv_hastalar";
            this.dgv_hastalar.ReadOnly = true;
            this.dgv_hastalar.RowHeadersVisible = false;
            this.dgv_hastalar.RowHeadersWidth = 51;
            this.dgv_hastalar.RowTemplate.Height = 24;
            this.dgv_hastalar.Size = new System.Drawing.Size(491, 176);
            this.dgv_hastalar.TabIndex = 53;
            this.dgv_hastalar.SelectionChanged += new System.EventHandler(this.dgv_hastalar_SelectionChanged);
            // 
            // txt_tblhastaid
            // 
            this.txt_tblhastaid.Enabled = false;
            this.txt_tblhastaid.Location = new System.Drawing.Point(161, 311);
            this.txt_tblhastaid.Multiline = true;
            this.txt_tblhastaid.Name = "txt_tblhastaid";
            this.txt_tblhastaid.Size = new System.Drawing.Size(153, 22);
            this.txt_tblhastaid.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Hasta ID :";
            // 
            // txt_bransid
            // 
            this.txt_bransid.Enabled = false;
            this.txt_bransid.Location = new System.Drawing.Point(161, 429);
            this.txt_bransid.Name = "txt_bransid";
            this.txt_bransid.Size = new System.Drawing.Size(153, 22);
            this.txt_bransid.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Brans ID :";
            // 
            // txt_muayenetime
            // 
            this.txt_muayenetime.Enabled = false;
            this.txt_muayenetime.Location = new System.Drawing.Point(161, 391);
            this.txt_muayenetime.Name = "txt_muayenetime";
            this.txt_muayenetime.Size = new System.Drawing.Size(153, 22);
            this.txt_muayenetime.TabIndex = 59;
            // 
            // txt_doktorid
            // 
            this.txt_doktorid.Enabled = false;
            this.txt_doktorid.Location = new System.Drawing.Point(161, 348);
            this.txt_doktorid.Name = "txt_doktorid";
            this.txt_doktorid.Size = new System.Drawing.Size(153, 22);
            this.txt_doktorid.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Doktor ID :";
            // 
            // txt_randevuid
            // 
            this.txt_randevuid.Enabled = false;
            this.txt_randevuid.Location = new System.Drawing.Point(161, 273);
            this.txt_randevuid.Name = "txt_randevuid";
            this.txt_randevuid.Size = new System.Drawing.Size(153, 22);
            this.txt_randevuid.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Randevu ID :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 56;
            this.label10.Text = "Muayene Zamanı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(569, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 65;
            this.label11.Text = "Hastalar";
            // 
            // DoktorPanelHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 569);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_tblhastaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_bransid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_muayenetime);
            this.Controls.Add(this.txt_doktorid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_randevuid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_hastalar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_doktorfiltre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_hastatcno);
            this.Controls.Add(this.lbl_hastatc);
            this.Controls.Add(this.btn_muayeneyegit);
            this.Controls.Add(this.txt_hastatel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_hastasoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_doktor);
            this.Controls.Add(this.txt_hastaad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_hastaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoktorPanelHasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoktorPanelHasta";
            this.Load += new System.EventHandler(this.DoktorPanelHasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktor)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_doktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_hastaid;
        private System.Windows.Forms.TextBox txt_hastaad;
        private System.Windows.Forms.TextBox txt_hastasoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hastatel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_muayeneyegit;
        private System.Windows.Forms.TextBox txt_hastatcno;
        private System.Windows.Forms.Label lbl_hastatc;
        private System.Windows.Forms.TextBox txt_doktorfiltre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.DataGridView dgv_hastalar;
        private System.Windows.Forms.TextBox txt_tblhastaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bransid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_muayenetime;
        private System.Windows.Forms.TextBox txt_doktorid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_randevuid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}