﻿// <auto-generated />
using System;
using FerreteriaWEB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FerreteriaWEB.Migrations
{
    [DbContext(typeof(FerreteriaContext))]
    partial class FerreteriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FerreteriaWEB.Modelos.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRuc")
                        .HasColumnType("int");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.HasIndex("IdRuc");

                    b.ToTable("clientes");

                    b.HasData(
                        new
                        {
                            IdCliente = 1,
                            Contraseña = "Aamm2345",
                            IdRuc = 345709,
                            NombreCompleto = "Juan"
                        });
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.Productos", b =>
                {
                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProveedor")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.HasIndex("IdProveedor");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            IdProducto = 1,
                            Cantidad = 25,
                            Categoria = "Herramientas",
                            Descripcion = "Taladro para taladrar",
                            Fecha = new DateTime(2018, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProveedor = 1,
                            NombreProducto = "Taladro",
                            Precio = 2500
                        });
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProveedor"));

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRuc")
                        .HasColumnType("int");

                    b.Property<string>("NombreProveedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProveedor");

                    b.HasIndex("IdRuc");

                    b.ToTable("proveedores");

                    b.HasData(
                        new
                        {
                            IdProveedor = 1,
                            Direccion = "Barrio Huembes",
                            IdRuc = 12345,
                            NombreProveedor = "Pedro Fulano",
                            NumeroDocumento = "PDF1"
                        },
                        new
                        {
                            IdProveedor = 2,
                            Direccion = "Barrio Rafaela Herrera",
                            IdRuc = 45632,
                            NombreProveedor = "Luna MAriela",
                            NumeroDocumento = "PDF2"
                        });
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.Ruc", b =>
                {
                    b.Property<int>("IdRuc")
                        .HasColumnType("int");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaActivacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("TipoRuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRuc");

                    b.ToTable("rucs");

                    b.HasData(
                        new
                        {
                            IdRuc = 12345,
                            Activo = true,
                            FechaActivacion = new DateTime(2014, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TipoRuc = "Empresarial"
                        },
                        new
                        {
                            IdRuc = 45632,
                            Activo = true,
                            FechaActivacion = new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TipoRuc = "Empresarial"
                        },
                        new
                        {
                            IdRuc = 98604,
                            Activo = true,
                            FechaActivacion = new DateTime(2015, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TipoRuc = "Personal"
                        },
                        new
                        {
                            IdRuc = 345709,
                            Activo = true,
                            FechaActivacion = new DateTime(2017, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TipoRuc = "Personal"
                        });
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.SalidaDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantidadProducto")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioUnitario")
                        .HasColumnType("float");

                    b.Property<int>("SalidaId")
                        .HasColumnType("int");

                    b.Property<double>("SubTotal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("SalidaId");

                    b.ToTable("salidaDetalles");
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.Salidas", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFactura"));

                    b.Property<DateTime>("FechaRegistroSalida")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClients")
                        .HasColumnType("int");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("int");

                    b.Property<double>("MontoTotal")
                        .HasColumnType("float");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFactura");

                    b.ToTable("salidas");
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRuc")
                        .HasColumnType("int");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdRuc");

                    b.ToTable("usuarios");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1,
                            Clave = "abbm3114",
                            Descripcion = "Trabaja desde hace un año",
                            IdRuc = 98604,
                            NombreCompleto = "Anwar Amir Bassett Mayorga",
                            NombreUsuario = "Anwar"
                        });
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.Cliente", b =>
                {
                    b.HasOne("FerreteriaWEB.Modelos.Ruc", "ruc")
                        .WithMany()
                        .HasForeignKey("IdRuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ruc");
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.Productos", b =>
                {
                    b.HasOne("FerreteriaWEB.Modelos.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("IdProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.Proveedor", b =>
                {
                    b.HasOne("FerreteriaWEB.Modelos.Ruc", "ruc")
                        .WithMany()
                        .HasForeignKey("IdRuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ruc");
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.SalidaDetalle", b =>
                {
                    b.HasOne("FerreteriaWEB.Modelos.Salidas", "Salidas")
                        .WithMany()
                        .HasForeignKey("SalidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salidas");
                });

            modelBuilder.Entity("FerreteriaWEB.Modelos.Usuario", b =>
                {
                    b.HasOne("FerreteriaWEB.Modelos.Ruc", "ruc")
                        .WithMany()
                        .HasForeignKey("IdRuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ruc");
                });
#pragma warning restore 612, 618
        }
    }
}
