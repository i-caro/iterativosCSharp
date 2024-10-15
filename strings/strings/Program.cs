using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca algo: ");
            string x = Console.ReadLine();

            Console.WriteLine($"Longitud: {x.Length}, ¿Contiene www?:{x.Contains("www")}, Reemplazo de 'a' por 'e': {x.Replace("a", "e")}");
            Console.WriteLine($"A mayúsculas: {x.ToUpper()}, A minúsculas: {x.ToLower()}, Eliminar tercer carácter: {x.Remove(2, 1)}");
            Console.WriteLine($"Obtener sub cadena desde el 4 caracter hasta el 7: {x.Substring(3, 6)}");   
        }
    }
}
