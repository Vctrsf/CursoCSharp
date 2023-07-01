using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {   /*ToUpper - formata o texto para ter todas as letras maiúsculas
              Insert (#, "texto") - insere na casa # (número [0, 1, 2] um texto qualquer.
              Replace - substitui um texto por outro  
            */
            var saudacao = "olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);

            /*"[Texto]." e "[Número #]." = apresentam, respectivamente, funcionalidades tanto de texto
               quanto de números
            */
            Console.WriteLine("Teste".Length);
            //Console.WriteLine(1.CompareTo);

            string valorImportante = null;  
            // "?" - verifica se a variável está vazia ou não
            Console.WriteLine(valorImportante?.Length);
        }   
    }
}
