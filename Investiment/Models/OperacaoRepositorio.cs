using Investment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investment.Models
{
    public class OperacaoRepositorio : IOperacao

   
    public String Investir(String cpf,int idFundo, double valor) { 
        
        return ("cpf ="cpf, "idFundo =" idFundo, "valorInvestido =" valor, "data =" DateTime.Now);
    }

    

    public String Resgatar(String cpf,int idFundo, double valor)
        {
        return ("cpf ="cpf, "idFundo =" idFundo, "valorRetirado =" valor, "data =" DateTime.Now);
    }
    }
}