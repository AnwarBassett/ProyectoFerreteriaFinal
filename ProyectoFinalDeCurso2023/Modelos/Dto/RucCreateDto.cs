using System.ComponentModel.DataAnnotations;

namespace FerreteriaWEB.Modelos.Dto
{
    public class RucCreateDto
    {
        [Required]
        public int IdRuc { get; set; }
        [Required]
        public string TipoRuc { get; set; }
        [Required]
        public DateTime FechaActivacion { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}
