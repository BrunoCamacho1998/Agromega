using Agromega.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agromega.Models;

namespace Agromega.Services
{
    public class ProduccionServices :IProduccionServices
    {
        IProduccionRepository prodres;

        public ProduccionServices()
        {
            prodres = new ProduccionRepository();
        }

        public List<Produccion> GetProd(string suelo, string cultivo)
        {
            return prodres.GetCultivoSuelo(suelo, cultivo);
        }
    }
}