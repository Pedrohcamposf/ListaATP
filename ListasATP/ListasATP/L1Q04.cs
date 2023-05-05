using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L1Q04
    {
        public static void Executar()
        {
            float x1, x2, y1, y2, d;
            Console.WriteLine("Construa um algoritmo que, tendo como dados de entrada dois pontos quaisquer \nno plano, " +
                "p1(x1,y1) e p2(x2,y2), escreva a distância entre eles.\n\nEntre com a posição no eixo x de p1: ");
            x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a posição de no eixo y de p1: ");
            y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a posição de no eixo x de p2: ");
            x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a posição de no eixo y de p2: ");
            y2 = float.Parse(Console.ReadLine());
            d = (float)Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            Console.WriteLine("A distancia entre os dois pontos é igual a: " + d);
        }
    }
}