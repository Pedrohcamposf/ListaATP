using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L2Q05
    {
        public static void Executar()
        {
            int nota;
            Console.WriteLine("Faça um algoritmo que segundo uma nota informada pelo usuário, verifique em qual faixa" +
                "\na mesma se encaixa e imprima para o usuário a mensagem correspondente a sua nota." +
                "\n\nEntre com a nota que você tirou na prova: ");
            nota = int.Parse(Console.ReadLine());
            if (10 >= nota && nota >= 8)
            {
                Console.WriteLine("Parabens sua nota foi OTIMA!!!");
            }
            else if (8>nota && nota >= 7)
            {
                Console.WriteLine("Sua nota foi boa, mas pode melhorar!");
            }
            else if (7>nota && nota >= 5)
            {
                Console.WriteLine("Foi de raspão mas passou, sua nota foi regular.");
            }
            else if (nota < 5 && nota >= 0)
            {
                Console.WriteLine("Te vejo nas férias, sua nota foi insatisfatória.");
            }
            else
            {
                Console.WriteLine("Entre com uma nota valida.\n\n");
                L2Q05.Executar();
            }
        }
    }
}