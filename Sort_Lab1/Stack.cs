using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Sort
{
    class Stack
    {
        private List<int> stack = new List<int>();
        public int GetCount()
        {
            Program.N_op++;
            return stack.Count;
        }
        public void Push(int value)
        {
            stack.Add(value); Program.N_op += 3;
        }
        public int Pop()
        {
            int value = stack[stack.Count - 1]; Program.N_op += 4;
            stack.RemoveAt(stack.Count - 1); Program.N_op += 5;
            return value;
        }
        public int Get(int position)
        {
            Stack tempStack = new Stack(); Program.N_op += 2;
            Program.N_op += 4;
            for (int i = GetCount() - 1; i > position; i--)
            {
                Program.N_op += 2;
                tempStack.Push(Pop());
                Program.N_op += 2;
            }
            int value = stack[position]; Program.N_op += 2;
            Program.N_op += 4;
            for (int i = tempStack.GetCount(); i > 0; i--)
            {
                Program.N_op += 2;
                Push(tempStack.Pop());
                Program.N_op += 2;
            }
            return value;
        }
        public void Set(int value, int position)
        {
            Stack tempStack = new Stack(); Program.N_op += 2;
            Program.N_op += 4;
            for (int i = GetCount() - 1; i > position; i--)
            {
                Program.N_op += 2;
                tempStack.Push(Pop());
                Program.N_op += 2;
            }
            stack[position] = value; Program.N_op += 2;
            Program.N_op += 4;
            for (int i = tempStack.GetCount(); i > 0; i--)
            {
                Program.N_op += 2;
                Push(tempStack.Pop());
                Program.N_op += 2;
            }
        }
        public void Print()
        {
            foreach (int i in stack)
                Console.Write(i + " ");
            Console.WriteLine("____________________");
        }
    }
}