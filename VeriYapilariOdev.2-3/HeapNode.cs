using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev._2_3
{
    public class HeapNode
    {
        public object Data { get; set; }
        public int Count { get; set; }

        public HeapNode(object _data, int _count)
        {
            Data = _data;
            Count = _count;
        }
    }
}
