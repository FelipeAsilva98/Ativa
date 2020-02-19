using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investment.Models
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private List<Cliente> clientesCadastrados = new List<Cliente>();

        public ClienteRepositorio()
        {
            Add(new Cliente { cpf = "15628935727" });
            Add(new Cliente { cpf = "70727066749" });
            Add(new Cliente { cpf = "12345678910" });
        }

        public void Add(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new NotImplementedException("Insira de novo!");
            }
            clientesCadastrados.Add(cliente);

        }

        public IEnumerable<Cliente> GetAll()
        {
            return clientesCadastrados;
        }
    }
}