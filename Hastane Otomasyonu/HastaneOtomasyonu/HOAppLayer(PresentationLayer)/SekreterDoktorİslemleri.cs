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
    public partial class SekreterDoktorİslemleri : Form
    {
        public SekreterDoktorİslemleri()
        {
            InitializeComponent();
        }
        private void DoktorlarıListele()
        {
            dgv_doktor.DataSource = DoktorManager.DoktorList();

        }
        private void BranslariListele()
        {
            dgv_brans.DataSource = BransManager.BransList();
        }
        private void SekreterDoktorİslemleri_Load(object sender, EventArgs e)
        {
            DoktorlarıListele();
            SekreterManager.BranslariGetirme(cmbx_brans);
            BranslariListele();
        }

        private void btn_doktorekle_Click(object sender, EventArgs e)
        {
            if (txt_doktorad.Text != "" && txt_doktorsoyad.Text != "" && txt_doktortel.Text != "" && cmbx_brans.Text != ""
                && txt_doktorusername.Text != "" && txt_doktorsifre.Text != "")
            {
                Doktor ndoktor = new Doktor()
                {   
                    DoktorAd = txt_doktorad.Text,
                    DoktorSoyad = txt_doktorsoyad.Text,
                    DoktorTel = txt_doktortel.Text,
                    BransId = Convert.ToInt32(cmbx_brans.Text),
                    DoktorUsername = txt_doktorusername.Text,
                    DoktorSifre = txt_doktorsifre.Text,
                };
                DoktorManager.DoktorEkleme(ndoktor);
                DoktorlarıListele();
                MessageBox.Show("Yeni Doktor Kayıdı Yapıldı", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Eksik yada hatalı bilgi girildi.", "Ekleme işlemi yapılamadı.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brn_doktorsil_Click(object sender, EventArgs e)
        {

            Doktor sdoktor = new Doktor()
            {
                DoktorId = Convert.ToInt32(txt_doktorid.Text)
            };
            DoktorManager.DoktorSilme(sdoktor);
            DoktorlarıListele();
            MessageBox.Show(" Doktor Kayıdı Silindi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void dgv_doktor_SelectionChanged(object sender, EventArgs e)
        {
            txt_doktorid.Text = (string)dgv_doktor.CurrentRow.Cells[0].Value.ToString();
            txt_doktorad.Text = dgv_doktor.CurrentRow.Cells[1].Value.ToString();
            txt_doktorsoyad.Text = dgv_doktor.CurrentRow.Cells[2].Value.ToString();
            txt_doktortel.Text = dgv_doktor.CurrentRow.Cells[3].Value.ToString();
            cmbx_brans.Text = dgv_doktor.CurrentRow.Cells[6].Value.ToString();
            txt_doktorusername.Text = dgv_doktor.CurrentRow.Cells[4].Value.ToString();
            txt_doktorsifre.Text = dgv_doktor.CurrentRow.Cells[5].Value.ToString();

        }

        private void btn_doktorguncelle_Click(object sender, EventArgs e)
        {
            Doktor gdoktor = new Doktor()
            {
                DoktorAd = txt_doktorad.Text,
                DoktorSoyad = txt_doktorsoyad.Text,
                DoktorTel = txt_doktortel.Text,
                BransId = Convert.ToInt32(cmbx_brans.Text),
                DoktorUsername = txt_doktorusername.Text,
                DoktorSifre = txt_doktorsifre.Text,
                DoktorId = Convert.ToInt32(txt_doktorid.Text)
            };
            DoktorManager.DoktorGüncelleme( gdoktor );
            DoktorlarıListele();
            MessageBox.Show(" Doktor Kayıdı Güncellendi", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            SekreterPanel sekreterPanel = new SekreterPanel();
            sekreterPanel.Show() ;
            this.Hide();
        }
    }
}
