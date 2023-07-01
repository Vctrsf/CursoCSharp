using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        /*Tipos de váriaveis
          - Double: váriavel para valores reais, casas decimais;
          - Const: torna a váriavel constante, fazendo com que seu valor não possa ser alterado;
          - bool: assume valores apenas de verdadeiro ou falso; "true","false";
          - byte: usado para armazenar dados que variam de valores entre 0 e 255;
          - sbyte: usado para armazenar dados tanto positivos quanto negativos entre -128 e 127;
          - short: usado para armazenar dados de valor até aproximadamente 32.200;
          - int: variável mais usada, seus valores variam entre -2.147.000 e 2.147.000;
          - uint: variável usada para determinar valores inteiros somente positivos até 2.147.000;
          - long: variável usada para determinar valores inteiros até 9 Quadrilhões;
          - ulong: variável usada para determinar valores semelhantes á variável "long" porém somente positivos;
          - decimal: variável que assume um valor astronômico 
          - char: representa somente um caractere
          - string: usada para escrever texto
        */
        public static void Executar()
        {
            /*Estrutura da váriavel:
              [Tipo de váriavel [texto, número, V/F] -> "Identificador" [nome da váriavel] = [valor da váriavel]
            */
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("idade" + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário" + salario);

            int menorValorInt = int.MinValue; //Mais usados dos inteiros
            Console.WriteLine("Menor inteiro" + menorValorInt);

            uint populaçãoBrasileira = 207_600_000; //uint representa um valor inteiro sem sinal; "unsigned"
            Console.WriteLine("População Brasileira" + populaçãoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long" + menorValorLong);

            ulong populaçãoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial" + populaçãoMundial);

            /*Não confundir double com float; apesar de ambos representarem valore decimais 
            double possui o dobro de armazenamento de byts do que o float, 
            sendo 4 bits do float para 8 do double.
            Sempre determinar se for um float inserindo um "f" depois do valor.
            */

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador" + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; //Mais usado dos reais!!
            Console.WriteLine("Valor Apple" + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas" + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra" + letra);

            string texto = "Seja bem-vindo ao curso de C#";
            Console.WriteLine(texto);

        }
    }
}
