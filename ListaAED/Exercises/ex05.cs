using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex05
    {
        // 5 - Crie o procedimento public void ApagaArrayList2(ArrayList origem, int inicio, int qtde), 
        //o qual apaga todos os qtde elementos à partir da posição determinada pelo parâmetro início.
        //Atenção: não é permitido usar o método RemoveRange(), apenas Remove() e RemoveAt().
        public static void Questao05()
        {
            Random rnd = new Random();
            int n = 12;
            ArrayList olhaogas = new ArrayList(n);

            for(int i = 0; i < n; i++)
            {
                olhaogas.Add(i);
            }

            ApagaArrayList2(olhaogas, 7,5);
        }

        public static void ApagaArrayList2(ArrayList origem, int inicio, int qtde)
        {

            int num = inicio + qtde;
            for (int i = inicio; i < num; i++)
            {
                origem.RemoveAt(i);
            }
        }
    }
}
