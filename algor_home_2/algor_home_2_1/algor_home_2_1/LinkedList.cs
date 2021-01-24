using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algor_home_2_1
{
    public class LinkedList : ILinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }
        public LinkedList() { }
        public void AddNode(int value)
        {
            var item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.NextNode = item;
                item.PrevNode = Tail;
            }
            Tail = item;
            Count++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            var item = new Node(value);
            var current = Head;
            while(current != null)
            {
                if(current.Value == node.Value)
                {
                    item.PrevNode = current;
                    item.NextNode = current.NextNode;
                    if(current.NextNode == null)
                    {
                        current.NextNode = item;
                        Tail = item;
                    }
                    else
                    {
                        current.NextNode.PrevNode = item;
                        current.NextNode = item;
                    }
                    Count++;
                    return;
                }
                current = current.NextNode;
            }
        }

        public Node FindNode(int searchValue)
        {
            var current = Head;
            while (current != null)
            {
                if(current.Value == searchValue)
                {
                    return current;
                }
                current = current.NextNode;
            }
            return new Node();
        }

        public int GetCount()
        {
            return Count;
        }

        public void RemoveNode(int index)
        {
            var current = Head;
            int i = 0;
            while (current != null)
            {
                if(index == i)
                {
                    if (current != null)
                    {
                        if (current.NextNode != null)
                        {
                            current.NextNode.PrevNode = current.PrevNode;
                        }
                        else
                        {
                            Tail = current.PrevNode;
                        }

                        if (current.PrevNode != null)
                        {
                            current.PrevNode.NextNode = current.NextNode;
                        }
                        else
                        {
                            Head = current.NextNode;
                        }
                        Count--;
                        return;
                    }
                }
                current = current.NextNode;
                i++;
            }
        }

        public void RemoveNode(Node node)
        {
            var current = Head;
            int i = 0;
            while (current != null)
            {
                if (current.Value == node.Value)
                {
                    if (current != null)
                    {
                        if (current.NextNode != null)
                        {
                            current.NextNode.PrevNode = current.PrevNode;
                        }
                        else
                        {
                            Tail = current.PrevNode;
                        }

                        if (current.PrevNode != null)
                        {
                            current.PrevNode.NextNode = current.NextNode;
                        }
                        else
                        {
                            Head = current.NextNode;
                        }
                        Count--;
                        return;
                    }
                }
                current = current.NextNode;
                i++;
            }
        }
    }
}
