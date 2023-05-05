using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaATP
{
    public static class L2Q06
    {
        public static void Executar()
        {
            double dia, valorPromo, valorArrecadadoPromo, valorArrecadadoSemPromo;
            Console.WriteLine("Um hotel com 75 apartamentos deseja fazer uma promoção especial de final de semana," +
                "\nconcedendo um desconto de 25% na diária. Com isto, espera aumentar sua taxa de" +
                "\nocupação de 50 para 80%. Sendo dado o valor normal da diária, calcular e imprimir:" +
                "\n\na) o valor da diária promocional;\nb) o valor total arrecadado com 80% de ocupação e diária promocional;" +
                "\nc) o valor total arrecadado com 50% de ocupação e diária normal;" +
                "\nd) a diferença entre estes dois valores.\n\nEntre com o valor da diária: ");
            dia = double.Parse(Console.ReadLine());
            valorPromo = dia * 0.75;
            Console.WriteLine("diaria promocional: " + valorPromo);
            valorArrecadadoPromo = valorPromo * (75 * 0.8);
            Console.WriteLine("Valor com 80% da ocupação na promoção: " + valorArrecadadoPromo);
            valorArrecadadoSemPromo = dia * (75 * 0.5);
            Console.WriteLine("Valor com 50% da ocupação sem promoção: " + valorArrecadadoSemPromo);
            Console.WriteLine("A diferença entre os dois valores: " + (valorArrecadadoSemPromo - valorArrecadadoPromo));
        }
    }
}