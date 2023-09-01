using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        //Um método abstrato é isento de corpo
        public abstract string Assistente();

        public string Tocar()
        {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }

        public class Iphone : Celular
        {
            public override string Assistente()
            {
                return "Olá! Meu nome é Siri!";
            }
        }
        internal class Abstract
        {
            public static void Executar()
            {
                //Não é possivel Instanciar uma classe abstrata 
                //Celular c = new Celular();
                var celulares = new List<Celular>
                {
                    new Iphone(),
                    new Samsung()
                };

                foreach (var celular in celulares)
                {
                    Console.WriteLine(celular.Assistente());
                }
            }
        }
    }
}
