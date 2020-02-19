using Investment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investment.Models
{
    public class FundosRepositorio : IFundosRepositorio
    {
        private List<Fundos> empresasCadastradas = new List<Fundos>();

        public FundosRepositorio()
        {
            Add(new Fundos { razaoSocial = "GSK", cnpj = "123", aplicacaoMinima = 1000.00 });
            Add(new Fundos { razaoSocial = "Novartis", cnpj = "456", aplicacaoMinima = 2000.00 });
            Add(new Fundos { razaoSocial = "Pfizer", cnpj = "789", aplicacaoMinima = 3000.00 });
        }
        public Fundos Add(Fundos empresa)
        {
            if(empresa == null)
            {
                throw new NotImplementedException("Insira De novo");
            }
            empresasCadastradas.Add(empresa);
            return empresa;
        }

        public Fundos Get(int id)
        {
            return empresasCadastradas.Find(p => p.id == id);
        }

        public IEnumerable<Fundos> GetAll()
        {
            return empresasCadastradas;
        }

        public void Remove(int id)
        {
            empresasCadastradas.RemoveAll(p => p.id == id);
        }
    }
}