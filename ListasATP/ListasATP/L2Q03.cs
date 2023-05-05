using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L2Q03
    {
        public static void Executar()
        {
            float a, b, x;
            Console.WriteLine("Faça um programa para ler os coeficientes de uma equação do primeiro grau (ax + b = 0)," +
                "\ncalcular e escrever a raiz da equação.\n\nEntre com o valor de A: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B: ");
            b = float.Parse(Console.ReadLine());
            x = (-b / a);
            Console.WriteLine("O raiz da esqueção de primeiro grau é: " + x);
        }
    }
}