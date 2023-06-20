using System.ComponentModel.DataAnnotations;

namespace FerreteriaWEB.Modelos.Dto
{
    public class ProductosCreateDto
    {
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
        [Required]
        public int IdProveedor { get; set; }
    }
}
