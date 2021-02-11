using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex29
    {
        public static void Exercicio29()
        {
            Queue<int> a = new Queue<int>();
            a.Enqueue(1);
            a.Enqueue(2);
            a.Enqueue(3);

            InverteQueue(a);
        }

        public static void InverteQueue<T>(Queue<T> Q)
        {
            Stack<int> z = new Stack<int>();
            

            foreach (object x in Q)
            {
                z.Push((int)x);
            }

            foreach (object x in z)
            {
                Console.WriteLine(x);
            }


        }
    }
}


