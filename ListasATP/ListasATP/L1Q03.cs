﻿using System;
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
                " programa para ler o valor do salário mínimo e a quantidade de kilowatt gasta em uma" +
                " residência, calcular e mostrar: o valor em reais de cada kilowatt; o valor em reais a ser" +
                " pago; e o novo valor a ser pago por essa residência com um desconto de 10%.\n\n\nEntre com o valor do salário mínimo: ");
            float sm, watts, wc, wv, vp, vd;
            sm = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantos Kilowatt são consumidos mensalmente na residencia? ");
            wc = float.Parse(Console.ReadLine());
            wv = sm / 700;
            
        }
    }
}