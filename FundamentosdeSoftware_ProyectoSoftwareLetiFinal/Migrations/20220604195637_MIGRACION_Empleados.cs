using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Migrations
{
    public partial class MIGRACION_Empleados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido_Paterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido_Materno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rol_Asignado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RFC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
