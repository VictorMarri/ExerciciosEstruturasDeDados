using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex18
    {
        //18 – Um biólogo precisa de um programa que traduza uma trinca de nucleotídeos em seu aminoácido correspondente.
        //Por exemplo, a trinca de aminoácidos ACG é traduzida como o aminoácido Treonina, e GCA em Alanina. 
        //Crie um programa em C# que use um Hashtable para criar um dicionário do código genético. 
        //O usuário deve digitar uma trinca (chave) e seu programa deve mostrar o nome (valor) do aminoácido correspondente. 
        //Use a tabela abaixo para cadastrar todas as trincas/aminoácidos.
        static Hashtable hash;
        public static void Questao18()
        {
            Console.Write("Digite a trinca de aminoácidos para ser traduzida: ");
            string trinca = Console.ReadLine();
            string trincaFormatada = trinca.ToUpper();

            RetornaValor(trincaFormatada);
        }

       
        public static void RetornaValor(string aminoacido)
        {
            var tabelahash = new Hashtable(){
                {"UUU", "Fenilalanina"},
                {"UUC", "Fenilalanina"},
                {"UUA", "leucina"},
                {"UUG", "Leucina" },
                {"CUU","Leucina" },
                {"CUC","Leucina" },
                {"CUA","Leucina" },
                {"CUG","Leucina" },
                {"AUU","Isoleucina" },
                {"AUC","Isoleucina" },
                {"AUG","Metionina" },
                {"GUU","Valina" },
                {"GUC","Valina" },
                {"GUA","Valina" },
                {"GUG","Valina" },
                {"UCU","Serina" },
                {"UCC","Serina" },
                {"UCA","Serina" },
                {"UCG","Serina" },
                {"CCU","Prolina" },
                {"CCC","Prolina" },
                {"CCA","Prolina" },
                {"CCG","Prolina" },
                {"ACU","Treonina" },
                {"ACC","Treonina" },
                {"ACA","Treonina" },
                {"ACG","Treonina" },
                {"GCU","Alanina" },
                {"GCC","Alanina" },
                {"GCA","Alanina" },
                {"GCG","Alanina" },
                {"UAU","Tirosina" },
                {"UAC","Tirosina" },
                {"UAA","Parada" },
                {"UAG","Parada" },
                {"CAU","Histidina" },
                {"CAC","Histidina" },
                {"CAA","Glutamina" },
                {"CAG","Glutamina" },
                {"AAU","Asparagina" },
                {"AAC","Asparagina" },
                {"AAA","Lisina" },
                {"AAG","Lisina" },
                {"GAU","Aspartato" },
                {"GAC","Aspartato" },
                {"GAA","Glutamato" },
                {"GAG","Glutamato" },
                {"UGU","Cisteína" },
                {"UGC","Cisteína" },
                {"UGA","Parada" },
                {"UGG","Triptofano" },
                {"CGU","Arginina" },
                {"CGC","Arginina" },
                {"CGA","Arginina" },
                {"CGG","Arginina" },
                {"AGU","Serina" },
                {"AGC","Serina" },
                {"AGA","Arginina" },
                {"AGG","Arginina" },
                {"GGU","Glicina" },
                {"GGC","Glicina" },
                {"GGA","Glicina" },
                {"GGG","Glicina" },
            };


            foreach (DictionaryEntry x in tabelahash)
            {
                if (aminoacido.Equals(x.Key))
                {
                    Console.WriteLine($"A trinca que voce digitou corresponde ao aminoácido {x.Value}");
                }
               
            }

        }
    }
}
            
           

