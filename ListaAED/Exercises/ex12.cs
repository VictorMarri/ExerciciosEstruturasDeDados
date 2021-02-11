using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListaAED.Exercises
{
    class ex12
    {
        //12 – Crie a função public Queue CopiaQueue(Queue origem) 
        //a qual retorna uma cópia da Queue origem passada como parâmetro.
        //Os elementos da Queue origem devem permacer na mesma ordem original.
        //Atenção: não é permitido usar os métodos Clone() e CopyTo() da classe Queue.
        public static void Exercicio12()
        {
            Queue QE = new Queue();
            

            for(int i = 1; i <= 10; i++)
            {
                QE.Enqueue(i);
            }

            var y = CopiaQueue(QE);
            Console.WriteLine("Resultado: ");
            foreach(object x in y)
            {
                Console.WriteLine(x);
            }

          
        }

         public static Queue CopiaQueue(Queue origem)
         {
            Queue A = new Queue();

            foreach(object x in origem)
            {
                A.Enqueue(x);
            }

            return A;
         }
        
    }
}
