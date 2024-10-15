using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abecedario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 90; i > 64; i--)
            {
                Console.Write(Convert.ToString((char)i).ToUpper()+" ");
            }
        }
    }
}
