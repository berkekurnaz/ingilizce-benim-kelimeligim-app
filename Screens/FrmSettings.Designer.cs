namespace IngilizceKelimeApp.Screens
{
    partial class FrmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountAll = new System.Windows.Forms.Label();
            this.lblCountToday = new System.Windows.Forms.Label();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCountToday);
            this.panel1.Controls.Add(this.lblCountAll);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 343);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.metroComboBox1);
            this.panel2.Controls.Add(this.metroCheckBox2);
            this.panel2.Controls.Add(this.metroCheckBox1);
            this.panel2.Location = new System.Drawing.Point(536, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 561);
            this.panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 619);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(284, 58);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Ana Menüye Geri Dön";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Kelime Sayısı: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bugün Kelime Sayısı: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountAll
            // 
            this.lblCountAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountAll.Location = new System.Drawing.Point(326, 48);
            this.lblCountAll.Name = "lblCountAll";
            this.lblCountAll.Size = new System.Drawing.Size(86, 57);
            this.lblCountAll.TabIndex = 2;
            this.lblCountAll.Text = "xx";
            this.lblCountAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountToday
            // 
            this.lblCountToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountToday.Location = new System.Drawing.Point(326, 105);
            this.lblCountToday.Name = "lblCountToday";
            this.lblCountToday.Size = new System.Drawing.Size(86, 57);
            this.lblCountToday.TabIndex = 3;
            this.lblCountToday.Text = "xx";
            this.lblCountToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroCheckBox1.Location = new System.Drawing.Point(20, 25);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(351, 47);
            this.metroCheckBox1.TabIndex = 0;
            this.metroCheckBox1.Text = "Ligth Temaya Geçiş Yap";
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroCheckBox2.Location = new System.Drawing.Point(367, 25);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(351, 47);
            this.metroCheckBox2.TabIndex = 1;
            this.metroCheckBox2.Text = "Dark Temaya Geçiş Yap";
            this.metroCheckBox2.UseVisualStyleBackColor = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Açık",
            "Kapalı"});
            this.metroComboBox1.Location = new System.Drawing.Point(20, 105);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(291, 30);
            this.metroComboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kelimeleri Pdf Oluştur (Tüm  Zamanlar)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 72);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kelimeleri Pdf Oluştur (Bugün)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSettings";
            this.Text = "İngilizce Kelime Uygulaması - Ayarlar Ekranı";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.Label lblCountToday;
        private System.Windows.Forms.Label lblCountAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}