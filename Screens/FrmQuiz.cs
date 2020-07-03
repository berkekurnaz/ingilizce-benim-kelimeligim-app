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

namespace IngilizceKelimeApp.Screens
{
    public partial class FrmQuiz : MetroForm
    {
        public FrmQuiz()
        {
            InitializeComponent();
        }

        private WordManager _wordManager = new WordManager("Words");
        private List<Word> words = new List<Word>();
        int questionNumber = 0;

        private void FrmQuiz_Load(object sender, EventArgs e)
        {
            panelStatistics.Visible = false;
            panelQuiz.Visible = false;
        }

        /* Ana menu geri donme islemi */
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        /* Quiz olusturma islemi */
        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            panelStatistics.Visible = true;
            panelQuiz.Visible = true;

            words = _wordManager.GetAll().Where(x => x.Date == dateDate.Value.ToShortDateString()).ToList();
            if (words.Count > 0)
            {
                words.Reverse();
                lblWordCount.Text = words.Count.ToString();
                lblCreatedDate.Text = DateTime.Now.ToShortTimeString();

                createQuestion();
            }
            else
            {
                MessageBox.Show("Seçtiğiniz Tarihte Eklenen Kelime Bulunamadı.");
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
        }

        /* Kelime Kontrol Etme Islemi */
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtMean.Text == words[questionNumber - 1].Mean)
            {
                MessageBox.Show("Doğru Cevapladınız. Sonraki Soruya Geçebilirsiniz.");
            }
            else
            {
                MessageBox.Show("Yanlış Cevapladınız. Lütfen Kontrol Ediniz.");
            }
        }

        /* Dogru cevap gosterme islemi */
        private void btnShowCorrectWord_Click(object sender, EventArgs e)
        {
            lblCorrectWord.Visible = !lblCorrectWord.Visible;
        }

        /* Diger Soruya Gecme Islemi */
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            txtMean.Text = "";
            createQuestion();
        }

        /* Soru Olusturma Islemi */
        void createQuestion()
        {
            if (questionNumber < words.Count)
            {
                lblWord.Text = words[questionNumber].Title;
                lblCorrectWord.Text = "Doğru : " + words[questionNumber].Mean;
                lblCorrectWord.Visible = false;
                questionNumber++;
            }
            else
            {
                MessageBox.Show("Soru Kalmadı.");
            }
        }

    }
}
