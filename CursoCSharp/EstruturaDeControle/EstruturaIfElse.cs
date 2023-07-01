using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;
            //double nota;

            /*Console.Write("Digite a nota do aluno: ");
            
                nota = double.Parse(Console.ReadLine());
            */

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais do que sua obrigação...");

            }
            else
            {
                    Console.WriteLine("Recuperação");
            }
        }
    }
}
