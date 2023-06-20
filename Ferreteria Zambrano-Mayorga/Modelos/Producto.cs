using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_Zambrano_Mayorga.Modelos
{
    public class Producto
    {
        public int IdProducto { get; set; }
        
        public string? NombreProducto { get; set; }
        
        public int Precio { get; set; }
        
        public int Cantidad { get; set; }
        
        public DateTime Fecha { get; set; }
        
        public string? Descripcion { get; set; }
        
        public string? Categoria { get; set; }
        public int IdProveedor { get; set; }
    }
}
