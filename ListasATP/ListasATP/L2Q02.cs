using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L2Q02
    {
        public static void Executar()
        {
            int a, b, c;
            Console.WriteLine("Faça um algoritmo que leia 2 números inteiros e faça sua adição. Se o resultado for maior ou igual" +
                "\na 10, some 5 a este número. Caso contrário some 7 a ele. Imprima o resultado final.\n\nEntre com o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número: ");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            if (c >= 10)
            {
                Console.WriteLine("Como o resultado da adição dos dois números é maior ou igual que 10 o resultado final é: " + (c + 5) );
            }
            else
            {
                Console.WriteLine("Como é resultado da adição dos dois números é menor que 10 o resultado final é: " + (c + 7));
            }
        }
    }
}
