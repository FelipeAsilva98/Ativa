using Investment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Models
{
    interface IFundosRepositorio
    {
        IEnumerable<Fundos> GetAll();
        Fundos Get(int id);
        Fundos Add(Fundos empresa);
        void Remove(int id);

    }
}
