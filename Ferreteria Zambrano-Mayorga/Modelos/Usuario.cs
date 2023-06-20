using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Zambrano_Mayorga.Modelos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string? NombreCompleto { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Clave { get; set; }
        public string? Descripcion { get; set; }
        public int IdRuc { get; set; }
    }
}
