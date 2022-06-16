using Microsoft.EntityFrameworkCore.Migrations;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Migrations
{
    public partial class MigracionServidor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MServidor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pedido = table.Column<int>(type: "int", nullable: false),
                    NombrePlatillo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaracteristicasPlat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioPlat = table.Column<double>(type: "float", nullable: false),
                    CantidadPlat = table.Column<double>(type: "float", nullable: false),
                    NombreBebida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaracteristicasBebi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioBebi = table.Column<double>(type: "float", nullable: false),
                    CantidadBebi = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MServidor", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MServidor");
        }
    }
}
