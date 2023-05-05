using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L2Q01
    {
        public static void Executar()
        {
            float a, b;
            Console.WriteLine("Dado dois números imprimir somente o maior deles.\n\n" +
                "Ensira o primeiro número: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número: ");
            b = float.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("O maior numero é: " + a);
            }
            else if (b > a)
            {
                Console.WriteLine("O maior número é: " + b);
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }
        }
    }
}