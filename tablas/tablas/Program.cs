using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablas
{
    internal class Program
    {

        static void tabla(int a)
        {
            for (int i = 1; i<11; i++)
            {
                Console.WriteLine($"{a} x {i} = {a*i}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un valor entre el 1 y el 9. Devolveré su tabla de multiplicar: ");
            int a = int.Parse(Console.ReadLine());

            if(a>9 || a<0)
            {
                Console.WriteLine("Valor fuera de rango.");
                Main(args);
            }
            else
            {
                tabla(a);
            }
        }
    }
}
