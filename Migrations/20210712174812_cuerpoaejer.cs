using Microsoft.EntityFrameworkCore.Migrations;

namespace primerParcial.Migrations
{
    public partial class cuerpoaejer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParteDelCuerpoId",
                table: "Ejercicios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ejercicios_ParteDelCuerpoId",
                table: "Ejercicios",
                column: "ParteDelCuerpoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicios_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Ejercicios",
                column: "ParteDelCuerpoId",
                principalTable: "PartesDelCuerpo",
                principalColumn: "ParteDelCuerpoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Ejercicios");

            migrationBuilder.DropIndex(
                name: "IX_Ejercicios_ParteDelCuerpoId",
                table: "Ejercicios");

            migrationBuilder.DropColumn(
                name: "ParteDelCuerpoId",
                table: "Ejercicios");
        }
    }
}
