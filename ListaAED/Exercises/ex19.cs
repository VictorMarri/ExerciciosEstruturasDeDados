using System;
using System.Collections;

namespace ListaAED
{
    class ex19
    {
        //19 – Crie um dicionário com URL’s e IP’s dos websites abaixo e mais 5 à sua escolha.
        //O seu dicionário deve ser implementado usando a classe Hashtable e terá a 
        //URL como chave e o IP correspondente como valor
        //(por exemplo, se digitarmos como chave a URL www.google.com, seu programa deve retornar o IP 74.125.234.81). 
        //O seu programa deve permitir que o usuário digite uma URL e deve imprimir o IP correspondente.
        //Para descobrir o IP de um website, basta digitar ping + URL do website(exemplo: ping www.google.com).

        static Hashtable hash;
        public static void Questao19()
        {
            Console.Write("Digite a URL do site em que deseja obter o IP: ");
            string URL = Console.ReadLine().ToUpper();


            IPaddress(URL);
        }

        public static void IPaddress(string URL)
        {
            var tabelahash = new Hashtable(){
                {"www.google.com", "216.58.213.132"},
                {"www.yahoo.com", "87.248.100.216 / 87.248.100.215"},
                {"www.amazon.com", "13.225.33.32"},
                {"www.uol.com.br", "143.204.226.39 " },
                {"www.pucminas.br","200.229.32.27" },
                {"www.microsoft.com","23.54.61.194" },
                {"research.microsoft.com","13.67.218.189" },
                {"www.hotmail.com","204.79.197.212" },
                {"www.gmail.com","216.58.213.133" },
                {"www.twitter.com","104.244.42.193" },
                {"www.facebook.com","157.240.21.35" },
                {"www.cplusplus.com","144.217.110.12" },
                {"www.youtube.com","172.217.18.206" },
                {"www.brasil.gov.br","170.246.255.242" },
                {"www.whitehouse.gov","104.126.228.154" },
                {"www.nyt.com","151.101.121.164" },
                {"www.capes.gov.br","200.130.18.222" },
                {"www.wikipedia.com","91.198.174.194" },
                {"www.answers.com","151.101.120.203" },
                {"www.apple.com","23.215.180.234" },
                {"www.pornhub.com","66.254.114.41" },
                {"www.udemy.com","104.16.65.85" },
                {"balta.io","104.41.13.179" },
                {"docs.microsoft.com","104.126.242.194" },
                {"www.saraiva.com.br","34.224.100.147" },
            };

            foreach (DictionaryEntry x in tabelahash)
            {
                if (URL.Equals(x.Key))
                {
                    Console.WriteLine("============================================================");
                    Console.WriteLine($"A URL {URL} tem como respectivo IP: {x.Value}");
                    Console.WriteLine("============================================================");
                }
            }


        }
    }
}
