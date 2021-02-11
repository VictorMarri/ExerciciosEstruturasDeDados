using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex09
    {
        // 9 – Crie o procedimento public void ApagaRepetidos(ArrayList AL) 
        //que apaga todos os elementos repetidos do ArrayList AL recebido como parâmetro, 
        //mantendo apenas a 1ª ocorrência de cada elemento.
        public static void Questao09()
        {
            ArrayList A = new ArrayList() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11,12,12,14,17,22,28,31,178,15 };


            ApagaRepetidos(A);
        }

        public static void ApagaRepetidos(ArrayList AL1)
        {
            for(int i = 1; i < AL1.Count; i++)
            {
                for(int j = 1; j < AL1.Count; j++)
                {
                    if(AL1[i] == AL1[j])
                    {
                        AL1.Remove(AL1[j]);
                    }
                }
            }

            foreach(object x in AL1)
            {
                Console.WriteLine(x);
            }
        }
    }
}
