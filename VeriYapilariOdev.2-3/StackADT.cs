using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev._2_3
{
    public abstract class StackADT
    {
        public int Size = 0;
        public StackNode Top;

        public void Push(object item, object wordCount, int nodeType, int count)
        {
            //0 : sentence 1: word 2: unique word

            if (IsEmpty())
            {
                if (nodeType == 0)
                {
                    StackNode newNode = new StackNode(item, wordCount, count);
                    Top = newNode;
                    Size++;
                }
                else
                {
                    string processedWord = String.Empty;

                    foreach (var letter in item.ToString())
                    {
                        if (Char.IsPunctuation(letter))
                        {
                            break;
                        }

                        processedWord += letter;
                    }

                    if (!String.IsNullOrEmpty(processedWord))
                    {
                        StackNode newNode = new StackNode(item, wordCount, count, processedWord);
                        Top = newNode;
                        Size++;
                    }
                }
            }
            else
            {
                //if (nodeType == 2)
                //{
                //    Node nodeToCheck = new Node(item, wordCount);
                //    Node checkedNode = FindDuplicate(nodeToCheck);

                //    if (checkedNode == null)
                //    {
                //        nodeToCheck.Next = Top;
                //        Top = nodeToCheck;
                //        Size++;
                //    }
                //    else
                //    {
                //        IncreaseWordCount(checkedNode);
                //    }
                //}
                //else
                //{
                //    Node newNode = new Node(item, wordCount);
                //    newNode.Next = Top;
                //    Top = newNode;
                //    Size++;
                //}

                if (nodeType == 0)
                {
                    StackNode newNode = new StackNode(item, wordCount, count);
                    newNode.Next = Top;
                    Top = newNode;
                    Size++;
                }
                else
                {
                    string processedWord = String.Empty;
                    
                    foreach (var letter in item.ToString())
                    {
                        if (Char.IsPunctuation(letter))
                        {
                            break;
                        }

                        processedWord += letter;
                    }

                    if (nodeType == 2 && !String.IsNullOrEmpty(processedWord))
                    {
                        StackNode nodeToCheck = new StackNode(item, wordCount, count, processedWord);
                        StackNode checkedNode = FindDuplicate(nodeToCheck);

                        if (checkedNode == null)
                        {
                            nodeToCheck.Next = Top;
                            Top = nodeToCheck;
                            Size++;
                        }
                        else
                        {
                            IncreaseWordCount(checkedNode);
                        }

                        return;
                    }

                    if (!String.IsNullOrEmpty(processedWord))
                    {
                        StackNode newNode = new StackNode(item, wordCount, count, processedWord);
                        newNode.Next = Top;
                        Top = newNode;
                        Size++;
                    }
                }
            }
        }

        private void IncreaseWordCount(StackNode nodeToIncrement)
        {
            StackNode prev = new StackNode(null, null, 0);
            prev = Top;

            while (prev.Next != null)
            {
                if (String.Equals(prev.Next.Data.ToString(), nodeToIncrement.Data.ToString()))
                {
                    int newCount = (int)prev.Next.WordCount;
                    prev.Next.WordCount = ++newCount;
                }
                prev = prev.Next;
            }
        }

        private StackNode FindDuplicate(StackNode _nodeToCheck)
        {
            StackNode temp = new StackNode(null, null, 0);
            temp = Top;

            while (temp.Next != null)
            {
                if (String.Equals(temp.Data.ToString(), _nodeToCheck.Data.ToString()))
                {

                    return temp;
                }

                temp = temp.Next;
            }

            if (String.Equals(temp.Data.ToString(), _nodeToCheck.Data.ToString()))
            {
                return temp;
            }

            return null;
        }

        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }

            return false;
        }
    }
}
