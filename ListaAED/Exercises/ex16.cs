using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex16
    {
        //16 – Crie o procedimento public void InverteStack(Stack S) 
        //que inverte a ordem dos elementos do Stack S, no próprio Stack.
        //OBS1: utilize outras estruturas - vetor, ArrayList, Stack ou Queue – que julgar necessárias.
        //OBS2: nesse exercício você não deve utilizar o método reverse.
        public static void Exercicio16()
        {
            Stack T = new Stack();

            for(int i = 1; i <= 20; i++)
            {
                T.Push(i);
            }
            
            Console.WriteLine("Stack T: ");
            foreach (object x in T)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine("Inverte: ");

            InverteStack(T);
        }

        public static void InverteStack(Stack S)
        {
            Stack G = new Stack();
            

            foreach(object x in S)
            {
                G.Push(x);
            }

            foreach(object x in G)
            {
                Console.WriteLine(x);
            }
        }
    }
}
            
           
