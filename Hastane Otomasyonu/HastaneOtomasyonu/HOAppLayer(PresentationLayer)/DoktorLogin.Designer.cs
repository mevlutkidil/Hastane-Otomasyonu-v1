namespace HOAppLayer_PresentationLayer_
{
    partial class DoktorLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dokLogin = new System.Windows.Forms.Button();
            this.txt_dokSifre = new System.Windows.Forms.TextBox();
            this.txt_dokUsername = new System.Windows.Forms.TextBox();
            this.cmbx_secilenid = new System.Windows.Forms.ComboBox();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(156, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            // 
            // btn_dokLogin
            // 
            this.btn_dokLogin.BackColor = System.Drawing.Color.Gray;
            this.btn_dokLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dokLogin.FlatAppearance.BorderSize = 0;
            this.btn_dokLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dokLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dokLogin.Location = new System.Drawing.Point(263, 262);
            this.btn_dokLogin.Name = "btn_dokLogin";
            this.btn_dokLogin.Size = new System.Drawing.Size(115, 42);
            this.btn_dokLogin.TabIndex = 8;
            this.btn_dokLogin.Text = "GİRİŞ";
            this.btn_dokLogin.UseVisualStyleBackColor = false;
            this.btn_dokLogin.Click += new System.EventHandler(this.btn_dokLogin_Click);
            this.btn_dokLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_dokLogin_KeyDown);
            // 
            // txt_dokSifre
            // 
            this.txt_dokSifre.Location = new System.Drawing.Point(263, 207);
            this.txt_dokSifre.Multiline = true;
            this.txt_dokSifre.Name = "txt_dokSifre";
            this.txt_dokSifre.PasswordChar = '*';
            this.txt_dokSifre.Size = new System.Drawing.Size(166, 24);
            this.txt_dokSifre.TabIndex = 15;
            this.txt_dokSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dokUsername
            // 
            this.txt_dokUsername.Location = new System.Drawing.Point(263, 159);
            this.txt_dokUsername.Multiline = true;
            this.txt_dokUsername.Name = "txt_dokUsername";
            this.txt_dokUsername.Size = new System.Drawing.Size(166, 24);
            this.txt_dokUsername.TabIndex = 14;
            this.txt_dokUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbx_secilenid
            // 
            this.cmbx_secilenid.FormattingEnabled = true;
            this.cmbx_secilenid.Location = new System.Drawing.Point(263, 106);
            this.cmbx_secilenid.Name = "cmbx_secilenid";
            this.cmbx_secilenid.Size = new System.Drawing.Size(166, 24);
            this.cmbx_secilenid.TabIndex = 16;
            // 
            // btn_kapat
            // 
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(408, 3);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(50, 30);
            this.btn_kapat.TabIndex = 18;
            this.btn_kapat.Text = "x";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(367, 3);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(35, 30);
            this.btn_geri.TabIndex = 17;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Size verilen Id\'yi seçiniz :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_kapat);
            this.panel1.Controls.Add(this.btn_geri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 41);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 41);
            this.panel2.TabIndex = 21;
            // 
            // DoktorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 391);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbx_secilenid);
            this.Controls.Add(this.txt_dokSifre);
            this.Controls.Add(this.txt_dokUsername);
            this.Controls.Add(this.btn_dokLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoktorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoktorLogin";
            this.Load += new System.EventHandler(this.DoktorLogin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_dokLogin;
        private System.Windows.Forms.TextBox txt_dokSifre;
        private System.Windows.Forms.TextBox txt_dokUsername;
        private System.Windows.Forms.ComboBox cmbx_secilenid;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}