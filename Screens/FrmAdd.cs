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
    public partial class FrmAdd : MetroForm
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private WordManager _wordManager = new WordManager("Words");
        List<Word> words = new List<Word>();

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            words = _wordManager.GetAll();
            dateDate.Value = DateTime.Now;
        }

        /* Yeni Kelime Ekleme Islemi */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtWord.Text.Length > 1 && txtMean.Text.Length > 1)
            {
                DialogResult check = MessageBox.Show("Bu Kelimeyi Eklemek İstiyor Musunuz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (check == DialogResult.Yes)
                {
                    Word word = new Word();
                    word.Title = txtWord.Text;
                    word.Mean = txtMean.Text;
                    word.Description = txtDescription.Text;
                    word.Date = dateDate.Value.ToShortDateString();

                    if (words.Count(x => x.Title == txtWord.Text) <= 0)
                    {
                        _wordManager.AddModel(word);
                        txtWord.Text = "";
                        txtMean.Text = "";
                        txtDescription.Text = "";
                        MessageBox.Show("Kelime Başarıyla Eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Bu Kelime Daha Önce Eklenmiş.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz.");
            }
        }
    }
}
