using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListaAED.Exercises
{
    class ex13
    {
        //13 – Crie a função public Stack CopiaStack(Stack origem) 
        //a qual retorna uma cópia da Stack origem passada como parâmetro.
        //Os elementos da Stack origem devem permacer na mesma ordem original.Atenção: não é permitido usar os métodos Clone() e CopyTo() da classe Stack.
        public static void Questao13()
        {
            Stack ST = new Stack();
            

            for (int j = 1; j <= 10; j++)
            {
                ST.Push(j);
            }

            var i = CopiaStack(ST);

            foreach(object x in i)
            {
                Console.WriteLine(x);
            }

        }

        public static Stack CopiaStack(Stack origem)
        {
            Stack ST2 = new Stack();
            Stack ST3 = new Stack();

            foreach(object x in origem)
            {
                ST2.Push(x);
            }

            foreach(object x in ST2)
            {
                ST3.Push(x);
            }

            return ST3;
        }
    }
}
