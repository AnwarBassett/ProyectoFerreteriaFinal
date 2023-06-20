using FerreteriaWEB.Modelos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FerreteriaWEB.Data
{
    public class FerreteriaContext: DbContext
    {
        public FerreteriaContext(DbContextOptions<FerreteriaContext> options) : base(options)
        {

        }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Proveedor> proveedores { get; set; }
        public DbSet<SalidaDetalle> salidaDetalles { get; set; }
        public DbSet<Salidas> salidas { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Ruc> rucs { get; set; }

        

        //public List<SalidaDetalle> DS= new List<SalidaDetalle>();
        //SalidaDetalle salidaDetalle = new SalidaDetalle
        //{
        //    Id = 1,
        //    IdProducto = 1,
        //    CantidadProducto =2,
        //    PrecioUnitario=2500,
        //    SubTotal = 5000,
        //};
        //DS.Add
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ruc>().HasData(
                new Ruc()
                {
                    IdRuc = 12345,
                    TipoRuc = "Empresarial",
                    FechaActivacion = new DateTime(2014, 2, 4),
                    Activo = true
                },
                new Ruc()
                {
                    IdRuc = 45632,
                    TipoRuc = "Empresarial",
                    FechaActivacion = new DateTime(2016, 9, 1),
                    Activo = true
                },
                new Ruc()
                {
                    IdRuc = 98604,
                    TipoRuc = "Personal",
                    FechaActivacion = new DateTime(2015, 3, 12),
                    Activo = true
                },
                new Ruc()
                {
                    IdRuc = 345709,
                    TipoRuc = "Personal",
                    FechaActivacion = new DateTime(2017, 10, 5),
                    Activo = true

                });
            modelBuilder.Entity<Productos>().HasData(
                     new Productos()
                     {
                         IdProducto = 1,
                         NombreProducto = "Taladro",
                         Fecha = new DateTime(2018, 7, 8),
                         Descripcion = "Taladro para taladrar",
                         Categoria = "Herramientas",
                         Cantidad = 25,
                         Precio = 2500,
                         IdProveedor = 1
                     });
            modelBuilder.Entity<Proveedor>().HasData(
                new Proveedor()
                {
                    IdProveedor = 1,
                    NumeroDocumento = "PDF1",
                    NombreProveedor = "Pedro Fulano",
                    IdRuc = 12345,
                    Direccion = "Barrio Huembes"

                },
                new Proveedor()
                {
                    IdProveedor = 2,
                    NumeroDocumento = "PDF2",
                    NombreProveedor = "Luna MAriela",
                    IdRuc = 45632,
                    Direccion = "Barrio Rafaela Herrera"
                });
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario()
                {
                    IdUsuario = 1,
                    NombreCompleto = "Anwar Amir Bassett Mayorga",
                    NombreUsuario = "Anwar",
                    Clave = "abbm3114",
                    Descripcion = "Trabaja desde hace un año",
                    IdRuc = 98604
                });
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    NombreCompleto = "Juan",
                    IdCliente = 1,
                    Contraseña = "Aamm2345",
                    IdRuc = 345709
                });
        }
    }
}
