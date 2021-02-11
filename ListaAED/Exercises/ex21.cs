using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED
{
    class ex21
    {
        //21 – Faça um programa que use um SortedList para adicionar a matrícula(key) 
        //e nome(value) de vários alunos.
        //Para encerrar o cadastramento de alunos, o usuário deve digitar uma matrícula negativa.
        //Após o cadastro, seu programa deve permitir ao usuário pesquisar alunos através de sua matrícula. 
        //O usuário deve digitar um número negativo para interromper a pesquisa.

        public static void Questao21()
        {
            SortedList SL = new SortedList();
            int matricula = 1;
            string nome;

            Console.WriteLine("Olá! Cadastre seu Aluno aqui!.");

            do
            {
              Console.WriteLine();
              Console.Write("Matricula: ");
              matricula = int.Parse(Console.ReadLine());
              Console.Write("Nome do Aluno: ");
              nome = Console.ReadLine();
              SL.Add(matricula, nome);
              if(matricula < 0) 
              {
                SL.Remove(matricula);
              }

            } while (matricula > 0);

            Console.WriteLine();
            Console.Write("Pesquise um dos alunos aqui, digitando sua matricula: ");
            int numeroMatricula = int.Parse(Console.ReadLine());

            foreach(DictionaryEntry x in SL)
            {
                if(numeroMatricula.Equals(x.Key))
                Console.WriteLine($"Matricula: {x.Key} | Nome: {x.Value} ");
            }
        }
    }
}
