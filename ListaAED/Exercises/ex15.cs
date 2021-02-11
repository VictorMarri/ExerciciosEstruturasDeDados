using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex15
    {
        //15 – Crie o procedimento public void InverteQueue(Queue Q) 
        //que inverte a ordem dos elementos do Queue Q, no próprio Queue.
        //OBS1: utilize outras estruturas - vetor, ArrayList, Stack ou mesmo outro Queue – que julgar necessárias.
        //OBS2: nesse exercício você não deve utilizar o método reverse.
        public static void Questao15()
        {
            Queue C = new Queue();

            for(int i = 1; i <= 20; i++)
            {
                C.Enqueue(i);
            }

            Console.WriteLine("Queue C: ");
            foreach(object x in C)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine("Inverte: ");

            InverteQueue(C);
        }

        public static void InverteQueue(Queue Q)
        {
            Stack A = new Stack();
            

            foreach(object x in Q)
            {
                A.Push(x);
            }

            foreach(object x in A)
            {
                Console.WriteLine(x);
            }
            

        }
    }
}
