using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FerreteriaWEB.Modelos
{
    public class Productos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        
        public int IdProducto { get; set; }
        [Required]
        public string? NombreProducto { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public string? Descripcion { get; set; }
        [Required]
        public string? Categoria { get; set; }
        public int IdProveedor { get; set; }
        [ForeignKey("IdProveedor")]
        public Proveedor Proveedor { get; set; }
    }
}
