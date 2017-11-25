using Agromega.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agromega.Services
{
    interface IProduccionServices
    {
        List<Produccion> GetProd(string suelo, string cultivo);
    }
}
