using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList.Model
{
    internal class ListNode<T>
    {
        public T? Value { get; set; }
        public ListNode<T>? Next { get; set; }
    }
}
