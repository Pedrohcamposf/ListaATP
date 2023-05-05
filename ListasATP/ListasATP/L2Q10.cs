using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L2Q10
    {
        public static void Executar()
        {
            Console.WriteLine("Leia a velocidade máxima permitida em uma avenida e a velocidade com que o motorista\n" +
                "estava dirigindo nela. Se o motorista estiver dentro do limite de velocidade, imprima a" +
                "\nmensagem “Motorista respeitou a lei”. Se o motorista tiver ultrapassado a velocidade" +
                "\nmáxima permitida, calcule e imprima o valor da multa a ser cobrada, sabendo que os" +
                "\nvalores a serem cobrados são os seguintes:\n 50 reais se o motorista ultrapassar em até " +
                "10km/h a velocidade permitida (ex: se a\r\nvelocidade máxima for 50km/h e o motorista estiver a 60km/h ou a 56km/h);" +
                "\n 100 reais, se o motorista ultrapassar de 11 a 30 km/h a velocidade permitida;" +
                "\n 200 reais, se estiver acima de 30km/h da velocidade permitida.\r\n");
            int vp; // declarando variavel velocidade permitida na avenida
            Console.WriteLine("Insira a velocidade permitida na avenida: ");
            vp = int.Parse(Console.ReadLine());

            int vm; //declarando variavel velocidade do motorista
            Console.WriteLine("Insira a velocidade que o motorista estava: ");
            vm = int.Parse(Console.ReadLine());

            int r; // declarando variavel resultado
            r = vm - vp; //atribuindo valor de resultado

            if (r == 0) //compara se resultado é 0, se for executado essa linha do codigo
            {

                Console.WriteLine("Motorista respeitou a lei.\n"); //se for igual a 0 executa esse comando

            }
            else if (r <= 10) //compara se resultado é igual ou menor que 10, se for executado essa linha do codigo
            {

                Console.WriteLine("Você ultrapassou o limite permitido e terá de pagar R$50,00 de multa.\n"); //se for menor ou igual a 10 executa esse comando

            }
            else if (r < 30) //compara se resultado é menor a 30
            {

                Console.WriteLine("Você ultrapassou o limite permitido e terá de pagar R$100,00 de multa.\n"); //se for menor que 30 executa esse comando

            }
            else //se não for nenhuma das alternativas acimao, executa esse comando abaixo
            {

                Console.WriteLine("Você ultrapassou o limite permitido e terá de pagar R$200,00 de multa.\n");

            }
        }
    }
}