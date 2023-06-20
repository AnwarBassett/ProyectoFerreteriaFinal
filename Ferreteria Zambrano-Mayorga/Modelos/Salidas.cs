using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria_Zambrano_Mayorga.Modelos;

namespace Ferreteria_Zambrano_Mayorga.Modelos
{
    public class Salidas
    {

        public int IdFactura { get; set; }
        public int IdClients { get; set; }
        public string? NombreCliente { get; set; }
        public DateTime FechaRegistroSalida { get; set; }
        public int IdVendedor { get; set; }
        public string? NombreUsuario { get; set; }
        public double MontoTotal { get; set; }
    }
}
