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
            Console.WriteLine("\nA Lista 1 possui questões de 1 a 8, qual questão deseja executar? ");
            List1 = int.Parse(Console.ReadLine());
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
            }
        }
    }
}