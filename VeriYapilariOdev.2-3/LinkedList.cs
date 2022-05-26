using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev._2_3
{
    public class LinkedList
    {
        public HashNode Head { get; set; }

        public void InsertLast(string text)
        {
            HashNode newLast = new HashNode(text);
            HashNode oldLast = new HashNode();

            if (Head == null)
            {
                Head = newLast;
                return;
            }

            oldLast = Head;

            while (oldLast.Next != null)
            {
                oldLast = oldLast.Next;
            }

            oldLast.Next = newLast;
        }
    }
}
