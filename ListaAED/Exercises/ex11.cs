using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex11
    {
        //11 – Crie a função public int QtdeOcorrencias(ArrayList AL, Object elemento) 
        //a qual retorna a quantidade de vezes que o elemento passado como parâmetro está armazenado no 
        //ArrayList.
        public static void Exercicio11()
        {
            ArrayList AL = new ArrayList() { 1, 2, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 6, 7, 8, 9, 4, 11, 12, 13, 14, 15 };

            var i = QtdeOcorrencias(AL, 4);
            Console.Write("Quantidade de vezes repetido: " + i);

        }

        public static int QtdeOcorrencias(ArrayList AL, Object elemento)
        {
            int o = 0;
         
            for (int i = 0; i < AL.Count; i++)
            {
                if (Convert.ToInt32(AL[i]) == Convert.ToInt32(elemento)) 
                {
                    o++;
                }
            }

            return o;
        }
    }
}
