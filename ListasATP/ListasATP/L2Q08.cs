using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L2Q08
    {
        public static void Executar()
        {
            double salario = 0;
            double salariomod = 0;
            Console.WriteLine("Construa um programa que lê uma opção conforme abaixo (usar estrutura SWITCH) e o" +
                "\nsalário atual do funcionário, calcula e exibe o novo salário:\nA = aumento de 8% no salário;" +
                "\nB = aumento de 11% no salário;\nC = aumento fixo no salário\n(de R$ 350,00 se o salário atual for até " +
                "R$ 1000 e de R$ 200,00 se o salário atual for maior que R$ 1000).\n\nEntre com o valor do salario");
            salario = double.Parse(Console.ReadLine());
            salariomod = salario * 1.08;
            Console.WriteLine("Caso A:\nO salario com aumento de 8% seria de {0:f2}R$\n", salariomod );
            salariomod = salario * 1.11;
            Console.WriteLine("Caso B:\nO salario com aumento de 11% seria de {0:f2}R$\n", salariomod);
            switch (salario)
            {
                case <= 1000:
                    salariomod = salario + 350;
                    Console.WriteLine("Caso C:\nO novo salário com aumento seria de {0:f2}R$", salariomod);
                    break;
                case > 1000:
                    salariomod = salario + 200;
                    Console.WriteLine("Caso C:\nO novo salário com aumento seria de {0:f2}R$", salariomod);
                    break;
            }
        }
        }
}