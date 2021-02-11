using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class testeclasse
    {
        public static void richardtenhapiedade()
        {
            ArrayList A = new ArrayList();
            ArrayList B = new ArrayList();


            int quantidade = 3;
            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Insere({i})");
                string insere = Console.ReadLine();
                A.Add(insere);
            }

            int quantidade2 = 4;
            for (int i = 1; i <= quantidade2; i++)
            {
                Console.WriteLine($"Insere({i})");
                string insere1 = Console.ReadLine();
                B.Add(insere1);
            }

            Intersecao(A, B);

        }

        public static void Intersecao(ArrayList AL1, ArrayList AL2)
        {
            Queue C = new Queue(); //Interseção
            Queue D = new Queue(); //União
            int soma1 = 0;
            int soma2 = 0;
            

            foreach(string x in AL1)
            {
                if (!C.Contains(x))
                {
                    C.Enqueue(x);
                   
                }
            }

            foreach(string x in AL2)
            {
                if (!C.Contains(x))
                {
                    C.Enqueue(x);
                    
                }
            }

            foreach(string x in C)
            {
                soma2++;
            }

            foreach(string x in AL1)
            {
                if (AL2.Contains(x))
                {
                    if (!D.Contains(x))
                    {
                        D.Enqueue(x);
                        
                    }
                }
            }

            foreach (string x in D)
            {
                soma1++;
            }

            Console.Write($"INTERSECAO({soma1}):");
            foreach (object x in D)
            {
                Console.Write($"{x},");
            }

            Console.WriteLine();

            Console.Write($"UNIAO({soma2}):");
            foreach (object x in C)
            {
                Console.Write($"{x},");
            }
        }
    }
}
