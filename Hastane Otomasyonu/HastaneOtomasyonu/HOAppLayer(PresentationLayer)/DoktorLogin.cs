using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOAppLayer_PresentationLayer_
{
    public partial class DoktorLogin : Form
    {
        public DoktorLogin()
        {
            InitializeComponent();
        }

        private void btn_dokLogin_Click(object sender, EventArgs e)
        {
            //Doktordan bir nesne türeterek girilecek bilgileirin kontrolü için kullanacağız 
            Doktor ndoktor = new Doktor()
            {
                DoktorId = Convert.ToInt32(cmbx_secilenid.Text),
                DoktorUsername = txt_dokUsername.Text,
                DoktorSifre = txt_dokSifre.Text
            };
            if (DoktorManager.DoktorGirisKontrol(ndoktor) == true)
            {
                DoktorPanelHasta doktorpanelhasta = new DoktorPanelHasta();
                doktorpanelhasta.doktorfiltre=cmbx_secilenid.SelectedItem.ToString();
                doktorpanelhasta.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyiniz...", "Doğru seçeneği seçtiğinizden emin olunuz!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_dokLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btn_dokLogin_Click(sender, e);
            }
        }

        private void DoktorLogin_Load(object sender, EventArgs e)
        {
            DoktorManager.DoktorlariGetirme(cmbx_secilenid);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel= new LoginPanel();
            loginPanel.Show();
            this.Hide();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
