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
    public partial class SekreterAdmin : Form
    {
        public SekreterAdmin()
        {
            InitializeComponent();
        }

        private void SekreterListeleme()
        {
            dgv_sekreter.DataSource = SekreterManager.SekreterList();
        }

        private void SekreterAdmin_Load(object sender, EventArgs e)
        {
            SekreterListeleme();
        }

        private void dgv_sekreter_SelectionChanged(object sender, EventArgs e)
        {
            txt_sekreterid.Text = (string)dgv_sekreter.CurrentRow.Cells[0].Value.ToString();
            txt_sekreterusername.Text = dgv_sekreter.CurrentRow.Cells[1].Value.ToString();
            txt_sekretersifre.Text = dgv_sekreter.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_sekreterekle_Click(object sender, EventArgs e)
        {
            if (txt_sekreterusername.Text != ""&& txt_sekretersifre.Text!="")
            {
                Sekreter nsekreter = new Sekreter()
                {
                    SekreterUsername = txt_sekreterusername.Text,
                    SekreterSifre = txt_sekretersifre.Text
                };
                SekreterManager.SekreterEkleme(nsekreter);
                SekreterListeleme();
                MessageBox.Show("Yeni Sekreter Kayıdı Yapıldı", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Eksik yada hatalı bilgi girildi.", "Ekleme işlemi yapılamadı.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sekretersil_Click(object sender, EventArgs e)
        {
            Sekreter ssekreter = new Sekreter()
            {
                SekreterId = Convert.ToInt32(txt_sekreterid.Text)
            };
            SekreterManager.SekreterSilme(ssekreter);
            SekreterListeleme();
            MessageBox.Show(" Sekreter Kayıdı Silindi", "Sime İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void brn_sekreterguncelle_Click(object sender, EventArgs e)
        {
           
            
                Sekreter gsekreter = new Sekreter()
                {
                    SekreterUsername = txt_sekreterusername.Text,
                    SekreterSifre = txt_sekretersifre.Text,
                    SekreterId = Convert.ToInt32(txt_sekreterid.Text)
                };
                SekreterManager.SekreterGüncelleme(gsekreter);
                SekreterListeleme();
                MessageBox.Show(" Sekreter Kayıdı Güncellendi", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SekreterPanel sekPanel = new SekreterPanel();
            sekPanel.Show();
            this.Hide();
        }
    }
}
