namespace HOAppLayer_PresentationLayer_
{
    partial class SekreterAdmin
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
            this.btn_sekreterekle = new System.Windows.Forms.Button();
            this.brn_sekreterguncelle = new System.Windows.Forms.Button();
            this.txt_sekreterusername = new System.Windows.Forms.TextBox();
            this.txt_sekreterid = new System.Windows.Forms.TextBox();
            this.lbl_sekreterusername = new System.Windows.Forms.Label();
            this.lbl_sekreterid = new System.Windows.Forms.Label();
            this.dgv_sekreter = new System.Windows.Forms.DataGridView();
            this.txt_sekretersifre = new System.Windows.Forms.TextBox();
            this.lbl_sekretersifre = new System.Windows.Forms.Label();
            this.btn_sekretersil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sekreter)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sekreterekle
            // 
            this.btn_sekreterekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sekreterekle.Location = new System.Drawing.Point(486, 317);
            this.btn_sekreterekle.Name = "btn_sekreterekle";
            this.btn_sekreterekle.Size = new System.Drawing.Size(164, 32);
            this.btn_sekreterekle.TabIndex = 35;
            this.btn_sekreterekle.Text = "Ekle";
            this.btn_sekreterekle.UseVisualStyleBackColor = true;
            this.btn_sekreterekle.Click += new System.EventHandler(this.btn_sekreterekle_Click);
            // 
            // brn_sekreterguncelle
            // 
            this.brn_sekreterguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brn_sekreterguncelle.Location = new System.Drawing.Point(486, 415);
            this.brn_sekreterguncelle.Name = "brn_sekreterguncelle";
            this.brn_sekreterguncelle.Size = new System.Drawing.Size(164, 32);
            this.brn_sekreterguncelle.TabIndex = 34;
            this.brn_sekreterguncelle.Text = "Güncelle";
            this.brn_sekreterguncelle.UseVisualStyleBackColor = true;
            this.brn_sekreterguncelle.Click += new System.EventHandler(this.brn_sekreterguncelle_Click);
            // 
            // txt_sekreterusername
            // 
            this.txt_sekreterusername.Location = new System.Drawing.Point(308, 370);
            this.txt_sekreterusername.Name = "txt_sekreterusername";
            this.txt_sekreterusername.Size = new System.Drawing.Size(107, 22);
            this.txt_sekreterusername.TabIndex = 33;
            // 
            // txt_sekreterid
            // 
            this.txt_sekreterid.Enabled = false;
            this.txt_sekreterid.Location = new System.Drawing.Point(308, 319);
            this.txt_sekreterid.Name = "txt_sekreterid";
            this.txt_sekreterid.Size = new System.Drawing.Size(107, 22);
            this.txt_sekreterid.TabIndex = 32;
            // 
            // lbl_sekreterusername
            // 
            this.lbl_sekreterusername.AutoSize = true;
            this.lbl_sekreterusername.Location = new System.Drawing.Point(172, 373);
            this.lbl_sekreterusername.Name = "lbl_sekreterusername";
            this.lbl_sekreterusername.Size = new System.Drawing.Size(130, 16);
            this.lbl_sekreterusername.TabIndex = 31;
            this.lbl_sekreterusername.Text = "Sekreter Username :";
            // 
            // lbl_sekreterid
            // 
            this.lbl_sekreterid.AutoSize = true;
            this.lbl_sekreterid.Location = new System.Drawing.Point(172, 325);
            this.lbl_sekreterid.Name = "lbl_sekreterid";
            this.lbl_sekreterid.Size = new System.Drawing.Size(78, 16);
            this.lbl_sekreterid.TabIndex = 30;
            this.lbl_sekreterid.Text = "Sekreter Id :";
            // 
            // dgv_sekreter
            // 
            this.dgv_sekreter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sekreter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sekreter.Location = new System.Drawing.Point(105, 73);
            this.dgv_sekreter.Name = "dgv_sekreter";
            this.dgv_sekreter.ReadOnly = true;
            this.dgv_sekreter.RowHeadersVisible = false;
            this.dgv_sekreter.RowHeadersWidth = 51;
            this.dgv_sekreter.RowTemplate.Height = 24;
            this.dgv_sekreter.Size = new System.Drawing.Size(647, 209);
            this.dgv_sekreter.TabIndex = 29;
            this.dgv_sekreter.SelectionChanged += new System.EventHandler(this.dgv_sekreter_SelectionChanged);
            // 
            // txt_sekretersifre
            // 
            this.txt_sekretersifre.Location = new System.Drawing.Point(308, 420);
            this.txt_sekretersifre.Name = "txt_sekretersifre";
            this.txt_sekretersifre.Size = new System.Drawing.Size(107, 22);
            this.txt_sekretersifre.TabIndex = 37;
            // 
            // lbl_sekretersifre
            // 
            this.lbl_sekretersifre.AutoSize = true;
            this.lbl_sekretersifre.Location = new System.Drawing.Point(172, 423);
            this.lbl_sekretersifre.Name = "lbl_sekretersifre";
            this.lbl_sekretersifre.Size = new System.Drawing.Size(94, 16);
            this.lbl_sekretersifre.TabIndex = 36;
            this.lbl_sekretersifre.Text = "Sekreter Sifre :";
            // 
            // btn_sekretersil
            // 
            this.btn_sekretersil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sekretersil.Location = new System.Drawing.Point(486, 365);
            this.btn_sekretersil.Name = "btn_sekretersil";
            this.btn_sekretersil.Size = new System.Drawing.Size(164, 32);
            this.btn_sekretersil.TabIndex = 38;
            this.btn_sekretersil.Text = "Sil";
            this.btn_sekretersil.UseVisualStyleBackColor = true;
            this.btn_sekretersil.Click += new System.EventHandler(this.btn_sekretersil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btn_kapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 43);
            this.panel1.TabIndex = 53;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(764, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 34);
            this.btnBack.TabIndex = 54;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(809, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 34);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(1141, 3);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(65, 30);
            this.btn_kapat.TabIndex = 20;
            this.btn_kapat.Text = "x";
            this.btn_kapat.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 43);
            this.panel2.TabIndex = 54;
            // 
            // SekreterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sekretersil);
            this.Controls.Add(this.txt_sekretersifre);
            this.Controls.Add(this.lbl_sekretersifre);
            this.Controls.Add(this.btn_sekreterekle);
            this.Controls.Add(this.brn_sekreterguncelle);
            this.Controls.Add(this.txt_sekreterusername);
            this.Controls.Add(this.txt_sekreterid);
            this.Controls.Add(this.lbl_sekreterusername);
            this.Controls.Add(this.lbl_sekreterid);
            this.Controls.Add(this.dgv_sekreter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SekreterAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterAdmin";
            this.Load += new System.EventHandler(this.SekreterAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sekreter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sekreterekle;
        private System.Windows.Forms.Button brn_sekreterguncelle;
        private System.Windows.Forms.TextBox txt_sekreterusername;
        private System.Windows.Forms.TextBox txt_sekreterid;
        private System.Windows.Forms.Label lbl_sekreterusername;
        private System.Windows.Forms.Label lbl_sekreterid;
        private System.Windows.Forms.DataGridView dgv_sekreter;
        private System.Windows.Forms.TextBox txt_sekretersifre;
        private System.Windows.Forms.Label lbl_sekretersifre;
        private System.Windows.Forms.Button btn_sekretersil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
    }
}