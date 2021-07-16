using Microsoft.EntityFrameworkCore.Migrations;

namespace primerParcial.Migrations
{
    public partial class agregoids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoId",
                table: "Ejercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Musculos_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Musculos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PartesDelCuerpo",
                newName: "ActividadId");

            migrationBuilder.AlterColumn<int>(
                name: "ParteDelCuerpoId",
                table: "Musculos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Musculos_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Musculos",
                column: "ParteDelCuerpoId",
                principalTable: "PartesDelCuerpo",
                principalColumn: "ActividadId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoId",
                table: "Ejercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Musculos_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Musculos");

            migrationBuilder.DropColumn(
                name: "ActividadId",
                table: "Ejercicios");

            migrationBuilder.RenameColumn(
                name: "ActividadId",
                table: "PartesDelCuerpo",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "ParteDelCuerpoId",
                table: "Musculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Musculos_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Musculos",
                column: "ParteDelCuerpoId",
                principalTable: "PartesDelCuerpo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
