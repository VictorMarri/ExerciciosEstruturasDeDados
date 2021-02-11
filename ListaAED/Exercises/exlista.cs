using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class exlista
    {
        public static void meuDeus()
        {
            Dictionary<string, Dictionary<string, ArrayList>> dictionary = new Dictionary<string, Dictionary<string, ArrayList>>();
            Dictionary<string, ArrayList> materia = new Dictionary<string, ArrayList>();
            ArrayList epa = new ArrayList();
            int l = 0;
            string aluno = "";

            while (aluno != "FIM")
            {
                aluno = Console.ReadLine();

                if (aluno != "FIM")
                {
                    materia = new Dictionary<string, ArrayList>();

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Materia: ");
                        string nomeMateria = Console.ReadLine();
                        Console.WriteLine("NOTA 1");
                        int nota1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("NOTA 2");
                        int nota2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("NOTA 3");
                        int nota3 = int.Parse(Console.ReadLine());
                        epa = new ArrayList() { nota1, nota2, nota3 };
                        materia.Add(nomeMateria, epa);

                    }

                    dictionary.Add(aluno, materia);
                    
                }
            }
            Console.WriteLine("auauauauauauaauuauau");
            l = 0;
            foreach (KeyValuePair<string, Dictionary<string, ArrayList>> x in dictionary)
            {
                l++;
                Console.WriteLine($"Aluno(a): {x.Key}");

                foreach(KeyValuePair<string, ArrayList> z in x.Value)
                {
                    int reposNota = 0;
                    foreach(int nota in z.Value)
                    {
                        reposNota += nota;
                    }
                    Console.WriteLine($"{z.Key}: {reposNota}");
                }
                if(l < dictionary.Count)
                {
                    Console.WriteLine("");
                }

            }

        }


    }
}
