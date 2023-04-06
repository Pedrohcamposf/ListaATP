using ListaATP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class Lista
    {
        public static void Executar()
        {
            int List;
            Console.WriteLine("Essa aplicação possui duas listas:\nLista 1 sobre expressões matemáticas\nLista 2 sobre o uso de condicionais." +
                              "\nEntre as duas qual lista você desejaria executar: ");
            List = int.Parse(Console.ReadLine());
            switch (List)
            {
                case 1:
                    Lista1.Executar();
                    break;
                case 2:
                    Lista2.Executar();
                    break;
            }
        }
    }
}