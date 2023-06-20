using System.ComponentModel.DataAnnotations;

namespace FerreteriaWEB.Modelos.Dto
{
    public class ProveedorCreateDto
    {
        [Required]
        public int IdProveedor { get; set; }
        [Required]
        public string? NombreProveedor { get; set; }
        [Required]
        public string? NumeroDocumento { get; set; }
        [Required]
        public string? Direccion { get; set; }
        [Required]
        public int IdRuc { get; set; }
    }
}
