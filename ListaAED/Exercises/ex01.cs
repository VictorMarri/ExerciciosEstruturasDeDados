using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    //1 - Crie a função public ArrayList CopiaArrayList(ArrayList origem) 
    //que copia todos os dados do ArrayList origem 
    //e retorna o novo ArrayList criado.
    //Atenção: para esse exercício não será permitido usar os métodos Clone() e CopyTo().
    class ex01
    {
        public static void Questao01()
        {
            int n = 10;
            ArrayList tecoteco = new ArrayList(n);

            for(int i = 1; i <= n; i++)
            {
                tecoteco.Add(i);
            }

            var teco = CopiaArrayList(tecoteco);

            foreach(object x in teco)
            {
                Console.WriteLine(x);
            }
        }

        public static ArrayList CopiaArrayList(ArrayList origem)
        {
            ArrayList final = new ArrayList();
            foreach(object i in origem)
            {
                final.Add(i);
            }


            return final;
        }
    }
}
