using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex04
    {
        // 4 - Crie o procedimento public void ApagaArrayList(ArrayList origem, int inicio, int final), 
        //o qual apaga todos os elementos no intervalo determinado pelos parâmetros inicio e final.
        //Atenção: não é permitido usar o método RemoveRange(). Apenas Remove() e RemoveAt().
        //Exemplo: ApagaArrayList(AL, 7, 10) => apagar os elementos entre as posições 7 e 10.
        public static void Questao04()
        {
            
            int n = 20;
            ArrayList mczoidegato = new ArrayList(n);

            for(int i = 1; i<= n; i++)
            {
                mczoidegato.Add(i);
            }

            ApagaArrayList(mczoidegato, 8, 14 );
        }
            


        public static void ApagaArrayList(ArrayList origem, int inicio, int final)
        {
            for (int i = inicio; i <= final; i++)

            {
                origem.Remove(i);

            }

            foreach (object o in origem)
            {
                Console.WriteLine(o);
            }
        }
    }
}














