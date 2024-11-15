using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList.Model
{
    internal class SLList<T>
    {
        public ListNode<T>? Head { get; set; }

        public SLList()
        {
            Head = null;
        }

        public void InsertFirst(T t)
        {
            ListNode<T> tmp = new()
            {
                Value = t,
                Next = Head,
            };
            Head = tmp;
        }

        public void InsertLast(T t)
        {
            ListNode<T> node;

            if (Head is null)
            {
                InsertFirst(t);
                return;
            }

            ListNode<T> tmp = new()
            {
                Value = t,
                Next = null
            };

            // Consume list nodes until reaching the last node
            for (node = Head; node.Next is not null; node = node.Next)
            {

            }
            node.Next = tmp;
        }

        public ListNode<T>? RemoveFirst()
        {
            if (Head is null)
            {
                return null;
            }

            ListNode<T> tmp = Head;
            Head = Head.Next;
            return tmp;
        }

        public ListNode<T>? RemoveLast()
        {
            ListNode<T> node;
            if (Head is null || Head.Next is null)
            {
                return RemoveFirst();
            }

            // Traverse until before last node
            for (node = Head; node.Next!.Next is not null; node = node.Next)
            {

            }
            ListNode<T> tmp = node.Next;
            node.Next = null;
            return tmp;
        }

        public void Traverse()
        {
            if (Head is null)
            {
                Console.WriteLine("Empty List");
                return;
            }

            for (ListNode<T> node  = Head; node.Next is not null; node = node.Next)
            {
                Console.WriteLine($"{node.Value}");
            }
        }
    }
}
