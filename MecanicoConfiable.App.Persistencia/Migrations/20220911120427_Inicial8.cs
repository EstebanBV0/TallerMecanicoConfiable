using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MecanicoConfiable.App.Persistencia.Migrations
{
    public partial class Inicial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dueños_Vehiculos_IdVehiculo",
                table: "Dueños");

            migrationBuilder.AlterColumn<int>(
                name: "IdVehiculo",
                table: "Dueños",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Dueños_Vehiculos_IdVehiculo",
                table: "Dueños",
                column: "IdVehiculo",
                principalTable: "Vehiculos",
                principalColumn: "IdVehiculo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dueños_Vehiculos_IdVehiculo",
                table: "Dueños");

            migrationBuilder.AlterColumn<int>(
                name: "IdVehiculo",
                table: "Dueños",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dueños_Vehiculos_IdVehiculo",
                table: "Dueños",
                column: "IdVehiculo",
                principalTable: "Vehiculos",
                principalColumn: "IdVehiculo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
