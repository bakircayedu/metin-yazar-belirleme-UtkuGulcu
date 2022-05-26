using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev._2_3
{
    public class WordStack : StackADT
    {
        public object ReturnElements()
        {
            StackNode temp = new StackNode(null, null, 0);
            temp = Top;
            string info = String.Empty;
            while (temp.Next != null)
            {
                info += temp.Data + "  // Cümlede Kaçıncı kelime: " + temp.Count+ Environment.NewLine;
                temp = temp.Next;
            }

            info += temp.Data + "  // Cümlede Kaçıncı kelime: " + temp.Count + Environment.NewLine;
            return info;
        }

        public List<StackNode> ReturnList()
        {
            StackNode temp = new StackNode(null, null, 0);
            temp = Top;
            List<StackNode> elements = new List<StackNode>();

            while (temp.Next != null)
            {
                elements.Add(temp);
                temp = temp.Next;
            }

            elements.Add(temp);
            return elements;
        }
    }
}
