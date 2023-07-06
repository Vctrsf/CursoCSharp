using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Pessoa
    {
        /*public - Torna o atributo visível para fora da classe
          string tem valor padrão null        
          Int tem valor padrão 0
         */
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format(
                $"Olá! me chamo {Nome} e tenho {Idade} anos.");
        }
        
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
         
    }
}
