using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);


            //valor do switch é um valor numérico
            switch (nota)
            {
                //case -> caso; situação
                case 0:
                    Console.WriteLine("Péssimo");
                    //break -> fim do loop "case" dependendo de qual valor o usuário colocou
                    break;
                    
                    
                        case 1:
                        case 2:
                            Console.WriteLine("Ruim");
                            break;
                        case 3:
                            Console.WriteLine("Regular");
                            break;
                        case 4:
                            Console.WriteLine("Boa");
                            break;
                        case 5:
                            Console.WriteLine("Ótimo");
                            break;
                        default:
                            Console.WriteLine("Nota inválida");
                            break;
             }
                    Console.WriteLine("Obrigado por avaliar!");

         }

     }
 }

