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
    public partial class SekreterHastaIslemleri : Form
    {
        public SekreterHastaIslemleri()
        {
            InitializeComponent();
        }
        private void HastalarıListele()
        {
            dgv_hasta.DataSource = HastaManager.HastaList();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Hasta ghasta = new Hasta()
            {
                HastaId = Convert.ToInt32(txt_hastaid.Text),
                HastaTCNo = txt_hastatcno.Text,
                HastaAd = txt_hastaad.Text,
                HastaSoyad = txt_hastasoyad.Text,
                HastaTel = txt_hastatel.Text
               
            };
            HastaManager.HastaGüncelleme(ghasta);
            HastalarıListele();
            MessageBox.Show(" Hasta Kayıdı Güncellendi", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void brn_sil_Click(object sender, EventArgs e)
        {

            Hasta shasta = new Hasta()
            {
                HastaId = Convert.ToInt32(txt_hastaid.Text)
            };
            HastaManager.HastaSilme(shasta);
            HastalarıListele();
            MessageBox.Show(" Hasta Kayıdı Silindi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_hastatcno.Text != "" && txt_hastaad.Text != "" &&  txt_hastasoyad.Text != "" && txt_hastatel.Text != ""  )
            {
                Hasta nhasta = new Hasta()
                {
                    HastaTCNo = txt_hastatcno.Text,
                    HastaAd = txt_hastaad.Text,
                    HastaSoyad = txt_hastasoyad.Text,
                    HastaTel = txt_hastatel.Text,
                };
                HastaManager.HastaEkleme(nhasta);
                HastalarıListele();
                MessageBox.Show("Yeni Hasta Kayıdı Yapıldı", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Eksik yada hatalı bilgi girildi.", "Ekleme işlemi yapılamadı.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SekreterHastaIslemleri_Load(object sender, EventArgs e)
        {
            HastalarıListele();
        }

        private void dgv_hasta_SelectionChanged(object sender, EventArgs e)
        {
            txt_hastaid.Text = (string)dgv_hasta.CurrentRow.Cells["HastaId"].Value.ToString();
            txt_hastaad.Text = dgv_hasta.CurrentRow.Cells["HastaAd"].Value.ToString();
            txt_hastatcno.Text = dgv_hasta.CurrentRow.Cells["HastaTCNo"].Value.ToString();
            txt_hastasoyad.Text = dgv_hasta.CurrentRow.Cells["HastaSoyad"].Value.ToString();
            txt_hastatel.Text = dgv_hasta.CurrentRow.Cells["HastaTel"].Value.ToString();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            SekreterHasta sekPanel = new SekreterHasta();
            sekPanel.Show();
            this.Hide();
        }
    }
}
