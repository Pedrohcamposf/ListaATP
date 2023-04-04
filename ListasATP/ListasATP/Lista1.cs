using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class Questao4
    {
        public static void Executar()
        {
            int ano, idade;
            //usar char para ocupar menos espaço de processamento
            char res;
            Console.WriteLine("Entre com o ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Já fez aniversário? ");
            res = char.Parse(Console.ReadLine());
            if (res == 's')
            {
                idade = 2023 - ano;
            }
            else if (res == 'n')
            {
                idade = 2023 - ano - 1;
            }
            else
            {
                Console.WriteLine("Entre com uma resposta válida.");
            }
        }
    }
}