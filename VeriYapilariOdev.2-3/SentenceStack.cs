using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev._2_3
{
    public class SentenceStack : StackADT
    {
        public object DisplayElements()
        {
            StackNode temp = new StackNode(null, null, 0);
            temp = Top;
            string info = String.Empty;
            while (temp.Next != null)
            {
                info += temp.Data + "  //Kelime Sayısı: " + temp.WordCount + " Kaçıncı Cümle: " + temp.Count + Environment.NewLine + Environment.NewLine;
                temp = temp.Next;
            }

            info += temp.Data + "  //Kelime Sayısı: " + temp.WordCount + " Kaçıncı Cümle: " + temp.Count + Environment.NewLine;
            return info;
        }

        public int GetTotalWordCount()
        {
            StackNode temp = new StackNode(null, null, 0);
            temp = Top;
            int totalWordCount = 0;

            while (temp.Next != null)
            {
                totalWordCount += (int)temp.WordCount;
                temp = temp.Next;
            }

            totalWordCount += (int)temp.WordCount;
            return totalWordCount;
        }
    }
}
