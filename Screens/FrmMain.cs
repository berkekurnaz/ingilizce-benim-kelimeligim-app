
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
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Tarih : " + DateTime.Now.ToLongDateString();
        }

        /* Tarihsel Listeleme Sayfasini Acar */
        private void metroPanel1_Click(object sender, EventArgs e)
        {
            FrmList frmList = new FrmList("D");
            frmList.Show();
            this.Hide();
        }

        /* Alfabetik Listeleme Sayfasini Acar */
        private void metroPanel2_Click(object sender, EventArgs e)
        {
            FrmList frmList = new FrmList("A");
            frmList.Show();
            this.Hide();
        }

        /* Quiz Sayfasini Acar */
        private void metroPanel3_Click(object sender, EventArgs e)
        {

        }

        /* Ayarlar Sayfasini Acar */
        private void metroPanel4_Click(object sender, EventArgs e)
        {

        }

        /* Yeni Ekleme Sayfasini Acar */
        private void metroPanel5_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();
            frmAdd.Show();
        }
    }
}
