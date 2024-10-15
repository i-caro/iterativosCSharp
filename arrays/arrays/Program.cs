using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el tamaño deseado del array: ");
            int a = int.Parse(Console.ReadLine());
            int[] lista = new int[a];
            Console.WriteLine("Ahora introduzca tantos valores como tamaño tenga su array: ");
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                lista[i]= b;
            }
            
            for (int i = 0;i < lista.Length; i++)
            {
                string par = "(Par)";
                string impar = "(Impar)";
                string c = lista[i].ToString();
                Console.Write($"{c}, {(lista[i]%2==0?par:impar)} ");
            }
            
        }
    }
}
