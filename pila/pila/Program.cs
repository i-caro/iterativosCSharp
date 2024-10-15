using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Stack stack = new System.Collections.Stack();
            Console.WriteLine("Introduzca 5 valores enteros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            stack.Push(a);
            stack.Push(b);
            stack.Push(c);
            stack.Push(d);
            stack.Push(e);

            foreach (int i in stack) { 
                Console.Write($"{i} ");
            }

        }
    }
}
