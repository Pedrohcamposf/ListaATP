using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L1Q05
    {
        public static void Executar()
        {
            Console.WriteLine("Uma pessoa resolveu fazer uma aplicação em uma poupança programada em que o valor" +
                "acumulado \né igual a p * ((1+i^)^n –1) / i, onde p é a aplicação mensal, i é a taxa e n é o " +
                "número \nde meses. Faça um programa para ler o valor constante da aplicação mensal, a taxar" +
                "\ne o número de meses, calcular e mostrar o rendimento.");
            double p, i, n, ren;//declarando as variáveis aplicação mensal (p), taxa (i), numero de meses (n), rendimento (ren)
            Console.WriteLine("Insira o valor da aplicação mensal: "); //atribuindo valor a variavel p
            p = double.Parse(Console.ReadLine()); //convertendo p 'string' em p 'double'

            Console.WriteLine("Insira a taxa: "); //atribuindo valor a variavel i
            i = double.Parse(Console.ReadLine()); //convertendo i 'string' em i 'double'

            Console.WriteLine("Insira o número de meses: "); //atribuindo valor a variavel n
            n = double.Parse(Console.ReadLine()); //convertendo n 'string' em n 'double'

            ren = p * (Math.Pow((1 + i), n) - 1) / i;//calculando o rendimento mensal
            Console.WriteLine("O rendimento mensal foi de: "+ ren); //resultado do rendimento mensal
        }
    }
}