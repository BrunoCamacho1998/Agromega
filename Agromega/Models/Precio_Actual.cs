using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agromega.Models
{
    public class Precio_Actual
    {
        public int Precio_ActualId { get; set; }
       
        public int ProduccionId { get; set; }
        public Produccion Produccion { get; set; }

        public double? F1 { get; set; }
        public double? F2 { get; set; }
        public double? F3 { get; set; }
        public double? F4 { get; set; }
        public double? P1 { get; set; }
        public double? P2 { get; set; }
        public double? T14 { get; set; }
        public double? T15 { get; set; }
        public double? T16 { get; set; }
        public double? T17 { get; set; }
        public double? T1 { get; set; }
        public double? T2 { get; set; }
    }
}