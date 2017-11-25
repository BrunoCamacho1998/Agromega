using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agromega.Models
{
    public class Precio_Actual
    {
        public int Precio_ActualId { get; set; }
        public string Año { get; set; }
        public int Precio { get; set; }
        public int ProduccionId { get; set; }
        public Produccion Produccion { get; set; }
    }
}