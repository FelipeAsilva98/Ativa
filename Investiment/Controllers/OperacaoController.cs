using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Investment.Models

namespace Investment.Controllers
{
    public class OperacaoController : ApiController
    {
        

        public IEnumerable<Operacao> GetInvestir()
        {
            return OperacaoRepositorio.Investir();
        }
    }
}
