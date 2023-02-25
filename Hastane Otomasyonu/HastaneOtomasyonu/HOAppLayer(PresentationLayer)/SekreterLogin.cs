using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;

namespace HOAppLayer_PresentationLayer_
{
    public partial class SekreterLogin : Form
    {
        public SekreterLogin()
        {
            InitializeComponent();
        }

        private void btn_SekGiris_Click(object sender, EventArgs e)
        {
            Sekreter nsekreter = new Sekreter()
            {
                SekreterUsername = txt_SekUsername.Text,
                SekreterSifre = txt_SekSifre.Text
            };

            if (SekreterManager.SekreterGirisKontrol(nsekreter) == true)
            {
                SekreterPanel sekreterPanel = new SekreterPanel();
                sekreterPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyiniz...", "Doğru seçeneği seçtiğinizden emin olunuz!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            LoginPanel loginpanel =new LoginPanel();
            loginpanel.Show();
            this.Hide();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
