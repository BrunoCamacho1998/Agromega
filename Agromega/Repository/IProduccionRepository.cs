using Agromega.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agromega.Repository
{
    public interface IProduccionRepository
    {
        List<Produccion> GetCultivoSuelo(string suelo,string Cultivo);
    }
}