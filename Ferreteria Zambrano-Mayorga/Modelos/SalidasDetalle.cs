namespace Ferreteria_Zambrano_Mayorga.Modelos
{
    public class SalidasDetalle
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public string? NombreProducto { get; set; }
        public int CantidadProducto { get; set; }
        public double PrecioUnitario { get; set; }
        public double SubTotal { get; set; }
        public int SalidaId { get; set; }
    }
}