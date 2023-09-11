using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    //Delegate é uma função que requer uma "assinatura";
    //Assinatura seriam os tipos de parametros e o tipo de retorno dessa função
    delegate double Operacao(double x, double y);
    class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(12, 8));

            
        }
    }
}
