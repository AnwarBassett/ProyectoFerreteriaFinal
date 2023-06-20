using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FerreteriaWEB.Modelos
{
    public class Usuario
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [ForeignKey("IdRuc")]
        public Ruc ruc { get; set; }
        
    }
}
