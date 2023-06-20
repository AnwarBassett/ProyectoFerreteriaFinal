using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Zambrano_Mayorga.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string? NombreCompleto { get; set; }
        public string Contraseña { get; set; }
        public int IdRuc { get; set; }
    }
}
