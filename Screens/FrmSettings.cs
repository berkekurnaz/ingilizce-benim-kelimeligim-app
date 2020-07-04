using IngilizceKelimeApp.Database;
using IngilizceKelimeApp.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace IngilizceKelimeApp.Screens
{
    public partial class FrmSettings : MetroForm
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private WordManager _wordManager = new WordManager("Words");
        private List<Word> words = new List<Word>();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            words = _wordManager.GetAll();

            lblCountAll.Text = words.Count.ToString();
            lblCountToday.Text = words.Count(x => x.Date == DateTime.Now.ToShortDateString()).ToString();

            metroComboBox1.SelectedIndex = 0;
        }

        /* Ana menu geri donme */
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        /* Tum Kelimeler Pdf Olustur */
        private void button1_Click(object sender, EventArgs e)
        {
            string wordsList = "İngilizce Kelimeler\n------------------------------------\n";
            foreach (var item in words)
            {
                wordsList += item.Id.ToString() + ".  " + item.Title + "  :  " + item.Mean + "\n";  
            }

            try
            {
                Document pdfDosya = new Document();
                PdfWriter.GetInstance(pdfDosya, new FileStream("C:KelimeListesi.pdf", FileMode.Create));

                pdfDosya.Open();
                pdfDosya.AddCreator("berke kurnaz");
                pdfDosya.AddCreationDate();
                pdfDosya.AddAuthor("Berke Kurnaz");
                pdfDosya.AddHeader("Bütün Kelimeler", "İngilizce Kelime Uygulaması");
                pdfDosya.AddTitle("Bütün Kelimeler");

                Paragraph eklenecekMetin = new Paragraph(wordsList);
                pdfDosya.Add(eklenecekMetin);

                pdfDosya.Close();
                MessageBox.Show("Pdf Dosyası Oluşturuldu.");
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        /* Bugünkü Kelimeleri Pdf Olustur*/
        private void button2_Click(object sender, EventArgs e)
        {
            string wordsList = "Ingilizce Kelimeler\n------------------------------------\n";
            foreach (var item in words.Where(x => x.Date == DateTime.Now.ToShortDateString()))
            {
                wordsList += item.Title + "  :  " + item.Mean + "\n";
            }

            try
            {
                Document pdfDosya = new Document();
                PdfWriter.GetInstance(pdfDosya, new FileStream("C:KelimeListesiGunluk.pdf", FileMode.Create));

                pdfDosya.Open();
                pdfDosya.AddCreator("berke kurnaz");
                pdfDosya.AddCreationDate();
                pdfDosya.AddAuthor("Berke Kurnaz");
                pdfDosya.AddHeader("Bütün Kelimeler", "İngilizce Kelime Uygulaması");
                pdfDosya.AddTitle("Bütün Kelimeler");

                Paragraph eklenecekMetin = new Paragraph(wordsList);
                pdfDosya.Add(eklenecekMetin);

                pdfDosya.Close();
                MessageBox.Show("Pdf Dosyası Oluşturuldu.");
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }
    }
}
