using Microsoft.EntityFrameworkCore.Migrations;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Migrations
{
    public partial class migracionOrden3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroPedido = table.Column<int>(type: "int", nullable: false),
                    NombrePlatillo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioPlatillo = table.Column<double>(type: "float", nullable: false),
                    CantidadPLatillo = table.Column<int>(type: "int", nullable: false),
                    ComentarioPlatillo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreBebida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioBebida = table.Column<double>(type: "float", nullable: false),
                    CantidadBebida = table.Column<int>(type: "int", nullable: false),
                    ComentarioBebida = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orden");
        }
    }
}
