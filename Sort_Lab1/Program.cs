using System;
using System.Diagnostics;

namespace Lab1_Sort
{
    class Program
    {
        public static long N_op = 0;
        static void Main(string[] args)
        {
            // Стек на массиве с сортировкой распределяющим подсчётом (86 вариант)
            var sw = new Stopwatch();
            const int VALUES = 100, COUNT_OF_NUMBERS = 1000;
            Stack stack = new Stack();
            Random rnd = new Random();
            for (int i = 0; i < COUNT_OF_NUMBERS; i++)
                stack.Push(rnd.Next(1, VALUES));
            stack.Print();

            sw.Start();
            Stack stack_2 = new Stack(); Program.N_op += 2;
            Program.N_op += 2;
            for (int i = 0; i < VALUES; i++)
            {
                Program.N_op += 2;
                stack_2.Push(0);
                Program.N_op += 2;
            }
            Program.N_op += 4;
            for (int i = 0; i < stack.GetCount(); i++)
            {
                Program.N_op += 4;
                stack_2.Set(stack_2.Get(stack.Get(i)) + 1, stack.Get(i));
                Program.N_op++;
            }

            int pos = 0; Program.N_op++;
            Program.N_op += 4;
            for (int i = 0; i < stack_2.GetCount(); i++)
            {
                Program.N_op += 4;
                Program.N_op += 5;
                for (int j = 0; j < stack_2.Get(i); j++, pos++)
                {
                    Program.N_op += 5;
                    stack.Set(i, pos);
                    Program.N_op += 3;
                }
            }
            sw.Stop();
            stack.Print();
            Console.WriteLine("N_op = " + N_op + " T_n = " + sw.Elapsed);
        }
    }
}