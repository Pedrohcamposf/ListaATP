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
            Console.WriteLine("\nQuestão 2 - Faça um programa para ler os valores dos catetos de um triângulo retângulo " +
                "e mostrar a hipotenusa.\n\n\nInfome o tamanho do primeiro cateto: ");//enunciado e pedido de entrada
            float a, b, h;//declaração de variáveis
            a = float.Parse(Console.ReadLine());//entrar com o valor de variavel
            Console.WriteLine("Informe o tamanho do segundo cateto: ");//pedido de entrada de variável
            b = float.Parse(Console.ReadLine());//entrar com o valor da variável
            h = (float)Math.Sqrt(Math.Pow(a , 2) + Math.Pow(b , 2));//calculo da hipotenusa
            Console.WriteLine("A hipotenusa do triângulo retangulo é: " + h);//saida de valor da variável
        }
    }
}