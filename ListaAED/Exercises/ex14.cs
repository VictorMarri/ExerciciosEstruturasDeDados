using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListaAED.Exercises
{
    class ex14
    {
        //14 – Crie o procedimento public void VaiProFundo(Stack origem, Object elemento) 
        //que empilha o elemento passado como parâmetro no fundo da Stack, ao invés de no topo.
        public static void Questao14()
        {
            Stack ST = new Stack();

            for(int i = 1; i <= 10; i++)
            {
                ST.Push(i);
            }

            VaiProFundo(ST, 4);

        }

        public static void VaiProFundo(Stack origem, Object elemento)
        {
            
            foreach(object x in origem)
            {
                if (x == elemento)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
