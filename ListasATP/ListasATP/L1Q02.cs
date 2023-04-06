using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L1Q02
    {
        public static void Executar()
        {
            Console.WriteLine("\nQuestão 2 - Faça um programa para ler os valores dos catetos de um triângulo retângulo e mostrar a hipotenusa.\n\n\nInfome o tamanho do primeiro cateto: ");
            float a, b, h;
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tamanho do segundo cateto: ");
            b = float.Parse(Console.ReadLine());
            h = (float)Math.Sqrt(Math.Pow(a , 2) + Math.Pow(b , 2));
            Console.WriteLine("A hipotenusa do triângulo retangulo é: " + h);
        }
    }
}