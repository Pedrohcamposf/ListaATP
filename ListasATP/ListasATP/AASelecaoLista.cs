using ListaATP;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            Console.WriteLine("Essa aplicação possui duas listas:\nLista 1 sobre expressões matemáticas;\nLista 2 sobre o uso de condicionais." +
                              "\n\nEntre as duas listas, qual lista você desejaria executar: ");
            List = int.Parse(Console.ReadLine());
            if (List == 1)
            {
                Lista1.Executar();
            }
            else if (List == 2)
            {
                Lista2.Executar();
            }
            else
            {
                Console.WriteLine("Entre com uma lista válida.\n\n");
                Lista.Executar();
            }
        }
    }
}