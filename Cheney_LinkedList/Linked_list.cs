using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_LinkedList
{
    class Linked_list
    {
        private Node Current;
        public Node Add(Node node, Node NewNode)
        {
            if(node == null)
            {
                return NewNode;
            }

            Current = node;
            while (Current != null)
            {
                if (Current.Next == null)
                {
                    Current.Next = NewNode;
                    break;
                }
                else
                {
                    Current = Current.Next;
                }
            }
            return node;
        }
        public Node Contains(Node node ,string Value)
        {
            Current = node;
            while (Current != null)
            {
                if (Current.Datas != Value)
                {
                    if (Current.Next != null)
                    {
                        Current = Current.Next;
                    }
                    else if(Current.Next == null)
                    {
                        return null;
                    }
                }
                else
                {
                    return Current;
                }
            }
            return node;
        }
        public void Remove(Node node, string Value, out bool Isitnull)
        {
            Isitnull = false;
            Current = node;
            if (Current == null)
            {
                Isitnull = true;
                return;
            }
            if (Current.Datas == Value)
            {
                Current = Current.Next;
                return;
            }

             
            while (Current.Next != null)
            {
                if (Current.Next.Datas == Value)
                {
                    Current.Next = Current.Next.Next;
                    return;
                }

                Current = Current.Next;
            }
            if(Current.Next == null)
            {
                Isitnull = true;
                return;
            }
        }
        public void PrintAll(Node Current)
        {

            while (Current != null)
            {
                Console.WriteLine(Current.Datas);
                if (Current.Next != null)
                    Current = Current.Next;
                else
                    break;
            }
            return;
        }
    }
}
