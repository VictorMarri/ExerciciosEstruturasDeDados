using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex24
    {
        public static void Questao24()
        {
            List<string> teco = new List<string>() { { "teco" }, {"Tuc"}, { "teco" } };

            Console.WriteLine("Quantidade de itens procurado e achado: " + QtdeOcorrencias(teco, "teco"));
        }

        public static int QtdeOcorrencias(List<String> origem, String elemento)
        {
            int sum = 0;

            foreach(string x in origem)
            {
                if((string)x == (string)elemento)
                {
                    sum = sum + 1;
                }
            }

            return sum;
        }
    }
}
