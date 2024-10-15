using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 2, 5, 7, 1, 4, 9, 3, 8, 0, 6 };
            System.Array.Sort(lista);
            for (int i = 0; i < lista.Length; i++) {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
