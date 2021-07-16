using Microsoft.EntityFrameworkCore.Migrations;

namespace primerParcial.Migrations
{
    public partial class pkactividad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Objetivos_ObjetivoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dias_Rutinas_RutinaId",
                table: "Dias");

            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoId",
                table: "Ejercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Ejercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Rutinas_Clientes_ClienteDNI",
                table: "Rutinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actividades",
                table: "Actividades");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteDNI",
                table: "Rutinas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParteDelCuerpoId",
                table: "Ejercicios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Ejercicios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

            migrationBuilder.AlterColumn<int>(
                name: "RutinaId",
                table: "Dias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ObjetivoId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActividadId",
                table: "Actividades",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actividades",
                table: "Actividades",
                column: "ActividadId");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_EjercicioId",
                table: "Actividades",
                column: "EjercicioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Objetivos_ObjetivoId",
                table: "Clientes",
                column: "ObjetivoId",
                principalTable: "Objetivos",
                principalColumn: "ObjetivoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dias_Rutinas_RutinaId",
                table: "Dias",
                column: "RutinaId",
                principalTable: "Rutinas",
                principalColumn: "RutinaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoId",
                table: "Ejercicios",
                column: "MusculoId",
                principalTable: "Musculos",
                principalColumn: "MusculoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicios_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Ejercicios",
                column: "ParteDelCuerpoId",
                principalTable: "PartesDelCuerpo",
                principalColumn: "ParteDelCuerpoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rutinas_Clientes_ClienteDNI",
                table: "Rutinas",
                column: "ClienteDNI",
                principalTable: "Clientes",
                principalColumn: "DNI",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Objetivos_ObjetivoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dias_Rutinas_RutinaId",
                table: "Dias");

            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoId",
                table: "Ejercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Ejercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Rutinas_Clientes_ClienteDNI",
                table: "Rutinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actividades",
                table: "Actividades");

            migrationBuilder.DropIndex(
                name: "IX_Actividades_EjercicioId",
                table: "Actividades");

            migrationBuilder.DropColumn(
                name: "ActividadId",
                table: "Actividades");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteDNI",
                table: "Rutinas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ParteDelCuerpoId",
                table: "Ejercicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Ejercicios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MusculoId",
                table: "Ejercicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RutinaId",
                table: "Dias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ObjetivoId",
                table: "Clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actividades",
                table: "Actividades",
                column: "EjercicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Objetivos_ObjetivoId",
                table: "Clientes",
                column: "ObjetivoId",
                principalTable: "Objetivos",
                principalColumn: "ObjetivoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dias_Rutinas_RutinaId",
                table: "Dias",
                column: "RutinaId",
                principalTable: "Rutinas",
                principalColumn: "RutinaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoId",
                table: "Ejercicios",
                column: "MusculoId",
                principalTable: "Musculos",
                principalColumn: "MusculoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicios_PartesDelCuerpo_ParteDelCuerpoId",
                table: "Ejercicios",
                column: "ParteDelCuerpoId",
                principalTable: "PartesDelCuerpo",
                principalColumn: "ParteDelCuerpoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rutinas_Clientes_ClienteDNI",
                table: "Rutinas",
                column: "ClienteDNI",
                principalTable: "Clientes",
                principalColumn: "DNI",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
