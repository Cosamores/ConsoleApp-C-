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
            var nome = "Diego";
            var idade = 32;

            bool MaiorDeIdade = idade > 18;

            Console.WriteLine(nome + " tem " + idade + " anos de idade.");

            Console.ReadKey(); 

        }
    }
}
