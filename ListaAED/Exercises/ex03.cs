using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    // 3 - Crie a função public ArrayList CopiaParteArrayList(ArrayList origem, int inicio, int final), 
    //a qual retorna um ArrayList contendo todos os elementos dentro do intervalo 
    //determinado pelos parâmetros inicio e final.
    //Não é permitido usar o método CopyTo() do ArrayList.Atenção: caso o ArrayList origem tenha menos posições do que a determinada pelo parâmetro final, copie até a sua última posição.Caso oparâmetro inicio seja maior que a quantidade de elementos do ArrayList origem, retorne um ArrayListvazio.Por fim, se o parâmetro inicio for maior que o parâmetro final, indica que o usuário deseja copiaros dados na ordem invertida.
    class ex03
    {
        public static void Questao03()
        {
            int n = 10;
            ArrayList tchutchuca = new ArrayList(n);

            for(int i = 1; i <= n; i++)
            {
                tchutchuca.Add(i);
            }

            var tal = CopiaParteArrayList(tchutchuca, 4,7);
            foreach(object x in tal)
            {
                Console.WriteLine(x);
            }
        }

        public static ArrayList CopiaParteArrayList(ArrayList origem, int inicio, int final)
        {
            ArrayList djazeitona = new ArrayList();
            
            if(origem.Count < final)
            {
                

                for(int i = 1; i <= djazeitona.Count; i++)
                {
                    if(i >= inicio)
                    {
                        djazeitona.Add(i);
                    }
                }
                
            }
            else if(inicio > origem.Count)
            {
                Console.WriteLine("Inicio maior que o tamanho do arraylist, portanto retorna vazio");
            }
            else if(inicio > final)
            {
                foreach(object x in origem)
                {
                    djazeitona.Add(x);
                    
                }

                djazeitona.Reverse();
            }
            else
            {
                for(int i = inicio; i <= origem.Count; i++)
                {
                    if(i >= inicio && i <= final)
                    {
                        djazeitona.Add(i);
                    }
                }
            }

            return djazeitona;
        }
    }
}
