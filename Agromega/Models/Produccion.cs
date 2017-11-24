using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agromega.Models
{
    public class Produccion
    {
        public int ProduccionId { get; set; }
        public string NombreProducto { get; set; }
        public int TipoClimaId { get; set; }
        public TipoClima TipoClima { get; set; }
        public int TipoSueloId { get; set; }
        public TipoSuelo TipoSuelo { get; set; }
    }
}