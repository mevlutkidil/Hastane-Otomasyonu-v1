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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOAppLayer_PresentationLayer_
{
    public partial class RandevuVerme : Form
    {
        public RandevuVerme()
        {
            InitializeComponent();
        }
        private void btn_randevuver_Click(object sender, EventArgs e)
        {
            if (txt_hastaid.Text != null  && cmbx_brans.Text != null && cmbx_doktor.Text != null && dtp_randevu.Text != null)
            {
                Randevu nran = new Randevu()
                {
                    HastaId = Convert.ToInt32(txt_hastaid.Text),
                    
                    BransId = Convert.ToInt32(cmbx_brans.Text),
                    DoktorId = Convert.ToInt32(cmbx_doktor.Text),
                    MuayeneTime = DateTime.Parse(dtp_randevu.Text)
                    
                };
                RandevuManager.RandevuEkleme(nran);
                RandevuListeleme();
                MessageBox.Show("Yeni Randevu Kayıdı Yapıldı", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Eksik yada hatalı bilgi girildi.", "Randevu alma işlemi yapılamadı.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HastaListeleme()
        {
            dgv_hastalar.DataSource = HastaManager.HastaList();

        }
        private void RandevuListeleme()
        {
            dgv_randevular.DataSource = RandevuManager.RandevuList();
            dgv_randevular.Columns["MuayeneNot"].Visible = false;

        }
        private void DoktorListeleme()
        {
            dgv_doktor.DataSource = DoktorManager.DoktorList();
            
            dgv_doktor.Columns["DoktorUsername"].Visible = false;
            dgv_doktor.Columns["DoktorSifre"].Visible = false;
            dgv_doktor.Columns["DoktorTel"].Visible = false;
        }
        private void BransListeleme()
        {
            dgv_brans.DataSource = BransManager.BransList();
        }
        private void DoktorComboboxListeleme()
        {
            DoktorManager.DoktorlariGetirme(cmbx_doktor);
        }
        private void BransComboboxListeleme()
        {
            BransManager.BranslariGetirme(cmbx_brans);
        }
        private void RandevuVerme_Load(object sender, EventArgs e)
        {
            BransComboboxListeleme();
            BransListeleme();
            DoktorListeleme();
            HastaListeleme();
            RandevuListeleme();
            DoktorComboboxListeleme();
        }

        private void dgv_brans_SelectionChanged(object sender, EventArgs e)
        {
            txt_hastaad.Text = dgv_hastalar.CurrentRow.Cells["HastaAd"].Value.ToString();
            txt_hastaid.Text = dgv_hastalar.CurrentRow.Cells["HastaId"].Value.ToString();
            txt_hastasoyad.Text = dgv_hastalar.CurrentRow.Cells["HastaSoyad"].Value.ToString();
            txt_hastatel.Text = dgv_hastalar.CurrentRow.Cells["HastaTel"].Value.ToString();
            txt_hastatcno.Text = dgv_hastalar.CurrentRow.Cells["HastaTCNo"].Value.ToString();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            SekreterHasta sekreterhasta = new SekreterHasta();
            sekreterhasta.Show();
            this.Hide();
        }
    }
}
