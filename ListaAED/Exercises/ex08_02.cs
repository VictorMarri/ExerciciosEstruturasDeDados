using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex08_02
    {
        //8.2 – Crie a função public ArrayList Uniao(ArrayList AL1, ArrayList AL2) 
        //que retorna um ArrayList contendo os elementos armazenados em AL1 ou em AL2, sem repetição.
        public static void Questao08_02()
        {

            ArrayList A = new ArrayList();
            A.Add(1);
            A.Add(4);
            A.Add(17);
            A.Add(12);
            A.Add(21);
            A.Add(47);
            A.Add(99);
            A.Add(10);
            ArrayList B = new ArrayList(); //1,4,18,17,12,21,47,99,10,22,15,10
            B.Add(1);
            B.Add(4);
            B.Add(18);
            B.Add(22);
            B.Add(99);
            B.Add(18);
            B.Add(15);
            B.Add(10);

            var a = Uniao(A, B);

            foreach (object x in a)
            {
                Console.WriteLine(x);
            }
        }

        public static ArrayList Uniao(ArrayList AL1, ArrayList AL2)
        {

            ArrayList C = new ArrayList();
            ArrayList D = new ArrayList();
            D.Add(1);

            for (int i = 0; i < AL1.Count; i++)
            {

                for (int k = 0; k < AL2.Count; k++)
                {

                    if (!(Convert.ToInt32(AL1[i]) == Convert.ToInt32(AL2[k]))) 
                    {
                        C.Add(AL2[k]);
                    }
                }
            }


            return C;
        }


    }


}



