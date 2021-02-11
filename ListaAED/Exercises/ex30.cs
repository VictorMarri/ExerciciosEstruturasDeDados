using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex30
    {
        public static void Questao30()
        {
            Stack<int> W = new Stack<int>();
            W.Push(1);
            W.Push(2);
            W.Push(3);

            InverteStack(W);
        }

        public static void InverteStack<T>(Stack<T> S)
        {
            Stack<int> x = new Stack<int>();
            Stack<int> v = new Stack<int>();

            foreach (object y in S)
            {
                v.Push((int)y);
            }

            foreach(object z in v)
            {
                x.Push((int)z);
            }

            foreach(object s in x)
            {
                Console.WriteLine(s);
            }
        }
    }
}
