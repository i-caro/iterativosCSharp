using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace costeLuz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la cantidad de kilowatios consumidos: ");
            int kw = int.Parse(Console.ReadLine());

            if (kw > 1800) {
                Console.WriteLine($"El precio es de: {kw*0.8} euros.");
            }else if (kw >= 1000 && kw <= 1800)
            {
                Console.WriteLine($"El precio es de: {kw*0.12} euros.");
            }else if(kw < 1000)
            {
                Console.WriteLine($"El precio es de: {kw * 0.14} euros.");
            }
        }
    }
}
