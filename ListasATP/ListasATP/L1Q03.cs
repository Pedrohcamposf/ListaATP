using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L1Q03
    {
        public static void Executar()
        {
            Console.WriteLine("\nQuestão 3 - Sabendo que 100 kilowatt de energia custa um sétimo do salário mínimo, faça um" +
                " programa para \nler o valor do salário mínimo e a quantidade de kilowatt gasta em uma" +
                " residência, calcular e mostrar: \no valor em reais de cada kilowatt;o valor em reais a ser" +
                " pago; e o novo valor a ser pago por essa \nresidência com um desconto de 10%.\n\n\nEntre com o valor do salário mínimo: ");
            float sm, wc, wv;
            sm = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantos Kilowatt são consumidos mensalmente na residencia? ");
            wc = float.Parse(Console.ReadLine());
            wv = sm / 700;
            Console.WriteLine("A partir do consumo informado o valor a ser pago é: "+wv * wc);
            Console.WriteLine("Considerando um desconto de 10% o valor a ser pago é: " + wv * wc * 0.9);
        }
    }
}