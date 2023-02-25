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
    public partial class SekreterBransIslemleri : Form
    {
        public SekreterBransIslemleri()
        {
            InitializeComponent();
        }
        private void BransListeleme()
        {
            dgv_brans.DataSource = BransManager.BransList();

        }

        private void SekreterBransIslemleri_Load(object sender, EventArgs e)
        {
            BransListeleme();
        }

        private void dgv_brans_SelectionChanged(object sender, EventArgs e)
        {
            txt_bransid.Text = (string)dgv_brans.CurrentRow.Cells[0].Value.ToString();
            txt_bransadi.Text = dgv_brans.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_bransekle_Click(object sender, EventArgs e)
        {
            if (txt_bransadi.Text != "" )
            {
                Brans nbrans = new Brans()
                {
                    BransAd = txt_bransadi.Text
                };
                BransManager.BransEkleme(nbrans);
                BransListeleme();
                MessageBox.Show("Yeni Brans Kayıdı Yapıldı", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Eksik yada hatalı bilgi girildi.", "Ekleme işlemi yapılamadı.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void brn_branssil_Click(object sender, EventArgs e)
        {
            Brans sbrans = new Brans()
            {
                BransId = Convert.ToInt32(txt_bransid.Text)
            };
            BransManager.BransSilme(sbrans);
            BransListeleme();
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
