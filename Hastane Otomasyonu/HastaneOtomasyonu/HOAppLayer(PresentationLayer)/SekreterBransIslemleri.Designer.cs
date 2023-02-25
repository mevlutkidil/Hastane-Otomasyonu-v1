namespace HOAppLayer_PresentationLayer_
{
    partial class SekreterBransIslemleri
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
            this.dgv_brans = new System.Windows.Forms.DataGridView();
            this.txt_bransadi = new System.Windows.Forms.TextBox();
            this.txt_bransid = new System.Windows.Forms.TextBox();
            this.lbl_bransad = new System.Windows.Forms.Label();
            this.lbl_bransid = new System.Windows.Forms.Label();
            this.btn_bransekle = new System.Windows.Forms.Button();
            this.brn_branssil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brans)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_brans
            // 
            this.dgv_brans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_brans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_brans.Location = new System.Drawing.Point(99, 66);
            this.dgv_brans.Name = "dgv_brans";
            this.dgv_brans.ReadOnly = true;
            this.dgv_brans.RowHeadersVisible = false;
            this.dgv_brans.RowHeadersWidth = 51;
            this.dgv_brans.RowTemplate.Height = 24;
            this.dgv_brans.Size = new System.Drawing.Size(685, 209);
            this.dgv_brans.TabIndex = 0;
            this.dgv_brans.SelectionChanged += new System.EventHandler(this.dgv_brans_SelectionChanged);
            // 
            // txt_bransadi
            // 
            this.txt_bransadi.Location = new System.Drawing.Point(254, 371);
            this.txt_bransadi.Name = "txt_bransadi";
            this.txt_bransadi.Size = new System.Drawing.Size(121, 22);
            this.txt_bransadi.TabIndex = 12;
            // 
            // txt_bransid
            // 
            this.txt_bransid.Enabled = false;
            this.txt_bransid.Location = new System.Drawing.Point(254, 319);
            this.txt_bransid.Name = "txt_bransid";
            this.txt_bransid.Size = new System.Drawing.Size(121, 22);
            this.txt_bransid.TabIndex = 11;
            // 
            // lbl_bransad
            // 
            this.lbl_bransad.AutoSize = true;
            this.lbl_bransad.Location = new System.Drawing.Point(173, 374);
            this.lbl_bransad.Name = "lbl_bransad";
            this.lbl_bransad.Size = new System.Drawing.Size(71, 16);
            this.lbl_bransad.TabIndex = 10;
            this.lbl_bransad.Text = "Branş Adı :";
            // 
            // lbl_bransid
            // 
            this.lbl_bransid.AutoSize = true;
            this.lbl_bransid.Location = new System.Drawing.Point(173, 322);
            this.lbl_bransid.Name = "lbl_bransid";
            this.lbl_bransid.Size = new System.Drawing.Size(62, 16);
            this.lbl_bransid.TabIndex = 9;
            this.lbl_bransid.Text = "Branş Id :";
            // 
            // btn_bransekle
            // 
            this.btn_bransekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bransekle.Location = new System.Drawing.Point(474, 364);
            this.btn_bransekle.Name = "btn_bransekle";
            this.btn_bransekle.Size = new System.Drawing.Size(170, 36);
            this.btn_bransekle.TabIndex = 28;
            this.btn_bransekle.Text = "Ekle";
            this.btn_bransekle.UseVisualStyleBackColor = true;
            this.btn_bransekle.Click += new System.EventHandler(this.btn_bransekle_Click);
            // 
            // brn_branssil
            // 
            this.brn_branssil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brn_branssil.Location = new System.Drawing.Point(474, 315);
            this.brn_branssil.Name = "brn_branssil";
            this.brn_branssil.Size = new System.Drawing.Size(170, 36);
            this.brn_branssil.TabIndex = 27;
            this.brn_branssil.Text = "Sil";
            this.brn_branssil.UseVisualStyleBackColor = true;
            this.brn_branssil.Click += new System.EventHandler(this.brn_branssil_Click);
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
            this.panel1.Size = new System.Drawing.Size(897, 43);
            this.panel1.TabIndex = 53;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(784, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 34);
            this.btnBack.TabIndex = 55;
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
            this.btnClose.Location = new System.Drawing.Point(829, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 30);
            this.btnClose.TabIndex = 21;
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 43);
            this.panel2.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1141, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SekreterBransIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_bransekle);
            this.Controls.Add(this.brn_branssil);
            this.Controls.Add(this.txt_bransadi);
            this.Controls.Add(this.txt_bransid);
            this.Controls.Add(this.lbl_bransad);
            this.Controls.Add(this.lbl_bransid);
            this.Controls.Add(this.dgv_brans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SekreterBransIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterBransIslemleri";
            this.Load += new System.EventHandler(this.SekreterBransIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brans)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_brans;
        private System.Windows.Forms.TextBox txt_bransadi;
        private System.Windows.Forms.TextBox txt_bransid;
        private System.Windows.Forms.Label lbl_bransad;
        private System.Windows.Forms.Label lbl_bransid;
        private System.Windows.Forms.Button btn_bransekle;
        private System.Windows.Forms.Button brn_branssil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
    }
}