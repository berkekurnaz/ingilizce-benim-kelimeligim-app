namespace IngilizceKelimeApp.Screens
{
    partial class FrmQuiz
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreateQuiz = new MetroFramework.Controls.MetroButton();
            this.panelStatistics = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblWordCount = new MetroFramework.Controls.MetroLabel();
            this.lblCreatedDate = new MetroFramework.Controls.MetroLabel();
            this.panelQuiz = new MetroFramework.Controls.MetroPanel();
            this.btnCheck = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.lblWord = new MetroFramework.Controls.MetroLabel();
            this.txtMean = new MetroFramework.Controls.MetroTextBox();
            this.btnNextQuestion = new MetroFramework.Controls.MetroButton();
            this.btnShowCorrectWord = new MetroFramework.Controls.MetroButton();
            this.lblCorrectWord = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.panelStatistics.SuspendLayout();
            this.panelQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnCreateQuiz);
            this.metroPanel1.Controls.Add(this.dateDate);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 100);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(431, 211);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(425, 56);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Lütfen Tarih Seçiniz";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateDate
            // 
            this.dateDate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDate.Location = new System.Drawing.Point(24, 67);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(380, 36);
            this.dateDate.TabIndex = 3;
            // 
            // btnCreateQuiz
            // 
            this.btnCreateQuiz.Location = new System.Drawing.Point(86, 128);
            this.btnCreateQuiz.Name = "btnCreateQuiz";
            this.btnCreateQuiz.Size = new System.Drawing.Size(255, 58);
            this.btnCreateQuiz.TabIndex = 4;
            this.btnCreateQuiz.Text = "Quiz Oluştur";
            this.btnCreateQuiz.Click += new System.EventHandler(this.btnCreateQuiz_Click);
            // 
            // panelStatistics
            // 
            this.panelStatistics.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panelStatistics.Controls.Add(this.lblCreatedDate);
            this.panelStatistics.Controls.Add(this.lblWordCount);
            this.panelStatistics.Controls.Add(this.metroLabel4);
            this.panelStatistics.Controls.Add(this.metroLabel3);
            this.panelStatistics.Controls.Add(this.metroLabel2);
            this.panelStatistics.HorizontalScrollbarBarColor = true;
            this.panelStatistics.HorizontalScrollbarHighlightOnWheel = false;
            this.panelStatistics.HorizontalScrollbarSize = 10;
            this.panelStatistics.Location = new System.Drawing.Point(23, 335);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(431, 281);
            this.panelStatistics.TabIndex = 5;
            this.panelStatistics.VerticalScrollbarBarColor = true;
            this.panelStatistics.VerticalScrollbarHighlightOnWheel = false;
            this.panelStatistics.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 8);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(425, 56);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "İstatistikler";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(292, 56);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Bulunan Kelime:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(3, 132);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(292, 56);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Başlama Zamanı:";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWordCount
            // 
            this.lblWordCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblWordCount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblWordCount.Location = new System.Drawing.Point(301, 64);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(127, 56);
            this.lblWordCount.TabIndex = 5;
            this.lblWordCount.Text = "xx";
            this.lblWordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCreatedDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCreatedDate.Location = new System.Drawing.Point(301, 132);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(127, 56);
            this.lblCreatedDate.TabIndex = 6;
            this.lblCreatedDate.Text = "xx";
            this.lblCreatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelQuiz
            // 
            this.panelQuiz.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panelQuiz.Controls.Add(this.lblCorrectWord);
            this.panelQuiz.Controls.Add(this.btnShowCorrectWord);
            this.panelQuiz.Controls.Add(this.btnNextQuestion);
            this.panelQuiz.Controls.Add(this.txtMean);
            this.panelQuiz.Controls.Add(this.lblWord);
            this.panelQuiz.Controls.Add(this.btnCheck);
            this.panelQuiz.Controls.Add(this.metroLabel7);
            this.panelQuiz.HorizontalScrollbarBarColor = true;
            this.panelQuiz.HorizontalScrollbarHighlightOnWheel = false;
            this.panelQuiz.HorizontalScrollbarSize = 10;
            this.panelQuiz.Location = new System.Drawing.Point(486, 100);
            this.panelQuiz.Name = "panelQuiz";
            this.panelQuiz.Size = new System.Drawing.Size(791, 577);
            this.panelQuiz.TabIndex = 5;
            this.panelQuiz.VerticalScrollbarBarColor = true;
            this.panelQuiz.VerticalScrollbarHighlightOnWheel = false;
            this.panelQuiz.VerticalScrollbarSize = 10;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(248, 338);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(307, 58);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "KONTROL ET";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(3, 8);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(785, 95);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Ekrana Gelen Kelimeye Karşılık Gelen Kelimeyi Kontrol Edebilir Veya\r\nDoğru Cevabı" +
    " Hemen İnceleyebilirsin.";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 640);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(295, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Ana Menüye Geri Dön";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblWord
            // 
            this.lblWord.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblWord.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblWord.Location = new System.Drawing.Point(3, 154);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(785, 95);
            this.lblWord.TabIndex = 5;
            this.lblWord.Text = "Kelime";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMean
            // 
            this.txtMean.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMean.Location = new System.Drawing.Point(168, 259);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(470, 40);
            this.txtMean.TabIndex = 6;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(462, 461);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(176, 36);
            this.btnNextQuestion.TabIndex = 7;
            this.btnNextQuestion.Text = "Sonraki Soruya Geç";
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnShowCorrectWord
            // 
            this.btnShowCorrectWord.Location = new System.Drawing.Point(168, 461);
            this.btnShowCorrectWord.Name = "btnShowCorrectWord";
            this.btnShowCorrectWord.Size = new System.Drawing.Size(176, 36);
            this.btnShowCorrectWord.TabIndex = 8;
            this.btnShowCorrectWord.Text = "Doğru Cevap Göster";
            this.btnShowCorrectWord.Click += new System.EventHandler(this.btnShowCorrectWord_Click);
            // 
            // lblCorrectWord
            // 
            this.lblCorrectWord.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCorrectWord.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCorrectWord.Location = new System.Drawing.Point(3, 510);
            this.lblCorrectWord.Name = "lblCorrectWord";
            this.lblCorrectWord.Size = new System.Drawing.Size(785, 58);
            this.lblCorrectWord.TabIndex = 9;
            this.lblCorrectWord.Text = "Doğru Cevap";
            this.lblCorrectWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelQuiz);
            this.Controls.Add(this.panelStatistics);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmQuiz";
            this.Text = "İngilizce Kelime Uygulaması - Quiz Ekranı";
            this.Load += new System.EventHandler(this.FrmQuiz_Load);
            this.metroPanel1.ResumeLayout(false);
            this.panelStatistics.ResumeLayout(false);
            this.panelQuiz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnCreateQuiz;
        private System.Windows.Forms.DateTimePicker dateDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel panelStatistics;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblCreatedDate;
        private MetroFramework.Controls.MetroLabel lblWordCount;
        private MetroFramework.Controls.MetroPanel panelQuiz;
        private MetroFramework.Controls.MetroButton btnCheck;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTextBox txtMean;
        private MetroFramework.Controls.MetroLabel lblWord;
        private MetroFramework.Controls.MetroButton btnNextQuestion;
        private MetroFramework.Controls.MetroButton btnShowCorrectWord;
        private MetroFramework.Controls.MetroLabel lblCorrectWord;
    }
}