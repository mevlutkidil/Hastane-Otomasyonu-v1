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
    public partial class SekreterHasta : Form
    {
        public SekreterHasta()
        {
            InitializeComponent();
        }

        private void btn_hastacrud_Click(object sender, EventArgs e)
        {
            SekreterHastaIslemleri sekreterHastaIslemleri = new SekreterHastaIslemleri();
            sekreterHastaIslemleri.Show();
            this.Hide();
        }

        private void btn_randevuver_Click(object sender, EventArgs e)
        {
            RandevuVerme randevuverme = new RandevuVerme();
            randevuverme.Show();
            this.Hide();
            MessageBox.Show("Değerleri ilgili tablolardan seçerek giriniz. Lütfen seçtiğiniz değerleri kontrol ediniz.!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            SekreterPanel sekreterPanel=new SekreterPanel();
            sekreterPanel.Show();
            this.Hide();   
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_chartlaragit_Click(object sender, EventArgs e)
        {
            BransaGoreHastaSayısıChart chartagit = new BransaGoreHastaSayısıChart();
            chartagit.Show();
            this.Hide();
        }
    }
}
