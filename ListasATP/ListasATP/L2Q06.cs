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
            Console.WriteLine("Entre com o valor da diária: ");
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