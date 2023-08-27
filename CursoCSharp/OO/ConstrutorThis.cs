using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    public class Animal
    {
        public string Nome { get; set; }

        public Animal (string nome)
        {
            Nome = nome;
        }
    }

        public class Cachorro : Animal 
        { 
            public double Altura { get; set; }
                                            //O método construtor "base" chama os parâmetros da classe pai
            public Cachorro(string nome) : base(nome)
            {
                Console.WriteLine($"Cachorro {nome} inicializado");
            }
                                           //O método construtor "this" chama os paramêtros da classe atual
            public Cachorro (string nome, double altura) : this(nome)
            {   
               Altura = altura;
            }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura";
        }
    }
    internal class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}
