using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            //ToString - transforma o valor numerico em string
            //F# - converte o valor numérico dependendo da quantidade de casas escolhidas depois do "F"
            Console.WriteLine(valor.ToString("F1"));
            //"C" - Currency [Moeda]
            Console.WriteLine(valor.ToString("C"));
            //"P" - Percentual
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));


        }
    }
}
