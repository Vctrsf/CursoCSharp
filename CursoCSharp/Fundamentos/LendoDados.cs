using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class LendoDados
    {
        public static void Executar()

        {
            Console.Write("Qual é seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");

            /* Parse - transforma o texto em string
               "1" => 1
            */

            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine());

                //CultureInfo.InvariantCulture 

            Console.WriteLine($"{nome}, {idade}, R${salario}");
        }
    }
}
