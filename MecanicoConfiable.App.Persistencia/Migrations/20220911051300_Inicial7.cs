using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MecanicoConfiable.App.Persistencia.Migrations
{
    public partial class Inicial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Auxiliar",
                table: "Auxiliar");

            migrationBuilder.RenameTable(
                name: "Auxiliar",
                newName: "Auxiliares");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auxiliares",
                table: "Auxiliares",
                column: "IdAuxiliar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Auxiliares",
                table: "Auxiliares");

            migrationBuilder.RenameTable(
                name: "Auxiliares",
                newName: "Auxiliar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auxiliar",
                table: "Auxiliar",
                column: "IdAuxiliar");
        }
    }
}
