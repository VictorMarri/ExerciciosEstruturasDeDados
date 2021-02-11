using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex27
    {
        //27 – Crie a função public Stack<T> CopiaStack<T>(Stack<T> origem) 
        //a qual retorna uma cópia da Stack<T> origem passada como parâmetro.
        //Os elementos da Stack origem devem permacer na mesma ordem original.
        public static void Questao27()
        {
            Stack<int> ST = new Stack<int>();

            for(int i = 1; i <= 20; i++)
            {
                ST.Push(i);
            }

            var etc = CopiaStack(ST);

            foreach(object x in etc)
            {
                Console.WriteLine(x);
            }
        }

        public static Stack<int> CopiaStack<T>(Stack<T> origem)
        {
            Stack<int> ST2 = new Stack<int>();
            Stack<int> ST3 = new Stack<int>();

            foreach(object x in origem)
            {
                ST2.Push((int)x);
            }

            foreach(object x in ST2)
            {
                ST3.Push((int)x);
            }

            return ST3;
        }
    }
}
