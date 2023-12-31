﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class CalculadoraEstatica
    {
        /*Quando não usa a palavra "static", o método não pertence mais ao objeto, e sim a classe
         * necessitando então, usar uma instância/objeto
         */
        
        //Método de instância
        public int Somar(int a, int b)
  
        {
            return a + b;
        }
        //Método de Classe ou Método estático!
        //o método sem "static" só se torna acessível a partir da instância
        public static int Multiplicar(int a, int b) 

        {
            return a * b;
        }
    }
    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
