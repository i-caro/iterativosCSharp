using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estadoCivil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte su estado civil abreviado (C, S, V, D): ");
            string x = Console.ReadLine();
            switch (x.ToUpper()) {
                case "C":
                    Console.WriteLine("Tu estado civil es casad@");
                    break;
                case "D":
                    Console.WriteLine("Tu estado civil es divorciad@");
                    break;
                case "S":
                    Console.WriteLine("Tu estado civil es solter@");
                    break;
                case "V":
                    Console.WriteLine("Tu estado civil es viud@");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta.");
                    Main(args);
                    break;
            }
        }
    }
}
