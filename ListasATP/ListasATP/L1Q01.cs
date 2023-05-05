using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L1Q01
    {
        public static void Executar()
        {
            Console.WriteLine("\nQuestão 1 - Faça um programa para ler a base e a altura de um retângulo e mostrar seu perímetro, área e diagonal.\n\n\nEntre com a base do retângulo: ");//texto para o usuario
           float b, h, a, d, p;//declaração de variáveis
            b = float.Parse(Console.ReadLine());//entrada da base
            Console.WriteLine("Entre com a altura do retângulo: ");//texto para o usuario
            h = float.Parse(Console.ReadLine());//entrada da altura
            p = (2 * h) + (2 * b);//calculo de perímetro
            a = h * b;//calculo de área
            d = (float)Math.Sqrt(Math.Pow(h,2) + Math.Pow(b,2));//calculo da diagonal
            Console.WriteLine("Com a base e altura informada o retângulo possui os seguintes parametros:\nPerímetro = " + p +"\nÁrea = " + a +"\nDiagonal = "+d); //saida da resposta para o usuario
        }
    }
}