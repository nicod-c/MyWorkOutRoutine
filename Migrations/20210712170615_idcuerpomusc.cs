using Microsoft.EntityFrameworkCore.Migrations;

namespace primerParcial.Migrations
{
    public partial class idcuerpomusc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musculos_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Musculos");

            migrationBuilder.AlterColumn<int>(
                name: "ParteDelCuerpoId",
                table: "Musculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Musculos_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Musculos",
                column: "ParteDelCuerpoId",
                principalTable: "PartesDelCuerpo",
                principalColumn: "ParteDelCuerpoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musculos_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Musculos");

            migrationBuilder.AlterColumn<int>(
                name: "ParteDelCuerpoId",
                table: "Musculos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Musculos_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Musculos",
                column: "ParteDelCuerpoId",
                principalTable: "PartesDelCuerpo",
                principalColumn: "ParteDelCuerpoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
