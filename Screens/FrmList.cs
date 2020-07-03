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
    public partial class FrmList : MetroForm
    {

        string _listType = "";

        public FrmList(string listType)
        {
            InitializeComponent();
            _listType = listType;
        }

        private WordManager _wordManager = new WordManager("Words");

        List<Word> words;
        List<string> dates;

        /* Ekran Yuklendigi Zaman Gerceklesecek Olaylar */
        private void FrmList_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            treeView1.Nodes.Clear();

            words = _wordManager.GetAll().OrderByDescending(x => x.Date).ToList();
            dates = new List<string>();

            if (_listType == "D")
            {
                showDataByDate();
            }
            else if (_listType == "A")
            {
                showDataByalphabetical();
            }
        }

        /* Bu Fonksiyon Tarihe Göre Listeleme Yapar */
        void showDataByDate()
        {
            foreach (var item in words)
            {
                if (!dates.Contains(item.Date))
                {
                    dates.Add(item.Date);
                }
            }
            foreach (var item in dates)
            {
                List<Word> wordsByDate = words.Where(x => x.Date == item).ToList();
                TreeNode[] array = new TreeNode[wordsByDate.Count];
                int arrayCount = 0;
                foreach (var word in wordsByDate)
                {
                    TreeNode node = new TreeNode(word.Title);
                    array[arrayCount] = node;
                    arrayCount++;
                }
                TreeNode treeNode = new TreeNode(item, array);
                treeView1.Nodes.Add(treeNode);
            }
        }

        void showDataByalphabetical()
        {
            List<string> alphabet = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            foreach (var item in alphabet)
            {
                List<Word> wordsByCharacter = words.Where(x => x.Title.Substring(0,1) == item).ToList();
                TreeNode[] array = new TreeNode[wordsByCharacter.Count];
                int arrayCount = 0;
                foreach (var word in wordsByCharacter)
                {
                    TreeNode node = new TreeNode(word.Title);
                    array[arrayCount] = node;
                    arrayCount++;
                }
                TreeNode treeNode = new TreeNode(item, array);
                treeView1.Nodes.Add(treeNode);
            }
        }

        /* Ana Menuye Geri Donme */
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        /* Tiklama Sonrasi Veriyi Gerekli Araclara Gonderme */
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                Word word = words.FirstOrDefault(x => x.Title == e.Node.Text);
                if (word != null)
                {
                    lblId.Text = word.Id.ToString();
                    txtWord.Text = word.Title;
                    txtMean.Text = word.Mean;
                    lblDescription.Text = word.Description;
                    lblCreatedDate.Text = word.Date;
                }
            }
            catch
            {

            }
        }

        /* Guncelleme Islemi */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtWord.Text.Length > 1 && txtMean.Text.Length > 1)
            {
                DialogResult check = MessageBox.Show("Bu Güncellemeyi Yapmak İstiyor Musunuz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (check == DialogResult.Yes)
                {
                    Word word = words.FirstOrDefault(x => x.Id == int.Parse(lblId.Text));
                    if (word != null)
                    {
                        word.Title = txtWord.Text;
                        word.Mean = txtMean.Text;
                        word.Description = lblDescription.Text;
                        word.Date = lblCreatedDate.Text;
                        _wordManager.UpdateModel(word);
                        ShowData();

                        MessageBox.Show("Kelime Başarıyla Güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kelime Bulunamadı.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz.");
            }
        }

        /* Silme Islemi */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtWord.Text.Length > 1 && txtMean.Text.Length > 1)
            {
                DialogResult check = MessageBox.Show("Silme Islemini Yapmak İstiyor Musunuz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (check == DialogResult.Yes)
                {
                    Word word = words.FirstOrDefault(x => x.Id == int.Parse(lblId.Text));
                    if (word != null)
                    {
                        _wordManager.DeleteModel(word.Id);
                        ShowData();

                        MessageBox.Show("Kelime Başarıyla Silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Kelime Bulunamadı.");
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
