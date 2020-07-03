namespace IngilizceKelimeApp.Screens
{
    partial class FrmAdd
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
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMean = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtWord = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.dateDate);
            this.metroPanel1.Controls.Add(this.txtDescription);
            this.metroPanel1.Controls.Add(this.btnAdd);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtMean);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtWord);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 76);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(469, 442);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(60, 358);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(349, 58);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Yeni Kelime Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(224, 214);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(242, 30);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Eklenme Tarihi";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 214);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(242, 30);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Açıklama";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMean
            // 
            this.txtMean.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMean.Location = new System.Drawing.Point(60, 161);
            this.txtMean.Margin = new System.Windows.Forms.Padding(60, 10, 60, 3);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(349, 35);
            this.txtMean.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(463, 30);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Anlamı";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWord
            // 
            this.txtWord.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtWord.Location = new System.Drawing.Point(60, 65);
            this.txtWord.Margin = new System.Windows.Forms.Padding(60, 10, 60, 3);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(349, 35);
            this.txtWord.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(463, 30);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Kelime";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDescription.Location = new System.Drawing.Point(17, 267);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(60, 10, 60, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(212, 35);
            this.txtDescription.TabIndex = 8;
            // 
            // dateDate
            // 
            this.dateDate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDate.Location = new System.Drawing.Point(251, 266);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(203, 36);
            this.dateDate.TabIndex = 9;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 540);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmAdd";
            this.Text = "Yeni Kelime Ekle";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMean;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtWord;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dateDate;
        private MetroFramework.Controls.MetroTextBox txtDescription;
    }
}