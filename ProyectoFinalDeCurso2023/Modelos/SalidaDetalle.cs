using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FerreteriaWEB.Modelos
{
    public class SalidaDetalle
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public string? NombreProducto { get; set; }
        public int CantidadProducto { get; set; }
        public double PrecioUnitario { get; set; }
        public double SubTotal { get; set; }
        public int SalidaId { get; set; }
        [ForeignKey("SalidaId")]
        public Salidas Salidas { get; set; }
    }
}