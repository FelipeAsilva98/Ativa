using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investment.Models
{
    public class Operacao
    {
        public enum { Aplicacao, Resgate }
        public int id { get; set; }
        public DateTime today { get; set; }
       
    }
}