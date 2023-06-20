using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FerreteriaWEB.Migrations
{
    /// <inheritdoc />
    public partial class DataFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rucs",
                columns: table => new
                {
                    IdRuc = table.Column<int>(type: "int", nullable: false),
                    TipoRuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaActivacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rucs", x => x.IdRuc);
                });

            migrationBuilder.CreateTable(
                name: "salidas",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClients = table.Column<int>(type: "int", nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistroSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdVendedor = table.Column<int>(type: "int", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontoTotal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salidas", x => x.IdFactura);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRuc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_clientes_rucs_IdRuc",
                        column: x => x.IdRuc,
                        principalTable: "rucs",
                        principalColumn: "IdRuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRuc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedores", x => x.IdProveedor);
                    table.ForeignKey(
                        name: "FK_proveedores_rucs_IdRuc",
                        column: x => x.IdRuc,
                        principalTable: "rucs",
                        principalColumn: "IdRuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRuc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_usuarios_rucs_IdRuc",
                        column: x => x.IdRuc,
                        principalTable: "rucs",
                        principalColumn: "IdRuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "salidaDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantidadProducto = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salidaDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_salidaDetalles_salidas_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "salidas",
                        principalColumn: "IdFactura",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Productos_proveedores_IdProveedor",
                        column: x => x.IdProveedor,
                        principalTable: "proveedores",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "rucs",
                columns: new[] { "IdRuc", "Activo", "FechaActivacion", "TipoRuc" },
                values: new object[,]
                {
                    { 12345, true, new DateTime(2014, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empresarial" },
                    { 45632, true, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empresarial" },
                    { 98604, true, new DateTime(2015, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Personal" },
                    { 345709, true, new DateTime(2017, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Personal" }
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "IdCliente", "Contraseña", "IdRuc", "NombreCompleto" },
                values: new object[] { 1, "Aamm2345", 345709, "Juan" });

            migrationBuilder.InsertData(
                table: "proveedores",
                columns: new[] { "IdProveedor", "Direccion", "IdRuc", "NombreProveedor", "NumeroDocumento" },
                values: new object[,]
                {
                    { 1, "Barrio Huembes", 12345, "Pedro Fulano", "PDF1" },
                    { 2, "Barrio Rafaela Herrera", 45632, "Luna MAriela", "PDF2" }
                });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "IdUsuario", "Clave", "Descripcion", "IdRuc", "NombreCompleto", "NombreUsuario" },
                values: new object[] { 1, "abbm3114", "Trabaja desde hace un año", 98604, "Anwar Amir Bassett Mayorga", "Anwar" });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Cantidad", "Categoria", "Descripcion", "Fecha", "IdProveedor", "NombreProducto", "Precio" },
                values: new object[] { 1, 25, "Herramientas", "Taladro para taladrar", new DateTime(2018, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Taladro", 2500 });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_IdRuc",
                table: "clientes",
                column: "IdRuc");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdProveedor",
                table: "Productos",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_proveedores_IdRuc",
                table: "proveedores",
                column: "IdRuc");

            migrationBuilder.CreateIndex(
                name: "IX_salidaDetalles_SalidaId",
                table: "salidaDetalles",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_IdRuc",
                table: "usuarios",
                column: "IdRuc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "salidaDetalles");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "proveedores");

            migrationBuilder.DropTable(
                name: "salidas");

            migrationBuilder.DropTable(
                name: "rucs");
        }
    }
}
