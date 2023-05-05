using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class Lista1
    {
        public static void Executar()
        {
            int List1;
            char r;
            Console.WriteLine("\nA Lista 1 possui questões de 1 a 8, qual questão deseja executar?\n ");
            List1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            {
            switch (List1)
                {
                case 1:
                    L1Q01.Executar();
                    break;
                case 2:
                    L1Q02.Executar();
                    break;
                case 3:
                    L1Q03.Executar();
                    break;
                case 4:
                    L1Q04.Executar();
                    break;
                case 5:
                    L1Q05.Executar();
                    break;
                case 6:
                    L1Q06.Executar();
                    break;
                case 7:
                    L1Q07.Executar();
                    break;
                case 8:
                    L1Q08.Executar();
                    break;
                default:
                    Console.WriteLine("Questão inválida. ");
                    Lista1.Executar();
                    break;
                }
                Console.WriteLine("\n\nVocê deseja ver mais alguma questão?\nResponda 's' para sim e 'n' para não ");
                r = char.Parse(Console.ReadLine());
                if (r == 's')
                    Lista1.Executar();
                else
                    Console.WriteLine("\nObrigado e até a proxima.");
            }
        }
    }
}