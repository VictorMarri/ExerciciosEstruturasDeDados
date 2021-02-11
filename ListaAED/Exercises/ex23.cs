using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED.Exercises
{
    class ex23
    {
        //23 – Refaça o exercício 19 usando a coleção genérica Dictionary.

        public static void Questao23()
        {
            Console.Write("Digite a URL do site em que deseja obter o IP: ");
            string URL = Console.ReadLine().ToLower();
            IPaddress(URL);
        }



        public static void IPaddress(string URL)
        {
            Dictionary<string, string> tal = new Dictionary<string, string>();
            tal.Add("www.google.com", "216.58.213.132");
            tal.Add("www.yahoo.com", "87.248.100.216 / 87.248.100.215");
            tal.Add("www.amazon.com", "13.225.33.32");
            tal.Add("www.uol.com.br", "143.204.226.39 ");
            tal.Add("www.pucminas.br", "200.229.32.27");
            tal.Add("www.microsoft.com", "23.54.61.194");
            tal.Add("research.microsoft.com", "13.67.218.189");
            tal.Add("www.hotmail.com", "204.79.197.212");
            tal.Add("www.gmail.com", "216.58.213.133");
            tal.Add("www.twitter.com", "104.244.42.193");
            tal.Add("www.facebook.com", "157.240.21.35");
            tal.Add("www.cplusplus.com", "144.217.110.12");
            tal.Add("www.youtube.com", "172.217.18.206");
            tal.Add("www.brasil.gov.br", "170.246.255.242");
            tal.Add("www.whitehouse.gov", "104.126.228.154");
            tal.Add("www.nyt.com", "151.101.121.164");
            tal.Add("www.capes.gov.br", "200.130.18.222");
            tal.Add("www.wikipedia.com", "91.198.174.194");
            tal.Add("www.answers.com", "151.101.120.203");
            tal.Add("www.apple.com", "23.215.180.234");
            tal.Add("www.pornhub.com", "66.254.114.41");
            tal.Add("www.udemy.com", "104.16.65.85");
            tal.Add("balta.io", "104.41.13.179");
            tal.Add("docs.microsoft.com", "104.126.242.194");
            tal.Add("www.saraiva.com.br", "34.224.100.147");

            string Identificador = (string)tal[URL];

            if (!(Identificador == null))
            {
                Console.WriteLine($"A url {URL}, tem como respectivo IP: {Identificador}");
            }
            else
            {
                Console.WriteLine("Dominio errado, tente novamente com um site válido!");
            }

        }





    }
}
