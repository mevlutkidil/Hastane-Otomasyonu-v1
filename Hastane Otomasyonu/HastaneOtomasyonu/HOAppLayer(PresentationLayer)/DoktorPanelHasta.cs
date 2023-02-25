using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOAppLayer_PresentationLayer_
{
    public partial class DoktorPanelHasta : Form
    {
        
        public DoktorPanelHasta()
        {
            InitializeComponent();
        }
       
        public string doktorfiltre;
       

        private void RandeuvuListele()
        {
            dgv_doktor.DataSource = RandevuManager.RandevuList();
        }
        private void HastaListeleme()
        {
            dgv_hastalar.DataSource = HastaManager.HastaList();
        }

        private void DoktorPanelHasta_Load(object sender, EventArgs e)
        {
            RandeuvuListele();
            HastaListeleme();
            txt_doktorfiltre.Text = doktorfiltre;
            MessageBox.Show("Randevular Tablosundan Kırmızı ile işaretli alanlar sizin randevularınızdır. Lütfen başka randevu ile işlem yapmayınız.","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        
        private void dgv_doktor_SelectionChanged(object sender, EventArgs e)
        {
            txt_randevuid.Text = dgv_doktor.CurrentRow.Cells["RandevuId"].Value.ToString();
            txt_tblhastaid.Text = dgv_doktor.CurrentRow.Cells["HastaId"].Value.ToString();
            txt_doktorid.Text = dgv_doktor.CurrentRow.Cells["DoktorId"].Value.ToString();
            txt_muayenetime.Text = dgv_doktor.CurrentRow.Cells["MuayeneTime"].Value.ToString();
            txt_bransid.Text = dgv_doktor.CurrentRow.Cells["BransId"].Value.ToString();
            
            
        }


        private void btn_muayeneyegit_Click(object sender, EventArgs e)
        {
            HastaRandevuPanel randevuPanel = new HastaRandevuPanel();

            randevuPanel.gelenhastaid = txt_hastaid.Text;
            randevuPanel.gelenhastaad = txt_hastaad.Text;
            randevuPanel.gelenhastasoyad = txt_hastasoyad.Text;
            randevuPanel.gelenhastatel = txt_hastatel.Text;
            randevuPanel.gelenhastatc = txt_hastatcno.Text;
            randevuPanel.gelenbransid = txt_bransid.Text;
            randevuPanel.gelenrandevuid = txt_randevuid.Text;
            randevuPanel.gelendoktorid=txt_doktorid.Text;
            randevuPanel.gelenmuayenenotu = dgv_doktor.CurrentRow.Cells["MuayeneNot"].Value.ToString();
            MessageBox.Show("Not kısımına varsa tahlil sonuçlarındaki negatif değerleri değerleri ile birlikte yazınız.","DİKKAT!",MessageBoxButtons.OK,MessageBoxIcon.Warning);



            if (txt_tblhastaid.Text==txt_hastaid.Text)
            {
               
                randevuPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hastayı yanlış seçtiniz." ,"Lütfen seçiminizi kontrol ediniz.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






            
        }
        
        
        private void txt_doktorfiltre_TextChanged(object sender, EventArgs e)
        {
            string gelendoktorid = txt_doktorfiltre.Text;
            for (int i = 0; i <= dgv_doktor.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dgv_doktor.Rows)
                {
                    DataGridViewCell cell = dgv_doktor.Rows[i].Cells["DoktorId"];
                    if (cell.Value != null)
                    {
                        if (cell.Value.ToString() == gelendoktorid.ToString())
                        {
                            cell.Style.BackColor = Color.Red;
                            break;
                        }
                    }


                }
            }
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_hastalar_SelectionChanged(object sender, EventArgs e)
        {
            txt_hastaid.Text = dgv_hastalar.CurrentRow.Cells["HastaId"].Value.ToString();
            txt_hastatcno.Text = dgv_hastalar.CurrentRow.Cells["HastaTcNo"].Value.ToString();
            txt_hastaad.Text = dgv_hastalar.CurrentRow.Cells["HastaAd"].Value.ToString();
            txt_hastasoyad.Text = dgv_hastalar.CurrentRow.Cells["HastaSoyad"].Value.ToString();
            txt_hastatel.Text = dgv_hastalar.CurrentRow.Cells["HastaTel"].Value.ToString();
        }

    }
}
