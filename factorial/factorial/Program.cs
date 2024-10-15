using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero y calcularé el factorial: ");
            int a = int.Parse(Console.ReadLine());
            int b = a;
            for (int i = a-1; i >= 1; i--) {
                b = b * i;
            }
            Console.WriteLine($"El factorial de {a} es: {b}");
        }
    }
}
