using Microsoft.EntityFrameworkCore.Migrations;

namespace primerParcial.Migrations
{
    public partial class relMMejerAct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actividades_Dias_DiaId",
                table: "Actividades");

            migrationBuilder.DropIndex(
                name: "IX_Actividades_EjercicioId",
                table: "Actividades");

            migrationBuilder.AlterColumn<int>(
                name: "DiaId",
                table: "Actividades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_EjercicioId",
                table: "Actividades",
                column: "EjercicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_Dias_DiaId",
                table: "Actividades",
                column: "DiaId",
                principalTable: "Dias",
                principalColumn: "DiaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actividades_Dias_DiaId",
                table: "Actividades");

            migrationBuilder.DropIndex(
                name: "IX_Actividades_EjercicioId",
                table: "Actividades");

            migrationBuilder.AlterColumn<int>(
                name: "DiaId",
                table: "Actividades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_EjercicioId",
                table: "Actividades",
                column: "EjercicioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_Dias_DiaId",
                table: "Actividades",
                column: "DiaId",
                principalTable: "Dias",
                principalColumn: "DiaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
