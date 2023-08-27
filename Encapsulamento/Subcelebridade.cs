using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Subcelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        // herança
        protected string CorDoOlho = "Verde";

        //mesmo projeto (assembly)
        internal ulong NumeroCelular = 55119999999999;

        //herança
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //mesma classe ou erança no mesmo projeto
        private protected string SegredoFamilia = "Bla Bla";

        // private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
