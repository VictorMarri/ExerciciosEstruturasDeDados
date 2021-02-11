using System;
using System.Collections;

namespace ListaAED.Exercises
{
    class EightDotOne
    {
        // 8.1 - Crie a função public ArrayList Intersecao(ArrayList AL1, ArrayList AL2) que retorna um ArrayList
        //contendo os elementos em comum armazenados em AL1 e AL2, sem repetição.
        public static void Questao08pontoUm()
        {

            ArrayList A = new ArrayList();
            A.Add(1);
            A.Add(2);
            A.Add(12);
            A.Add(4);
            ArrayList B = new ArrayList();
            B.Add(1);
            B.Add(4);
            B.Add(12);
            B.Add(14);


            var variavel = Intersecao(A, B);

            Console.WriteLine("Elementos em comum entre os dois arrays: ");
            foreach (object x in variavel)
            {
                Console.WriteLine(x);
            }

        }

        public static ArrayList Intersecao(ArrayList AL1, ArrayList AL2)
        {
            ArrayList AL3 = new ArrayList();

            for (int i = 0; i < AL1.Count; i++)
            {
                //Fui ajudado nessa parte especifica por Andre Roberto. 
                for (int k = 0; k < AL2.Count; k++)
                {
                    
                    if(Convert.ToInt32(AL1[i]) == Convert.ToInt32(AL2[k])) 
                    {
                        AL3.Add(AL2[k]);
                    }

                    
                    
                }
            }

            return AL3;

        }
    }
}





