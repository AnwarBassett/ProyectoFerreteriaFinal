using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FerreteriaWEB.Modelos
{
    public class Proveedor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdProveedor { get; set; }
        public string? NombreProveedor { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Direccion { get; set; }
        [Required]
        public int IdRuc { get; set; }
        [ForeignKey("IdRuc")]
        public Ruc ruc { get; set; }
        
    }
}
