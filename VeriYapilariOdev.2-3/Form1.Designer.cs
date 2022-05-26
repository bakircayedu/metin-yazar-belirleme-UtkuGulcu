
namespace VeriYapilariOdev._2_3
{
    partial class Form1
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
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.txtSentences = new System.Windows.Forms.TextBox();
            this.txtOriginalWords = new System.Windows.Forms.TextBox();
            this.lblToplamCumle = new System.Windows.Forms.Label();
            this.txtProcessed = new System.Windows.Forms.TextBox();
            this.lblOrtalamaKelime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxStack = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStack = new System.Windows.Forms.TabPage();
            this.tabPageTree = new System.Windows.Forms.TabPage();
            this.groupBoxTree = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnSikKullanilanKelimeler = new System.Windows.Forms.TextBox();
            this.btnEnSik = new System.Windows.Forms.Button();
            this.txtEnSikIterasyon = new System.Windows.Forms.TextBox();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.tabPageHash = new System.Windows.Forms.TabPage();
            this.groupBoxHash = new System.Windows.Forms.GroupBox();
            this.btnHashOlustur = new System.Windows.Forms.Button();
            this.groupBoxStack.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageStack.SuspendLayout();
            this.tabPageTree.SuspendLayout();
            this.groupBoxTree.SuspendLayout();
            this.tabPageHash.SuspendLayout();
            this.groupBoxHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(9, 19);
            this.btnMetinYukle.Margin = new System.Windows.Forms.Padding(2);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(113, 55);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // btnStackOku
            // 
            this.btnStackOku.Location = new System.Drawing.Point(9, 115);
            this.btnStackOku.Margin = new System.Windows.Forms.Padding(2);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(113, 49);
            this.btnStackOku.TabIndex = 2;
            this.btnStackOku.Text = "Stack\'e Oku";
            this.btnStackOku.UseVisualStyleBackColor = true;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // txtSentences
            // 
            this.txtSentences.Location = new System.Drawing.Point(150, 18);
            this.txtSentences.Margin = new System.Windows.Forms.Padding(2);
            this.txtSentences.Multiline = true;
            this.txtSentences.Name = "txtSentences";
            this.txtSentences.ReadOnly = true;
            this.txtSentences.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSentences.Size = new System.Drawing.Size(320, 348);
            this.txtSentences.TabIndex = 3;
            // 
            // txtOriginalWords
            // 
            this.txtOriginalWords.Location = new System.Drawing.Point(500, 18);
            this.txtOriginalWords.Margin = new System.Windows.Forms.Padding(2);
            this.txtOriginalWords.Multiline = true;
            this.txtOriginalWords.Name = "txtOriginalWords";
            this.txtOriginalWords.ReadOnly = true;
            this.txtOriginalWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginalWords.Size = new System.Drawing.Size(320, 348);
            this.txtOriginalWords.TabIndex = 4;
            // 
            // lblToplamCumle
            // 
            this.lblToplamCumle.AutoSize = true;
            this.lblToplamCumle.Location = new System.Drawing.Point(5, 183);
            this.lblToplamCumle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamCumle.Name = "lblToplamCumle";
            this.lblToplamCumle.Size = new System.Drawing.Size(110, 13);
            this.lblToplamCumle.TabIndex = 5;
            this.lblToplamCumle.Text = "Toplam Cümle Sayısı: ";
            // 
            // txtProcessed
            // 
            this.txtProcessed.Location = new System.Drawing.Point(845, 19);
            this.txtProcessed.Margin = new System.Windows.Forms.Padding(2);
            this.txtProcessed.Multiline = true;
            this.txtProcessed.Name = "txtProcessed";
            this.txtProcessed.ReadOnly = true;
            this.txtProcessed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcessed.Size = new System.Drawing.Size(320, 348);
            this.txtProcessed.TabIndex = 6;
            // 
            // lblOrtalamaKelime
            // 
            this.lblOrtalamaKelime.AutoSize = true;
            this.lblOrtalamaKelime.Location = new System.Drawing.Point(5, 208);
            this.lblOrtalamaKelime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrtalamaKelime.Name = "lblOrtalamaKelime";
            this.lblOrtalamaKelime.Size = new System.Drawing.Size(116, 13);
            this.lblOrtalamaKelime.TabIndex = 7;
            this.lblOrtalamaKelime.Text = "Ortalama Kelime Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cümleler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bütün kelimeler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(952, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Unique preprocessed kelimeler";
            // 
            // groupBoxStack
            // 
            this.groupBoxStack.Controls.Add(this.txtPath);
            this.groupBoxStack.Controls.Add(this.txtSentences);
            this.groupBoxStack.Controls.Add(this.label3);
            this.groupBoxStack.Controls.Add(this.btnMetinYukle);
            this.groupBoxStack.Controls.Add(this.label2);
            this.groupBoxStack.Controls.Add(this.label1);
            this.groupBoxStack.Controls.Add(this.btnStackOku);
            this.groupBoxStack.Controls.Add(this.lblOrtalamaKelime);
            this.groupBoxStack.Controls.Add(this.txtOriginalWords);
            this.groupBoxStack.Controls.Add(this.txtProcessed);
            this.groupBoxStack.Controls.Add(this.lblToplamCumle);
            this.groupBoxStack.Location = new System.Drawing.Point(18, 22);
            this.groupBoxStack.Name = "groupBoxStack";
            this.groupBoxStack.Size = new System.Drawing.Size(1186, 423);
            this.groupBoxStack.TabIndex = 11;
            this.groupBoxStack.TabStop = false;
            this.groupBoxStack.Text = "Stack İşlemleri";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(10, 79);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(112, 20);
            this.txtPath.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStack);
            this.tabControl1.Controls.Add(this.tabPageTree);
            this.tabControl1.Controls.Add(this.tabPageHash);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 507);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPageStack
            // 
            this.tabPageStack.Controls.Add(this.groupBoxStack);
            this.tabPageStack.Location = new System.Drawing.Point(4, 22);
            this.tabPageStack.Name = "tabPageStack";
            this.tabPageStack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStack.Size = new System.Drawing.Size(1224, 481);
            this.tabPageStack.TabIndex = 0;
            this.tabPageStack.Text = "Stack İşlemleri";
            this.tabPageStack.UseVisualStyleBackColor = true;
            // 
            // tabPageTree
            // 
            this.tabPageTree.Controls.Add(this.groupBoxTree);
            this.tabPageTree.Location = new System.Drawing.Point(4, 22);
            this.tabPageTree.Name = "tabPageTree";
            this.tabPageTree.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTree.Size = new System.Drawing.Size(1224, 481);
            this.tabPageTree.TabIndex = 1;
            this.tabPageTree.Text = "Ağaç İşlemleri";
            this.tabPageTree.UseVisualStyleBackColor = true;
            // 
            // groupBoxTree
            // 
            this.groupBoxTree.Controls.Add(this.label4);
            this.groupBoxTree.Controls.Add(this.txtEnSikKullanilanKelimeler);
            this.groupBoxTree.Controls.Add(this.btnEnSik);
            this.groupBoxTree.Controls.Add(this.txtEnSikIterasyon);
            this.groupBoxTree.Controls.Add(this.btnAgacaAktar);
            this.groupBoxTree.Location = new System.Drawing.Point(16, 21);
            this.groupBoxTree.Name = "groupBoxTree";
            this.groupBoxTree.Size = new System.Drawing.Size(1181, 439);
            this.groupBoxTree.TabIndex = 0;
            this.groupBoxTree.TabStop = false;
            this.groupBoxTree.Text = "Ağaç İşlemleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kaç kelime getirilsin:";
            // 
            // txtEnSikKullanilanKelimeler
            // 
            this.txtEnSikKullanilanKelimeler.Location = new System.Drawing.Point(261, 19);
            this.txtEnSikKullanilanKelimeler.Multiline = true;
            this.txtEnSikKullanilanKelimeler.Name = "txtEnSikKullanilanKelimeler";
            this.txtEnSikKullanilanKelimeler.ReadOnly = true;
            this.txtEnSikKullanilanKelimeler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEnSikKullanilanKelimeler.Size = new System.Drawing.Size(340, 377);
            this.txtEnSikKullanilanKelimeler.TabIndex = 4;
            // 
            // btnEnSik
            // 
            this.btnEnSik.Location = new System.Drawing.Point(14, 139);
            this.btnEnSik.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnSik.Name = "btnEnSik";
            this.btnEnSik.Size = new System.Drawing.Size(216, 55);
            this.btnEnSik.TabIndex = 3;
            this.btnEnSik.Text = "En Sık Kullanılan Kelimeleri Getir";
            this.btnEnSik.UseVisualStyleBackColor = true;
            this.btnEnSik.Click += new System.EventHandler(this.btnEnSik_Click);
            // 
            // txtEnSikIterasyon
            // 
            this.txtEnSikIterasyon.Location = new System.Drawing.Point(119, 114);
            this.txtEnSikIterasyon.Name = "txtEnSikIterasyon";
            this.txtEnSikIterasyon.Size = new System.Drawing.Size(111, 20);
            this.txtEnSikIterasyon.TabIndex = 2;
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Location = new System.Drawing.Point(5, 32);
            this.btnAgacaAktar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(113, 55);
            this.btnAgacaAktar.TabIndex = 1;
            this.btnAgacaAktar.Text = "Ağaca Aktar";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAgacaAktar.Click += new System.EventHandler(this.btnAgacaAktar_Click);
            // 
            // tabPageHash
            // 
            this.tabPageHash.Controls.Add(this.groupBoxHash);
            this.tabPageHash.Location = new System.Drawing.Point(4, 22);
            this.tabPageHash.Name = "tabPageHash";
            this.tabPageHash.Size = new System.Drawing.Size(1224, 481);
            this.tabPageHash.TabIndex = 2;
            this.tabPageHash.Text = "Hash İşlemleri";
            this.tabPageHash.UseVisualStyleBackColor = true;
            // 
            // groupBoxHash
            // 
            this.groupBoxHash.Controls.Add(this.btnHashOlustur);
            this.groupBoxHash.Location = new System.Drawing.Point(22, 21);
            this.groupBoxHash.Name = "groupBoxHash";
            this.groupBoxHash.Size = new System.Drawing.Size(1181, 439);
            this.groupBoxHash.TabIndex = 1;
            this.groupBoxHash.TabStop = false;
            this.groupBoxHash.Text = "Hash İşlemleri";
            // 
            // btnHashOlustur
            // 
            this.btnHashOlustur.Location = new System.Drawing.Point(5, 32);
            this.btnHashOlustur.Margin = new System.Windows.Forms.Padding(2);
            this.btnHashOlustur.Name = "btnHashOlustur";
            this.btnHashOlustur.Size = new System.Drawing.Size(113, 55);
            this.btnHashOlustur.TabIndex = 1;
            this.btnHashOlustur.Text = "Hash Tablo Oluştur";
            this.btnHashOlustur.UseVisualStyleBackColor = true;
            this.btnHashOlustur.Click += new System.EventHandler(this.btnHashOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 573);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxStack.ResumeLayout(false);
            this.groupBoxStack.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageStack.ResumeLayout(false);
            this.tabPageTree.ResumeLayout(false);
            this.groupBoxTree.ResumeLayout(false);
            this.groupBoxTree.PerformLayout();
            this.tabPageHash.ResumeLayout(false);
            this.groupBoxHash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.TextBox txtSentences;
        private System.Windows.Forms.TextBox txtOriginalWords;
        private System.Windows.Forms.Label lblToplamCumle;
        private System.Windows.Forms.TextBox txtProcessed;
        private System.Windows.Forms.Label lblOrtalamaKelime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxStack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStack;
        private System.Windows.Forms.TabPage tabPageTree;
        private System.Windows.Forms.GroupBox groupBoxTree;
        private System.Windows.Forms.Button btnAgacaAktar;
        private System.Windows.Forms.Button btnEnSik;
        private System.Windows.Forms.TextBox txtEnSikIterasyon;
        private System.Windows.Forms.TextBox txtEnSikKullanilanKelimeler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TabPage tabPageHash;
        private System.Windows.Forms.GroupBox groupBoxHash;
        private System.Windows.Forms.Button btnHashOlustur;
    }
}

