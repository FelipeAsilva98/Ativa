using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investment.Models
{
    public class Fundos
    {
        public String razaoSocial { get; set; }
        public String cnpj { get; set; }

        public int id { get; set; }

        public Double aplicacaoMinima { get; set; }

        
    }
}