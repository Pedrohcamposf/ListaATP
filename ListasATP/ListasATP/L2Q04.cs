using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L2Q04
    {
        public static void Executar()
        {
            int ano, idade;
            //usar char para ocupar menos espaço de processamento pois nao precisa mais do que 1 caracter
            char res;
            Console.WriteLine("Faça um algoritmo que leia o ano de nascimento de uma pessoa e calcule sua idade," +
                "\nconsiderando o ano atual. Para verificar se já fez aniversário no ano atual pergunte se a" +
                "\npessoa já fez aniversário, sendo que ela pode entrar com a informação \"S\"(sim) ou \"N\"" +
                "\n(não). Com isto é possível se ter maior precisão sobre a idade. Verifique também se a" +
                "\npessoa já tem idade para conseguir Carteira de Habilitação (18 anos ou mais) e imprima a" +
                "\nmensagem referente a esta checagem. Imprima a idade da pessoa\n\nEntre com o ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Já fez aniversário? ");
            res = char.Parse(Console.ReadLine());
            if (res == 's')
            {
                idade = 2023 - ano;
                Console.WriteLine("Como voce já fez aniversário sua idade é: " + idade);
            }
            else if (res == 'n')
            {
                idade = 2023 - ano - 1;
                Console.WriteLine("Como voce ainda não fez aniversário sua idade é: " +idade);
            }
            else
            {
                Console.WriteLine("Entre com uma resposta válida.");
                L2Q04.Executar();
            }
        }
    }
}