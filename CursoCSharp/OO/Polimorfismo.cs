using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }

        public Comida() 
        {
            
        }
    }
    public class Feijão : Comida
    {
        public Feijão (double peso) : base(peso)
        {

        }
        
    }
    
    public class Arroz : Comida
    {
        
    }

    public class Carne : Comida
    {
        
    }

    public class Pessoa
    {
        public double Peso;

        //public void Comer(Feijão feijão)
        //{
        //    Peso += feijão.Peso;
        //}

        //public void Comer(Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne)
        //{
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }
    }
    internal class Polimorfismo
    {
        public static void Executar()
        {
            Feijão ingrediente1 = new Feijão(0.3);
            

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}Kg!");
        }
    }
}
