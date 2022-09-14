﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MecanicoConfiable.App.Persistencia.Migrations
{
    public partial class tablavehiculo7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auxiliares",
                columns: table => new
                {
                    IdAuxiliar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auxiliares", x => x.IdAuxiliar);
                });

            migrationBuilder.CreateTable(
                name: "Mecanicos",
                columns: table => new
                {
                    IdMecanico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelEstudio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanicos", x => x.IdMecanico);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    IdVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroPasajeros = table.Column<int>(type: "int", nullable: false),
                    PaisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionAdicional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdMecanico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.IdVehiculo);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Mecanicos_IdMecanico",
                        column: x => x.IdMecanico,
                        principalTable: "Mecanicos",
                        principalColumn: "IdMecanico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CambioRepuestos",
                columns: table => new
                {
                    IdCambioRepuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdVehiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CambioRepuestos", x => x.IdCambioRepuesto);
                    table.ForeignKey(
                        name: "FK_CambioRepuestos_Vehiculos_IdVehiculo",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conductor",
                columns: table => new
                {
                    IdConductor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdVehiculo = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductor", x => x.IdConductor);
                    table.ForeignKey(
                        name: "FK_Conductor_Vehiculos_IdVehiculo",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dueños",
                columns: table => new
                {
                    IdDueño = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdVehiculo = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dueños", x => x.IdDueño);
                    table.ForeignKey(
                        name: "FK_Dueños_Vehiculos_IdVehiculo",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo");
                });

            migrationBuilder.CreateTable(
                name: "RevisionNiveles",
                columns: table => new
                {
                    IdNiveles = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelAceite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelLiquidoFrenos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelRefrigerante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelLiquidDireccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdVehiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevisionNiveles", x => x.IdNiveles);
                    table.ForeignKey(
                        name: "FK_RevisionNiveles_Vehiculos_IdVehiculo",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seguros",
                columns: table => new
                {
                    IdSeguro = table.Column<int>(type: "int", nullable: false),
                    TipoSeguro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCompra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaFinal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorSeguro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.IdSeguro);
                    table.ForeignKey(
                        name: "FK_Seguros_Vehiculos_IdSeguro",
                        column: x => x.IdSeguro,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Repuestos",
                columns: table => new
                {
                    IdRepuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Repuest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCambioRepuesto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuestos", x => x.IdRepuesto);
                    table.ForeignKey(
                        name: "FK_Repuestos_CambioRepuestos_IdCambioRepuesto",
                        column: x => x.IdCambioRepuesto,
                        principalTable: "CambioRepuestos",
                        principalColumn: "IdCambioRepuesto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CambioRepuestos_IdVehiculo",
                table: "CambioRepuestos",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Conductor_IdVehiculo",
                table: "Conductor",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Dueños_IdVehiculo",
                table: "Dueños",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Repuestos_IdCambioRepuesto",
                table: "Repuestos",
                column: "IdCambioRepuesto");

            migrationBuilder.CreateIndex(
                name: "IX_RevisionNiveles_IdVehiculo",
                table: "RevisionNiveles",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdMecanico",
                table: "Vehiculos",
                column: "IdMecanico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auxiliares");

            migrationBuilder.DropTable(
                name: "Conductor");

            migrationBuilder.DropTable(
                name: "Dueños");

            migrationBuilder.DropTable(
                name: "Repuestos");

            migrationBuilder.DropTable(
                name: "RevisionNiveles");

            migrationBuilder.DropTable(
                name: "Seguros");

            migrationBuilder.DropTable(
                name: "CambioRepuestos");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Mecanicos");
        }
    }
}