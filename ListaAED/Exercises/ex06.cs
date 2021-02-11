using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex06
    {
        // 6 - Crie a função public ArrayList ConcatenaArrayList(ArrayList AL1, ArrayList AL2), o qual retorna um
        //novo ArrayList como todos os elementos de AL1 e AL2.
        //Exemplo:
        //ArrayList A = new ArrayList();
        //ArrayList B = new ArrayList();
        //ArrayList AmaisB; // Apenas a referência foi declarada. Um ArrayList auxiliar deverá ser criado
        //                  // dentro da função e retornado pela mesma
        //                  // código para preencher os ArrayLists A, B
        //AmaisB = ConcatenaArrayList(A, B);
        //A= [19, 33, 2, 4]
        //B = [1, 2, 3, 4, 5]
        //AmaisB = [19, 33, 2, 4, 1, 2, 3, 4, 5]
        public static void Questao06()
        {
            ArrayList A = new ArrayList() { 19, 33, 2, 4 };
            ArrayList B = new ArrayList() { 1, 2, 3, 4, 5 };
            ArrayList AmaisB = new ArrayList();

            AmaisB = ConcatenaArraylist(A, B);

            Console.Write("A: [ ");
            foreach(object x in A)
            {
                Console.Write($"{x}, ");
            }
            Console.WriteLine("]");

            Console.WriteLine();

            Console.Write("B: [ ");
            foreach (object x in B)
            {
                Console.Write($"{x}, ");
            }
            Console.Write("]");


            Console.WriteLine();
            Console.WriteLine();

            Console.Write("AmaisB: [ ");
            foreach (object x in AmaisB)
            {
                Console.Write($"{x}, ");
            }
            Console.Write("]");

        }

        public static ArrayList ConcatenaArraylist(ArrayList AL1, ArrayList AL2)
        {
            ArrayList C = new ArrayList();

            foreach(object x in AL1)
            {
                C.Add(x);
            }

            foreach(object x in AL2)
            {
                C.Add(x);
            }

            return C;
        }
    }
}
