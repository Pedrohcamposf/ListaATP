using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L1Q08
    {
        public static void Executar()
        {
            Console.WriteLine("Faça um programa para ler uma conta corrente (sempre com 3 dígitos) e imprimir seu" +
                "dígito verificador \nque é calculado da seguinte maneira:" +
                "\n\na) Some o número da conta com seu inverso (CDU + UDC);" +
                "\nb) Multiplicar cada dígito da soma por sua posição, sendo que a posição das centenas é 1," +
                "\ndas dezenas é 2 e das unidades é 3;\nc) Somar cada uma das multiplicações;" +
                "\nd) O dígito verificador é o último dígito da soma anterior.\n" +
                "\nInsira o valor de sua conta corrente com 3 digitos");
            int cc = 0; //declarando variavel conta corrente
            Console.WriteLine("Insira o valor de sua conta corrente com 3 digitos");
            cc = int.Parse(Console.ReadLine());

            int c, d, u;//declaração de variavel

            c = cc / 100;//transformando a centena em algarismo
            d = cc % 100 / 10;//transformando a dezena em algarismo
            u = cc % 100 % 10;//transformando a unidade em algarismo

            int numInv = (u * 100) + (d * 10) + c;//transformando unidade em centena, dezena em dezena e centena em unidade

            int sdi = cc + numInv;
            int ce, de, un;//declarando variavel

            ce = sdi / 100; 
            de = sdi % 100 / 10;
            un = sdi % 100 % 10;

            int mds = (ce * 1) + (de * 2) + (un * 3);

            int dv = (mds % 100) % 10;

            Console.WriteLine("O digito verificador da sua conta corrente é {0}", dv);
        }
    }
}