using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado,escolha;

            Console.WriteLine("Informe o 1 número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 2 número");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Escolha uma opção ");
            Console.WriteLine("1- Somar dois números");
            Console.WriteLine("2. Subtrair dois números");
            Console.WriteLine("3. Multiplicação de dois números");
            Console.WriteLine("4. Divisão de dois números.");
            escolha = double.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine("Sua soma é: " + resultado);

            }
            else if(escolha == 2)
            {
                resultado = num1 - num2;
                Console.WriteLine("Sua subtração é: " + resultado);
            }
            else if (escolha == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine("Sua multiplicação é: " + resultado);
            }
            else if(escolha == 4)
            {
                resultado = num1 / num2;
                Console.WriteLine("Sua divisão é: " + resultado);
            }
            else
            {
                Console.WriteLine(" Informe uma das opções acima");
            }
            Console.ReadLine();
        }
    }
}
