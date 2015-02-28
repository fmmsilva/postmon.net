using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postmon
{
    public class Endereco
    {
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public Cidade Cidade { get; set; }
    }
   
}
