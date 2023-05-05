using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L1Q06
    {
        public static void Executar()
        {
            float a, b, aux;
            Console.WriteLine("Faça um programa para ler dois números reais e salvá-los nas variáveis A e B, " +
                "em seguida, \nefetuar a troca dos valores de forma que a variável A passe a ter o valor da \n" +
                "variável B e vice-versa. No final, imprimir os valores finais.\n\nEntre com o valor da variável A: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor da variável B: ");
            b = float.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("Assim trocando-se os valores a variável A é igual a " + a +" \ne a variável B é igual a " + b);
        }
    }
}