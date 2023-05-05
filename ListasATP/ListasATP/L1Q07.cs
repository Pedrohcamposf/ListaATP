using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L1Q07
    {
        public static void Executar()
        {
            int dias = 0;
            int day = 0;
            int month = 0;
            int year = 0;
            Console.WriteLine("Faça um programa que leia quantidade de dias sem acidentes em uma empresa. Depois\n" +
                "apresente os dias sem acidentes separados em anos, meses e dias. Considere que " +
                "\n1 ano tem 365 dias e um mês tem 30 dias\r\nExemplo:\r\nEntrada: 400 dias\r\nSaída: 1 ano, 1 mês e 5 dias\n\n" +
                "Entre com o número de dias sem acidentes: ");
            dias = int.Parse(Console.ReadLine());

            if (dias >= 365) //se dias sem acidente for maior do que 365
            {
                year = dias / 365; //ano = dias sem acidente divido por 365
                dias = dias - (year * 365); //transforma a variável dsa em m
            }

            if (dias >= 30) //se dias sem acidente for maior que 30
            {
                month = dias / 30; //mês = dias sem acidente divido por 30
                dias = dias - (month * 30); //transforma a variavel dsa em d
            }

            if (dias < 30) //se dias sem acidente for maior que 0
            {
                day = dias % 30; //dias = dias sem acidente + resto da divisão por 30
            }

            Console.WriteLine("Estamos a {0} ano(s), {1} mes(es) e {2} dia(s) sem acidente\n", year, month, day);
        }
    }
}
