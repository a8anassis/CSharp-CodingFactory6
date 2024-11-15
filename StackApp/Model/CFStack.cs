using StackApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp.Model
{
    internal class CFStack
    {
        public int[] Stack { get; set; }
        public int Top { get; set; }
        public int Size { get; set; }

        public CFStack() 
        {
            Size = 100;
            Stack = new int[100];
            Top = -1;
        }

        public CFStack(int size)
        {
            Size = size;
            Stack = new int[size];
            Top = -1;
        }

        public bool IsFull()
        {
            return Top == Size -1;
        }

        public bool IsEmpty()
        {
            return Top == -1;
        }

        public void Push(int num)
        {
            if (IsFull())
            {
                throw new StackIsFullException("Error. Stack is full");
            }

            Stack[++Top] = num;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new StackIsEmptyException("Error. Stack is empty");
            }
            return Stack[Top--];
        }

        public void Traverse()
        {
            for (int i = 0; i <= Top; i++)
            {
                Console.Write(Stack[i] + " ");
            }
        }
    }
}
