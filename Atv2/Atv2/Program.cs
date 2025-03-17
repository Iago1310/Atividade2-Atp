using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Informe o valor");
            valor = int.Parse(Console.ReadLine());

            if (valor == 0 )
            {
                Console.WriteLine("ZERO");
            }
            else if (valor == 1 )
            {
                Console.WriteLine("UM");
            }
            else if (valor == 2 )
            {
                Console.WriteLine("DOIS");
            }
            else if (valor == 3 )
            {
                Console.WriteLine("TRES");
            }
            else if (valor == 4 )
            {
                Console.WriteLine("QUATRO");
            }
            else if (valor == 5 )
            {
                Console.WriteLine("CINCO");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }

        }
    }
}
