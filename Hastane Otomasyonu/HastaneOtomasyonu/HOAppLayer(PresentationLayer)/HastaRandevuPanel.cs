using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Net.Mail;
using System.Net;

namespace HOAppLayer_PresentationLayer_
{
    public partial class HastaRandevuPanel : Form
    {
        public HastaRandevuPanel()
        {
            InitializeComponent();
        }
        public string gelenhastaid;
        public string gelenhastaad;
        public string gelenhastasoyad;
        public string gelenhastatel;
        public string gelenrandevuid;
        public string gelenbransid;
        public string gelenhastatc;
        public string gelendoktorid;
        public string gelenmuayenenotu;
        

        private void RandevuGuncelleme()
        {
            Randevu grand = new Randevu()
            {
                MuayeneNot = txt_randevunotu.Text,
                RandevuId = int.Parse(txt_randevuid.Text)
            };
            RandevuManager.RandevurGuncelleme(grand);
            MessageBox.Show(" Randevu Kayıdı Güncellendi", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void RandevuPanel_Load(object sender, EventArgs e)
        {
            txt_hastaid.Text = gelenhastaid;
            txt_hastaad.Text = gelenhastaad;
            txt_hastasoyad.Text = gelenhastasoyad;
            txt_hastatel.Text = gelenhastatel;
            txt_randevuid.Text = gelenrandevuid;
            txt_bransid.Text = gelenbransid;
            txt_hastatcno.Text=gelenhastatc;
            txt_doktorid.Text = gelendoktorid;
            txt_randevunotu.Text = gelenmuayenenotu;
        }

        private void btn_muayenekaydet_Click(object sender, EventArgs e)
        {
            RandevuGuncelleme();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            DoktorPanelHasta doktorRandevu = new DoktorPanelHasta();
            doktorRandevu.doktorfiltre = txt_doktorid.Text;
            doktorRandevu.Show();
            this.Hide();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btx_pdfgonder_Click(object sender, EventArgs e)
        {
            string Ad = txt_hastaad.Text;
            string SoyAdı = txt_hastasoyad.Text;
            string pdfFile = @"C:\Users\Mevlüt\Desktop\HastaneOtomasyonu2\HastaneOtomasyonu\HOAppLayer(PresentationLayer)\PDF\"+Ad+" "+ SoyAdı+".pdf";

            // Create a new pdf document
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(pdfFile, FileMode.Create));
            doc.Open();

            // Add the text from the textbox to the pdf

            DoktorManager doktorManager = new DoktorManager();
            int id = Convert.ToInt32(txt_doktorid.Text);
            Doktor doktor = doktorManager.GetByIdDoktor(id);
            string doktorbilgi = "Doktor Bilgileri";
            string doktorAd = doktor.DoktorAd;
            string doktorSoyad = doktor.DoktorSoyad;
            string doktorTel = doktor.DoktorTel;

            HastaManager hastaManager = new HastaManager();
            string hastabilgi = "Hasta Bilgileri";
            int idhasta = Convert.ToInt32(txt_hastaid.Text);
            Hasta hasta = hastaManager.GetByIdHasta(idhasta);
            string hastaAd = hasta.HastaAd;
            string hastaSoyad = hasta.HastaSoyad;
            string hastaTel = hasta.HastaTel;


            Paragraph para = new Paragraph();
            Chunk chunk1 = new Chunk(txt_randevunotu.Text);
            Chunk chunk1label = new Chunk(lbl_randevunotu.Text);
           
            Chunk chunkdoktorbilgi = new Chunk(doktorbilgi);
            Chunk chunkdoktorAd = new Chunk(doktorAd);
            Chunk chunkdoktorSoyad = new Chunk(doktorSoyad);

            Chunk chunkhastabilgi = new Chunk(hastabilgi);
            Chunk chunkhastaAd = new Chunk(hastaAd);
            Chunk chunkhastaSoyad = new Chunk(hastaSoyad);

            para.Add(chunkhastabilgi);
            para.Add(Chunk.TABBING);
            para.Add(chunkhastaAd);
            para.Add(Chunk.TABBING);
            para.Add(chunkhastaSoyad);
            para.Add(Chunk.NEWLINE);
            para.Add(Chunk.NEWLINE);
            para.Add(Chunk.NEWLINE);

            para.Add(chunkdoktorbilgi);
            para.Add(Chunk.TABBING);
            para.Add(chunkdoktorAd);
            para.Add(Chunk.TABBING);
            para.Add(chunkdoktorSoyad);
            para.Add(Chunk.TABBING);
            para.Add(Chunk.NEWLINE);
            para.Add(Chunk.NEWLINE);
            para.Add(Chunk.NEWLINE);

            para.Add(chunk1label);
            para.Add(Chunk.TABBING);
            para.Add(chunk1);
            para.Add(Chunk.NEWLINE);
            para.Add(Chunk.NEWLINE);
            para.Add(Chunk.NEWLINE);
            para.Add(Chunk.TABBING);
            doc.Add(para);
            MessageBox.Show("Pdf başarıyla oluşturuldu!");

            doc.Close();
        }

        private void btn_mailgonder_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.office365.com";
            sc.EnableSsl = true;

            if (txt_Mail.Text!="")
            {
                string kime = "mevlut_kanarya1907@hotmail.com";
                string konu = "Deneme";
                string icerik = txt_randevunotu.Text;

                sc.Credentials = new NetworkCredential("gorselfinalgonder@hotmail.com", "Gorselfinalmail");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("gorselfinalgonder@hotmail.com", "Mevlüt KIDIL");
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                sc.Send(mail);
                MessageBox.Show("Mail Başarılı şekilde gönderilmiştir.");
            }
            else
            {
                MessageBox.Show("Mail Yanlış Girildi.","Tekrar Deneyiniz.",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //string kime = txt_Mail.Text;
            //string konu = "Deneme";
            //string icerik = txt_randevunotu.Text;

            //sc.Credentials = new NetworkCredential("gorselfinalgonder@hotmail.com", "Gorselfinalmail");
            //MailMessage mail = new MailMessage();
            //mail.From = new MailAddress("gorselfinalgonder@hotmail.com", "Mevlüt KIDIL");
            //mail.To.Add(kime);
            //mail.Subject = konu;
            //mail.IsBodyHtml = true;
            //mail.Body = icerik;
            //sc.Send(mail);
            //MessageBox.Show("Mail Başarılı şekilde gönderilmiştir.");

            
        }
    }
}
