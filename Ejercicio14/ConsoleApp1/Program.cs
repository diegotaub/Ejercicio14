using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la primera frase: ");
            string frase = Console.ReadLine();
            Console.Write("Ingrese la segunda frase: ");
            if(Console.ReadLine().ToUpper() == frase.ToUpper())
            {
                Console.Write("Las frases son iguales.");
            }
            else
            {
                Console.Write("Las frases son diferentes.");
            }
            Console.ReadKey();
        }
    }
}
