using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FerreteriaWEB.Modelos
{
    public class Cliente
    {

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public string? NombreCompleto { get; set; }
        [Required]
        public string Contraseña { get; set; }
        [Required]
        public int IdRuc { get; set; }
        [ForeignKey("IdRuc")]
        public Ruc ruc { get; set; }

    }
}
