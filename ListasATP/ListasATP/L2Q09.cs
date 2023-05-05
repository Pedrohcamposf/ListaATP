using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L2Q09
    {
        public static void Executar()
        {
            Console.WriteLine("Fazer um programa para:\nler um símbolo do teclado;" +
                "\nidentificar com a estrutura SWITCH e mostrar as seguintes mensagens, segundo o" +
                "\ncaso:\no \"SINAL DE MENOR\"\no \"SINAL DE MAIOR\"\no \"SINAL DE IGUAL\"\no \"OUTRO SINAL\"\n\nEntre com o sinal: ");
            char sin;
            sin = char.Parse(Console.ReadLine());
            switch (sin)
            {
                case '+':
                    Console.WriteLine("Sinal de maior");
                    break;
                case '-':
                    Console.WriteLine("Sinal de menor");
                    break;
                case '=':
                    Console.WriteLine("Sinal de igual");
                    break;
                default:
                    Console.WriteLine("Outro sinal");
                    break;
            }

        }
    }
}