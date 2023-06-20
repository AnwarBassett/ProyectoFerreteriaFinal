using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Zambrano_Mayorga.Modelos
{
    public class Ruc
    {
        public int IdRuc { get; set; }
        public string TipoRuc { get; set; }
        public DateTime FechaActivacion { get; set; }
        public bool Activo { get; set; }
    }
}
