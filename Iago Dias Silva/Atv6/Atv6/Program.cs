using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, w, y, z;
                double escolha;

            Console.WriteLine("Informe o X");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o W");
            w = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Y");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Z");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a opção");
            Console.WriteLine("1- Geométrica");
            Console.WriteLine("2- Ponderada");
            Console.WriteLine("3- Harmónica");
            Console.WriteLine("4- Aritmética");
            escolha = double.Parse(Console.ReadLine());

            

            if (escolha == 1)
            {
                escolha = Math.Pow(x * y * z, 1.0 / 3.0);
                Console.WriteLine("Média Geométrica é " + escolha);
            }
            else if (escolha == 2)
            {
                escolha = (x + 2 * y + 3 * z) / 6.0;
                Console.WriteLine("Média Ponderada é: " + escolha);
            }
            else if (escolha == 3)
            {
                escolha = 3 / ((1.0 / x) + (1.0 / y) + (1.0 / z));
                Console.WriteLine("Média Harmônica é: " + escolha);
            }
            else if (escolha == 4)
            {
                escolha = (x + y + z) / 3.0;
                Console.WriteLine("Média Aritmética é: " + escolha);
            }

            Console.ReadLine();


        }
    }
}
