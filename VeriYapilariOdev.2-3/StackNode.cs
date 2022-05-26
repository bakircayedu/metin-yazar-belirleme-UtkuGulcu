using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev._2_3
{
    public class StackNode
    {
        public object Data { get; set; }
        public StackNode Next { get; set; }
        public object WordCount { get; set; } // For sentences --> total word count of that sentence  For words --> Frequency
        public string Processed { get; set; }
        public int Count { get; set; }

        public StackNode(object _data, object _wordCount, int _count)
        {
            Data = _data;
            WordCount = _wordCount;
            Count = _count;
        }

        public StackNode(object _data, object _wordCount, int _count, string _processed)
        {
            Data = _data;
            WordCount = _wordCount;
            Count = _count;
            Processed = _processed;
        }
    }
}
