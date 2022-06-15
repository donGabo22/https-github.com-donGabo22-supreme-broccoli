using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Migrations
{
    public partial class migracFab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "MeserOrd");

            migrationBuilder.DropColumn(
                name: "MesaNum",
                table: "MeserOrd");

            migrationBuilder.AlterColumn<string>(
                name: "PedidoNum",
                table: "MeserOrd",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Registradora",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pedido = table.Column<int>(type: "int", nullable: false),
                    Platillo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaracteristicasP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreciOP = table.Column<double>(type: "float", nullable: false),
                    CantidadP = table.Column<double>(type: "float", nullable: false),
                    TotalP = table.Column<double>(type: "float", nullable: false),
                    Bebida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaracteristicasB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioB = table.Column<double>(type: "float", nullable: false),
                    CantidadB = table.Column<double>(type: "float", nullable: false),
                    TotalB = table.Column<double>(type: "float", nullable: false),
                    TotalF = table.Column<double>(type: "float", nullable: false),
                    Efectivo = table.Column<double>(type: "float", nullable: false),
                    Devolucion = table.Column<double>(type: "float", nullable: false),
                    Fecha_Venta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registradora", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registradora");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoNum",
                table: "MeserOrd",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "MeserOrd",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MesaNum",
                table: "MeserOrd",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
