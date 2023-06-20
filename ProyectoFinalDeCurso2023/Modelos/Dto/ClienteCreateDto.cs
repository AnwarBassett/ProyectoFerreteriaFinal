﻿using System.ComponentModel.DataAnnotations;

namespace FerreteriaWEB.Modelos.Dto
{
    public class ClienteCreateDto
    {
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public string? NombreCompleto { get; set; }
        [Required]
        public string Contraseña { get; set; }
        [Required]
        public int IdRuc { get; set; }
    }
}
