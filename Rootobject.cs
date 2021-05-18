using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCEP
{
    public class Rootobject
    {
        public bool erro { get; set; }
        public string mensagem { get; set; }
        public int total { get; set; }
        public Dado[] dados { get; set; }
    }

    public class Dado
    {
        public string uf { get; set; }
        public string localidade { get; set; }
        public string locNu { get; set; }
        public string localidadeSubordinada { get; set; }
        public string logradouroDNEC { get; set; }
        public string logradouroTextoAdicional { get; set; }
        public string logradouroTexto { get; set; }
        public string bairro { get; set; }
        public string baiNu { get; set; }
        public string nomeUnidade { get; set; }
        public string cep { get; set; }
        public string tipoCep { get; set; }
        public string numeroLocalidade { get; set; }
        public string situacao { get; set; }
    }

}
