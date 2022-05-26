using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev._2_3
{
    public class HashNode
    {
        public object Data { get; set; }
        public HashNode Next { get; set; }
        public int Key { get; set; }

        public HashNode(object _data /*, int _key*/)
        {
            Data = _data;
            //Key = _key;
        }

        public HashNode()
        {

        }
    }
}
