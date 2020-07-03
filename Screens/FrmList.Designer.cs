namespace IngilizceKelimeApp.Screens
{
    partial class FrmList
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
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.lblCreatedDate = new MetroFramework.Controls.MetroLabel();
            this.lblDescription = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMean = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtWord = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 619);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(247, 58);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Ana Menüye Geri Dön";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeView1.Location = new System.Drawing.Point(23, 78);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(755, 535);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lblId);
            this.metroPanel1.Controls.Add(this.btnDelete);
            this.metroPanel1.Controls.Add(this.btnUpdate);
            this.metroPanel1.Controls.Add(this.lblCreatedDate);
            this.metroPanel1.Controls.Add(this.lblDescription);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtMean);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtWord);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(808, 78);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(469, 423);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(256, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 58);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(60, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 58);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCreatedDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCreatedDate.Location = new System.Drawing.Point(224, 271);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(242, 30);
            this.lblCreatedDate.TabIndex = 9;
            this.lblCreatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDescription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDescription.Location = new System.Drawing.Point(3, 271);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(242, 30);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblId
            // 
            this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblId.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblId.Location = new System.Drawing.Point(0, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(242, 30);
            this.lblId.TabIndex = 11;
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblId.Visible = false;
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmList";
            this.Text = "İngilizce Kelime Uygulaması - Listeleme Ekranı";
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.TreeView treeView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtMean;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtWord;
        private MetroFramework.Controls.MetroLabel lblCreatedDate;
        private MetroFramework.Controls.MetroLabel lblDescription;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroLabel lblId;
    }
}