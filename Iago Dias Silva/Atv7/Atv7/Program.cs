using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv7
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;

            Console.WriteLine("Informe um número");
            num1 = double.Parse(Console.ReadLine());

            if (num1 % 3 == 0 && num1 % 5 == 0)
            {
                Console.WriteLine("Número divisivel por 3 é por 5");
            }
            else
            {
                Console.WriteLine("Número não é divisivel por 3 é por 5");
            }
        }
    }
}
