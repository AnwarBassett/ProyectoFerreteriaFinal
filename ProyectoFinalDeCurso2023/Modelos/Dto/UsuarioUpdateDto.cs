using System.ComponentModel.DataAnnotations;

namespace FerreteriaWEB.Modelos.Dto
{
    public class UsuarioUpdateDto
    {
        [Required]
        public int IdUsuario { get; set; }
        [Required]
        public string? NombreCompleto { get; set; }
        [Required]
        public string? NombreUsuario { get; set; }
        [Required]
        [MaxLength(10)]
        public string? Clave { get; set; }
        [Required]
        public string? Descripcion { get; set; }
        [Required]
        public int IdRuc { get; set; }
    }
}
