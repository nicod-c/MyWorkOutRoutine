using Microsoft.EntityFrameworkCore.Migrations;

namespace primerParcial.Migrations
{
    public partial class ids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoId",
                table: "Ejercicios");

            migrationBuilder.DropColumn(
                name: "ActividadId",
                table: "Ejercicios");

            migrationBuilder.AlterColumn<int>(
                name: "MusculoId",
                table: "Ejercicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoId",
                table: "Ejercicios",
                column: "MusculoId",
                principalTable: "Musculos",
                principalColumn: "MusculoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoId",
                table: "Ejercicios");

            migrationBuilder.AlterColumn<int>(
                name: "MusculoId",
                table: "Ejercicios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActividadId",
                table: "Ejercicios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoId",
                table: "Ejercicios",
                column: "MusculoId",
                principalTable: "Musculos",
                principalColumn: "MusculoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
