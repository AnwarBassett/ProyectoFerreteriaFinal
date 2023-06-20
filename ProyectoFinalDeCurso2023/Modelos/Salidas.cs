﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FerreteriaWEB.Modelos
{
    public class Salidas
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdFactura { get; set; }
        [Required]
        public int IdClients { get; set; }
        [Required]
        public string? NombreCliente { get; set; }
        [Required]
        public DateTime FechaRegistroSalida { get; set; }
        [Required]
        public int IdVendedor { get; set; }
        [Required]
        public string? NombreUsuario { get; set; }
        public double MontoTotal { get; set; }
    }

}
