using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Models
{
    interface IOperacao
    {
        String Investir();
        String Resgatar();
    }
}
