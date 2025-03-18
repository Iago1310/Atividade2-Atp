using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, tempocarteira;
            char habilitacao;
            Console.WriteLine("informe sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu tipo de habilitação");
            habilitacao = char.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu tempo de carteira");
            tempocarteira = int.Parse(Console.ReadLine());


            if (idade >= 21  && (habilitacao == 'B' && tempocarteira >= 2  || habilitacao == 'C' && tempocarteira >= 1 ))
            {
                Console.WriteLine("Parabens você pode tirar a carteira D");
            }
            else
            {
                Console.WriteLine("Você não tem os requisitos permitidos:  " + idade  + " " + tempocarteira + " " + habilitacao);
            }
        }
    }
}
