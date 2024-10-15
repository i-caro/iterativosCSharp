using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero = random.Next(10, 31);
            Console.WriteLine($"El numero aleatorio entre 10 y 30 obtenido es: {numero}");
        }
    }
}
