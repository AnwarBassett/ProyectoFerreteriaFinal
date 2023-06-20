using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Zambrano_Mayorga.Modelos
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string? NombreProveedor { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Direccion { get; set; }
        public int IdRuc { get; set; }
    }
}
