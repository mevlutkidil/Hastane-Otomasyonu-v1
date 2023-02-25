using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;

namespace HOAppLayer_PresentationLayer_
{
    public partial class BransaGoreHastaSayısıChart : Form
    {
        int TopRandevu = 0;
        int TopDoktor = 0;
        public BransaGoreHastaSayısıChart()
        {
            InitializeComponent();
            DoktorListele();
            RandevuListele();
            GraphOlustur(zedgraphdeneme);
           // Deneme();
        }
        //private void TopRandevuSayisi()
        //{
        //    TopRandevu=dgv_randevu.Rows.Count
        //}
        private void RandevuListele()
        {
            dgv_randevu.DataSource = RandevuManager.RandevuList();

        }
        
        private void DoktorListele()
        {
            dgv_doktor.DataSource = DoktorManager.DoktorList();

        }
        //private void Deneme()
        //{
        //    dataGridView1.DataSource = SekreterDAL.GetPatientCountByDoctor();

        //}
        private void ZedDoldur()
        {
            SekreterManager.GrafikGetirme(zedgraphdeneme);
        }

        private void BransaGoreHastaSayısıChart_Load(object sender, EventArgs e)
        {
            TopDoktor = dgv_doktor.Rows.Count;
            TopRandevu = dgv_randevu.Rows.Count;          
            chrt_randevudoktor.Series.Add("Randevu Sayısı");
            chrt_randevudoktor.Series.Add("Doktor Sayısı");
            chrt_randevudoktor.Series["Randevu Sayısı"].Points.Add(TopRandevu);
            chrt_randevudoktor.Series["Doktor Sayısı"].Points.Add(TopDoktor);
            chrt_randevudoktor.Series["Randevu Sayısı"].Points[0].AxisLabel = "Randevu Sayısı";
            chrt_randevudoktor.Series["Doktor Sayısı"].Points[0].AxisLabel = "Doktor Sayısı";
        }
        private void GraphOlustur(ZedGraphControl zedGraph1)
        {
            GraphPane graphPane = zedGraph1.GraphPane;
            graphPane.Title.Text = "Hastane Otomasyonu";
            graphPane.XAxis.Title.Text = "Branş Adları";
            graphPane.YAxis.Title.Text = "Randevu Sayıları";

            ZedDoldur();
            
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
