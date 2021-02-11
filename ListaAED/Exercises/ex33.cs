using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex33
    {
        //33 – Faça um programa que monte a estrutura abaixo usando Dictionary<> ou SortedList<>:
        public static void Questao33()
        {
            SortedList Populacional = SensoPopulacional();
            int populacaoTotal = 0;

            foreach(DictionaryEntry x in Populacional)
            {
                Console.WriteLine($"Continente: {x.Key} ");
                foreach(DictionaryEntry y in (SortedList)x.Value)
                {
                    Console.WriteLine($"{y.Key} - População: {y.Value}");
                    populacaoTotal += (int)y.Value; //Fui ajudado nessa parte por DIUMAR
                }
                Console.WriteLine($"População Total: {populacaoTotal}");
                populacaoTotal = 0;
                Console.WriteLine();
                Console.WriteLine();

            }
        }

        public static SortedList SensoPopulacional()
        {
            
            
            SortedList America = new SortedList() { 
                {"Brasil", 212559426 },
                {"Colombia", 50882891 },
                {"Argentina", 45195774 },
                {"Peru",33050325},
                {"Venezuela", 28435940 },
                {"Chile", 19116201}
              
            };
            SortedList Asia = new SortedList() {
                {"Afeganistão", 38048525 },
                {"China", 1413882863 },
                {"Indonésia", 275361145 },
                {"Índia",1400169710},
                {"Cazaquistão", 19112037 },
                {"Kuwait", 5000932}

            };
            SortedList Europa = new SortedList() {
                {"Alemanha", 81257240 },
                {"Espanha", 49331076 },
                {"França", 67364360 },
                {"Turquia",33050325},
                {"Portugal", 10355493 },
                {"Suécia", 10040995}

            };

            SortedList PopulacaoTotal = new SortedList() {
                {"Asia",Asia },
                {"Europa", Europa },
                {"America", America }
            };

            return PopulacaoTotal;


        }
    }
}
