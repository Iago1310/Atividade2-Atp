using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2, idade3;
          

            Console.WriteLine("Informe sua idade ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade ");
            idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade ");
            idade3 = int.Parse(Console.ReadLine());

            int MaiorId = idade1;
            int MenorId = idade1;

            if (idade2 > MaiorId)
            {
                MaiorId = idade2;
                
            }
            if (idade3 > MaiorId)
            {
                MaiorId = idade3;
            }
            if (idade2 < MenorId)
            {
                MenorId = idade2;
            }
            if (idade3 < MenorId)
            {
                MenorId = idade3;
            }
            Console.WriteLine("Sua maior idade é: " + MaiorId);
            Console.WriteLine("Sua menor idade é: " + MenorId);
            Console.ReadLine();
        }
    }
}
