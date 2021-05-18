using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CsharpCEP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CEP: ");
            string cep = Console.ReadLine();
            var remoteUrl = WebRequest.CreateHttp(string.Format("https://buscacepinter.correios.com.br/app/endereco/carrega-cep-endereco.php?pagina=%2Fapp%2Fendereco%2Findex.php&cepaux=&mensagem_alerta=&endereco={0}&tipoCEP=ALL", cep));
            using(var response = remoteUrl.GetResponse())
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                object result = reader.ReadToEnd();
                var dataList = JsonConvert.DeserializeObject<Rootobject>(result.ToString());
                var dados = dataList.dados[0];
                Console.WriteLine("Endereço: " + dados.logradouroDNEC + "\nCidade: " + dados.localidade + "\nUF: "+ dados.uf);
            }
         
        }
    }
}
