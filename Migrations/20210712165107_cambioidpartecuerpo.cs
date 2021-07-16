using Microsoft.EntityFrameworkCore.Migrations;

namespace primerParcial.Migrations
{
    public partial class cambioidpartecuerpo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActividadId",
                table: "PartesDelCuerpo",
                newName: "ParteDelCuerpoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParteDelCuerpoId",
                table: "PartesDelCuerpo",
                newName: "ActividadId");
        }
    }
}
