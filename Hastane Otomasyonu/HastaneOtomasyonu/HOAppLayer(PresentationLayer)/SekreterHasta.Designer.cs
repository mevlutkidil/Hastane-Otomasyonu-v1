namespace HOAppLayer_PresentationLayer_
{
    partial class SekreterHasta
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
            this.btn_hastacrud = new System.Windows.Forms.Button();
            this.btn_randevuver = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_chartlaragit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_hastacrud
            // 
            this.btn_hastacrud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastacrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hastacrud.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastacrud.Location = new System.Drawing.Point(60, 141);
            this.btn_hastacrud.Name = "btn_hastacrud";
            this.btn_hastacrud.Size = new System.Drawing.Size(194, 152);
            this.btn_hastacrud.TabIndex = 0;
            this.btn_hastacrud.Text = "Hasta Islemleri";
            this.btn_hastacrud.UseVisualStyleBackColor = true;
            this.btn_hastacrud.Click += new System.EventHandler(this.btn_hastacrud_Click);
            // 
            // btn_randevuver
            // 
            this.btn_randevuver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_randevuver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_randevuver.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevuver.Location = new System.Drawing.Point(297, 141);
            this.btn_randevuver.Name = "btn_randevuver";
            this.btn_randevuver.Size = new System.Drawing.Size(194, 152);
            this.btn_randevuver.TabIndex = 1;
            this.btn_randevuver.Text = "Randevu Oluştur";
            this.btn_randevuver.UseVisualStyleBackColor = true;
            this.btn_randevuver.Click += new System.EventHandler(this.btn_randevuver_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(750, 0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(50, 30);
            this.btn_kapat.TabIndex = 17;
            this.btn_kapat.Text = "x";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(709, 0);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(35, 30);
            this.btn_geri.TabIndex = 16;
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
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 53);
            this.panel2.TabIndex = 19;
            // 
            // btn_chartlaragit
            // 
            this.btn_chartlaragit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chartlaragit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chartlaragit.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_chartlaragit.Location = new System.Drawing.Point(531, 141);
            this.btn_chartlaragit.Name = "btn_chartlaragit";
            this.btn_chartlaragit.Size = new System.Drawing.Size(194, 152);
            this.btn_chartlaragit.TabIndex = 20;
            this.btn_chartlaragit.Text = "Grafikleri Göster";
            this.btn_chartlaragit.UseVisualStyleBackColor = true;
            this.btn_chartlaragit.Click += new System.EventHandler(this.btn_chartlaragit_Click);
            // 
            // SekreterHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_chartlaragit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_randevuver);
            this.Controls.Add(this.btn_hastacrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SekreterHasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterHasta";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hastacrud;
        private System.Windows.Forms.Button btn_randevuver;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_chartlaragit;
    }
}