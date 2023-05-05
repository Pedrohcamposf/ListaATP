using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class Lista2
    {
        public static void Executar()
        {
            int List2;
            char r;
            Console.WriteLine("\nA Lista 2 possui questões de 1 a 10, qual questão deseja executar?\n ");
            List2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            {
                switch (List2)
                {
                    case 1:
                        L2Q01.Executar();
                        break;
                    case 2:
                        L2Q02.Executar();
                        break;
                    case 3:
                        L2Q03.Executar();
                        break;
                    case 4:
                        L2Q04.Executar();
                        break;
                    case 5:
                        L2Q05.Executar();
                        break;
                    case 6:
                        L2Q06.Executar();
                        break;
                    case 7:
                        L2Q07.Executar();
                        break;
                    case 8:
                        L2Q08.Executar();
                        break;
                    case 9:
                        L2Q09.Executar();
                        break;
                    case 10:
                        L2Q10.Executar();
                        break;
                    default:
                        Console.WriteLine("Questão inválida. ");
                        Lista2.Executar();
                        break;
                }
            }
                Console.WriteLine("\n\nVocê deseja ver mais alguma questão?\nResponda 's' para sim e 'n' para não ");
                r = char.Parse(Console.ReadLine());
                if (r == 's')
                    Lista2.Executar();
                else
                    Console.WriteLine("\nObrigado e até a proxima.");

            }
        }
    }