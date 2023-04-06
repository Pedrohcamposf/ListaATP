using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaRepeticao
{
    public static class Questao1
    {
        public static void Executar()
        {
            Console.WriteLine("Testando o Do While!");

            int contPar = 0;
            int contImpar = 0;
            int resultado = 0;

            int valor = 0;

            do //faça
            {
                Console.WriteLine("Entre com o valor");
                valor = int.Parse(Console.ReadLine());

                resultado = valor % 2;

                if (resultado == 0)
                    contPar++;
                else
                    contImpar++;
            } while (valor != 0); //!= é diferente
            Console.WriteLine("pares " + contPar);
            Console.WriteLine("impares " + contImpar);
        }
    }
}
