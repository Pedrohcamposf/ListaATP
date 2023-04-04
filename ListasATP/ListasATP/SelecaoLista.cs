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
            int resposta;
            Console.WriteLine("Entre com o numero da questao");
            resposta = int.Parse(Console.ReadLine());
            switch (resposta)
            {
                case 4:
                    Questao4.Executar();
                    break;
                case 5:
                    Questao5.Executar();
                    break;
            }
        }
    }
}