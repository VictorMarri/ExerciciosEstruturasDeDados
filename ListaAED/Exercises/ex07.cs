using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex07 
    {
        // 7 - Crie o procedimento public void ConcatenaArrayList2(ArrayList AL1, ArrayList AL2, ArrayList AL3), o
        //qual copia todos os elementos de AL1 e AL2 para AL3.
        //Exemplo:
        //ArrayList A = new ArrayList();
        //ArrayList B = new ArrayList();
        //ArrayList AmaisB = new ArrayList(); // O ArrayList para a concatenação foi instanciado.
        //                                    // Não será necessário instanciá-lo dentro da função.
        //                                    // código para preencher os ArrayLists A, B
        //ConcatenaArrayList2(A, B, AmaisB);
        public static void Questao07()
        {
            ArrayList A = new ArrayList() { 1, 2, 3, 4, 5 }; 
            ArrayList B = new ArrayList() { 6, 7, 8, 9, 10 };
            ArrayList AmaisB = new ArrayList();

            Console.Write("ArrayList A: [ ");
            foreach (object x in A)
            {
                Console.Write($"{x}, ");
            }
            Console.Write("]");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("ArrayList B: [ ");
            foreach (object x in B)
            {
                Console.Write($"{x}, ");
            }
            Console.Write("]");
            Console.WriteLine();
            Console.WriteLine();

            ConcatenaArrayList2(A, B, AmaisB);
        }

        public static void ConcatenaArrayList2(ArrayList AL1, ArrayList AL2, ArrayList AmaisB)
        {
            foreach(object x in AL1)
            {
                AmaisB.Add(x);
            }

            foreach(object x in AL2)
            {
                AmaisB.Add(x);
            }

            Console.Write("AL3: [ ");
            foreach(object x in AmaisB)
            {
                Console.Write($"{x}, ");
            }
            Console.Write("]");
        }
    }
}
