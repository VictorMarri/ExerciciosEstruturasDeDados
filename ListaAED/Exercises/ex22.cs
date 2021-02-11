using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex22
    {
        //22 – Faça um programa que cadastre em um Hashtable alguns modelos de carros de montadoras nacionais, 
        //conforme a tabela abaixo
        //(você deve fazer esse cadastro internamente, não o usuário – crie uma função para isso). 
        //Seu Hashtable tem como chave o nome da montadora, e como valor um Arraylist contendo os modelos de carros da tabela abaixo.

        private static string resposta;
        public static void Questao22()
        {
            string ue = "SIM";
            do
            {
                ArrayList Model;
                Console.Write("Digite aqui o nome da montadora: ");
                string montadora = Console.ReadLine().ToUpper();

                if (CadastroCarros().ContainsKey(montadora))
                {
                    Model = (ArrayList)CadastroCarros()[montadora];
                    Console.WriteLine($"Modelos Disponíveis da(o) {montadora}: {Model.Count}");
                    Console.WriteLine();
                    Console.WriteLine($"Modelos: ");


                    foreach (Object x in Model)
                    {
                        Console.WriteLine(x);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Montadora nao consta em nosso estoque no momento, por favor tente outra!");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Deseja fazer mais uma consulta? (SIM/NÃO)");
                ue = Console.ReadLine().ToUpper();

            } while (ue != "NÃO");
         
        }   

        public static Hashtable CadastroCarros()
        {
            ArrayList FIAT = new ArrayList() { "Mille", "Novo Uno", "Palio", "Siena", "Freemont", "Bravo", "Punto", "Linea", "PalioWeekend" };
            ArrayList VOLKSWAGEN = new ArrayList() { "Gol", "Voyage", "Polo", "Passat", "Amarok", "Fox", "Golf", "Jetta", "Tiguan" };
            ArrayList FORD = new ArrayList() { "Focus", "Fiesta", "KA", "New Fiesta", "Fusion", "EDGE" };
            ArrayList GM = new ArrayList() { "Celta", "Classic", "Prisma", "Agile", "Omega", "Cruze", "Camaro", "" };

            Hashtable ListaCarros = new Hashtable() {
              {"FIAT", FIAT },
              {"VOLKSWAGEN", VOLKSWAGEN },
              {"FORD", FORD },
              {"GM", GM }
            };

            return ListaCarros;
        }
            


    }
}
