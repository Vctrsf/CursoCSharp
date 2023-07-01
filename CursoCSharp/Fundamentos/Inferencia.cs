using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            //Inferência - reconhecimento de determinado dado em uma variável cujo a própria linguagem determina.

            var nome = "Leonardo";
            //nome = 123 -> A inferência não aceita outro valor para o dado referido na variável
            Console.WriteLine(nome);

            //int idade
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
        }



    }
} 
