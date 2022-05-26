using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev._2_3
{
    public class HashTable
    {
        private LinkedList[] HashArray { get; set; }
        public int MaxSize { get; set; }
        public HashTable(int size)
        {
            HashArray = new LinkedList[size];
            MaxSize = size;
            for (int i = 0; i < HashArray.Length; i++)
            {
                HashArray[i] = new LinkedList();
            }
        }

        public int Hash(string text, int size)
        {
            int hasVal = 0;
            foreach (var a in text)
                hasVal += a;
            return hasVal % size;
        }
        public void Add(string text)
        {
            int hash = Hash(text, MaxSize);
            HashArray[hash].InsertLast(text);
        }
    }
}
