using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendamientoCitas.App.Persistencia.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdDoctor",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "IdEncuesta",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "IdSede",
                table: "Citas");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Sedes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "PrestadoresDeServicios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RazonSocial",
                table: "PrestadoresDeServicios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nit",
                table: "PrestadoresDeServicios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PrestadoresDeServicios",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SedeId",
                table: "PrestadoresDeServicios",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Personas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Encuestas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Citas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Citas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EncuestaId",
                table: "Citas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Citas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SedeId",
                table: "Citas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrestadoresDeServicios_SedeId",
                table: "PrestadoresDeServicios",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_DoctorId",
                table: "Citas",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_EncuestaId",
                table: "Citas",
                column: "EncuestaId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_PacienteId",
                table: "Citas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_SedeId",
                table: "Citas",
                column: "SedeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Encuestas_EncuestaId",
                table: "Citas",
                column: "EncuestaId",
                principalTable: "Encuestas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Personas_DoctorId",
                table: "Citas",
                column: "DoctorId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Personas_PacienteId",
                table: "Citas",
                column: "PacienteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Sedes_SedeId",
                table: "Citas",
                column: "SedeId",
                principalTable: "Sedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrestadoresDeServicios_Sedes_SedeId",
                table: "PrestadoresDeServicios",
                column: "SedeId",
                principalTable: "Sedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Encuestas_EncuestaId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Personas_DoctorId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Personas_PacienteId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Sedes_SedeId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_PrestadoresDeServicios_Sedes_SedeId",
                table: "PrestadoresDeServicios");

            migrationBuilder.DropIndex(
                name: "IX_PrestadoresDeServicios_SedeId",
                table: "PrestadoresDeServicios");

            migrationBuilder.DropIndex(
                name: "IX_Citas_DoctorId",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_EncuestaId",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_PacienteId",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_SedeId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "SedeId",
                table: "PrestadoresDeServicios");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "EncuestaId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "SedeId",
                table: "Citas");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sedes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "PrestadoresDeServicios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RazonSocial",
                table: "PrestadoresDeServicios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nit",
                table: "PrestadoresDeServicios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "PrestadoresDeServicios",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Personas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Encuestas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Citas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "IdDoctor",
                table: "Citas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdEncuesta",
                table: "Citas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdPaciente",
                table: "Citas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdSede",
                table: "Citas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
