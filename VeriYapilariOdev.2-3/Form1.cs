using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariOdev._2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creating stacks
        SentenceStack sentenceStack;
        WordStack wordStack;
        WordStack uniqueWordStack;
        Heap heap;
        HashTable hashTable;
        string fileText = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStackOku.Enabled = false;
            btnStackOku.Text = "Lütfen önce metin yükleyin";
            btnAgacaAktar.Enabled = false;
            btnEnSik.Enabled = false;
            btnAgacaAktar.Text = "Lütfen önce stack işlemlerini yapın";
            btnEnSik.Text = "Lütfen önce stack işlemlerini yapın";
            btnHashOlustur.Text = "Lütfen önce stack işlemlerini yapın";
            btnHashOlustur.Enabled = false;
        }

        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            //Getting the file
            OpenFileDialog fileSelector = new OpenFileDialog();
            fileSelector.Filter = "Metin Dosyası |*.txt";
            fileSelector.ShowDialog();
            //lblFilePath.Text = "Path: " +  fileSelector.FileName;
            txtPath.Text = fileSelector.FileName;

            //Reading the file
            StreamReader reader = new StreamReader(fileSelector.OpenFile());
            fileText = reader.ReadToEnd();

            btnStackOku.Enabled = true;
            btnStackOku.Text = "Stack oku";
            txtSentences.Clear();
            txtOriginalWords.Clear();
            txtProcessed.Clear();
            btnAgacaAktar.Text = "Lütfen önce stack işlemlerini yapın";
            btnEnSik.Text = "Lütfen önce stack işlemlerini yapın";
            btnAgacaAktar.Enabled = false;
            btnEnSik.Enabled = false;
            txtEnSikIterasyon.Clear();
            txtEnSikKullanilanKelimeler.Clear();
            lblToplamCumle.Text = "Toplam Cümle Sayısı: ";
            lblOrtalamaKelime.Text = "Ortalama Kelime Sayısı: ";
        }

        private void btnStackOku_Click(object sender, EventArgs e)
        {
            sentenceStack = new SentenceStack();
            wordStack = new WordStack();
            uniqueWordStack = new WordStack();
            
            //Pushing sentences and original words to their stacks
            string sentence = String.Empty;
            string word = String.Empty;
            int wordCount = 0;
            int sentenceCount = 0;
            foreach (var letter in fileText)
            {
                if (letter.ToString() == "\n")
                {
                    sentenceStack.Push(sentence, wordCount + 1, 0, ++sentenceCount);
                    sentence = String.Empty;
                    wordStack.Push(word.ToLower(), 1, 1, ++wordCount);
                    uniqueWordStack.Push(word.ToLower(), 1, 2, wordCount);
                    word = String.Empty;
                    wordCount = 0;
                }
                else
                {
                    if (letter.ToString() == " ")
                    {
                        wordStack.Push(word.ToLower(), 1, 1, ++wordCount);
                        uniqueWordStack.Push(word.ToLower(), 1, 2, wordCount);
                        sentence += letter.ToString();
                        word = String.Empty;
                    }
                    else
                    {
                        word += letter.ToString();
                        sentence += letter.ToString();
                    }
                }

                btnAgacaAktar.Enabled = true;
                btnAgacaAktar.Text = "Ağaca Aktar";
                btnEnSik.Text = "Lütfen önce ağaca aktarın";
                btnHashOlustur.Text = "Hash Tablo Oluştur";
                btnHashOlustur.Enabled = true;
            }

            //Pushing last sentences and original words to their stacks
            sentenceStack.Push(sentence, wordCount, 0, ++sentenceCount);
            wordStack.Push(word.ToLower(), 1, 1, ++wordCount);
            uniqueWordStack.Push(word.ToLower(), 1, 2, wordCount);

            //Converting original words to processed words and pushing them
            //foreach (var item in wordStack.ReturnList())
            //{
            //    string processedWord = String.Empty;
                
            //    foreach (var letter in item.Data.ToString())
            //    {
            //        if (Char.IsPunctuation(letter))
            //        {
            //            break;
            //        }

            //        processedWord += letter;
            //    }

            //    if (!String.IsNullOrEmpty(processedWord))
            //    {
            //        uniqueWordStack.Push(processedWord, 1, 2);
            //    }
            //}

            //Printing stacks
            txtSentences.Text = sentenceStack.DisplayElements().ToString();
            txtOriginalWords.Text = wordStack.ReturnElements().ToString();
            lblToplamCumle.Text = "Toplam Cümle Sayısı: " +  sentenceStack.Size.ToString();
            lblOrtalamaKelime.Text = "Ortalama Kelime Sayısı: " +  (sentenceStack.GetTotalWordCount()  / sentenceStack.Size).ToString();
            foreach (var item in uniqueWordStack.ReturnList())
            {
                txtProcessed.Text += item.Processed + "  // Frekans: " + item.WordCount + Environment.NewLine;
            }

            btnStackOku.Enabled = false;
        }

        private void btnAgacaAktar_Click(object sender, EventArgs e)
        {
            heap = new Heap(uniqueWordStack.Size);

            foreach (var item in uniqueWordStack.ReturnList())
            {
                heap.Insert(item.Processed, (int)item.WordCount);
            }

            btnEnSik.Enabled = true;
            btnEnSik.Text = "En Sık Kullanılan Kelimeleri Getir";
            btnAgacaAktar.Enabled = false;
        }

        private void btnEnSik_Click(object sender, EventArgs e)
        {
            txtEnSikKullanilanKelimeler.Clear();
            HeapNode[] sortedNodes = heap.Sort();
            int iteration = 0;

            try
            {
                iteration = Convert.ToInt32(txtEnSikIterasyon.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kaç kelime istediğinizi giriniz");
                return;
            }
            
            if (iteration > sortedNodes.Length)
            {
                MessageBox.Show("Lütfen ağaç sınırlarını aşmayınız");
                return;
            }

            for (int i = 0; i < iteration; i++)
            {
                txtEnSikKullanilanKelimeler.Text += i + 1 + "- " + sortedNodes[i].Data + "  // Frekans " + sortedNodes[i].Count + Environment.NewLine;
            }
        }

        private void btnHashOlustur_Click(object sender, EventArgs e)
        {
            hashTable = new HashTable(uniqueWordStack.Size);

            foreach (var item in uniqueWordStack.ReturnList())
            {
                hashTable.Add(item.Processed);
            }
        }
    }
}
