using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex10
    {
        //10 – Crie a função public ArrayList OcorrenciasDe(ArrayList AL, Object elemento) 
        //o qual retorna um vetor contendo todas as posições que contem o elemento passado como parâmetro.
        public static void Questao10()
        {
            ArrayList AL = new ArrayList() { 1, 2, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 6, 7, 8, 9, 4, 11, 12, 13, 14, 15 };

            var tilt = OcorrenciaDe(AL, 4);
            Console.WriteLine("Posições do elemento passado: ");

            foreach(object x in tilt)
            {
                Console.WriteLine("Posição " + x);
            }
            
            
        }
        public static ArrayList OcorrenciaDe(ArrayList A, Object b) 
        {
            ArrayList TAL = new ArrayList();
            for(int i = 0; i < A.Count; i++)
            {
                if(Convert.ToInt32(A[i]) == Convert.ToInt32(b))  
                {
                    TAL.Add(i);
                }
            }

            return TAL;
        }

    }
}
