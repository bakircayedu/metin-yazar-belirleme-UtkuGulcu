using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev._2_3
{
    public class Heap
    {
        private int currentSize;
        private int maxSize;
        private HeapNode[] heapArray;

        public Heap(int _maxSize)
        {
            currentSize = 0;
            maxSize = _maxSize;
            heapArray = new HeapNode[maxSize];
        }

        public bool Insert(object data, int frequency)
        {
            if (currentSize == maxSize)
            {
                return false;
            }

            HeapNode newNode = new HeapNode(data, frequency);
            heapArray[currentSize] = newNode;
            MoveToUp(currentSize++);
            return true;
        }

        private void MoveToUp(int index)
        {
            int parent = GetParent(index);
            HeapNode bottom = heapArray[index];

            while (index > 0 && bottom.Count > heapArray[parent].Count)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = GetParent(parent);
            }

            heapArray[index] = bottom;
        }

        public HeapNode RemoveMax()
        {
            HeapNode root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }

        private void MoveToDown(int index)
        {
            int largerChild;
            HeapNode top = heapArray[index];

            while (index < currentSize / 2)
            {
                int leftChild = GetLeftChild(index);
                int rightChild = GetRightChild(index);

                if (rightChild < currentSize && heapArray[leftChild].Count < heapArray[rightChild].Count)
                {
                    largerChild = rightChild;
                }
                else
                {
                    largerChild = leftChild;
                }

                if (top.Count >= heapArray[largerChild].Count)
                {
                    break;
                }

                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }

            heapArray[index] = top;
        }

        public HeapNode[] Sort()
        {
            Heap copy = new Heap(heapArray.Length);
            HeapNode[] sorted = new HeapNode[heapArray.Length];

            for (int i = 0; i < heapArray.Length; i++)
            {
                copy.Insert(heapArray[i].Data, heapArray[i].Count);
            }

            int j = 0;

            while (!copy.IsEmpty())
            {
                sorted[j++] = copy.RemoveMax();
            }
            return sorted;
        }

        public bool IsEmpty()
        {
            if (currentSize == 0)
            {
                return true;
            }
            return false;
        }

        private int GetParent(int index) => (index - 1) / 2;
        private int GetLeftChild(int index) => 2 * index + 1;
        private int GetRightChild(int index) => 2 * index + 2;
    }
}
