using Investment.Models;
using Investment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Investment.Controllers
{
    public class ClientesController : ApiController
    {
        static readonly IClienteRepositorio repositorio = new ClienteRepositorio();
        public IEnumerable<Cliente> GetAllFundos()
        {
            return repositorio.GetAll();
        }

        public void PostCliente(Cliente cliente)
        {
            repositorio.Add(cliente);
            
        }
    }
}
