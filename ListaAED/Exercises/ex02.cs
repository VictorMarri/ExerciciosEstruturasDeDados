using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    // 2 - Crie a função public ArrayList CopiaQueueParaArrayList(Queue origem), 
    //que copia todos os dados do Queue origem 
    //e retorna o novo ArrayList criado.
    //Atenção: para esse exercício não será permitido usar os métodos Clone() e CopyTo().
    class ex02
    {
        public static void Questao02()
        {
            int n = 10;
            Queue pitel = new Queue(n);

            for(int i = 1; i<= n; i++)
            {
                pitel.Enqueue(i);
            }

            Console.WriteLine("============ Elementos Queue ========================= ");
            foreach (int i in pitel)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("============ Elementos ArrayList =========================");
            var etc = CopiaQueueParaArrayList(pitel);

            foreach(object a in etc)
            {
                Console.WriteLine(a);
            }


        }

        public static ArrayList CopiaQueueParaArrayList(Queue origem)
        {
            ArrayList pitelzao = new ArrayList();

            foreach(int x in origem)
            {
                pitelzao.Add(x);
            }

            return pitelzao;
        }
    }
}
