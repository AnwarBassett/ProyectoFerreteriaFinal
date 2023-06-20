using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FerreteriaWEB.Modelos
{
    public class Ruc
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
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
