using Microsoft.EntityFrameworkCore.Migrations;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Migrations
{
    public partial class Migracionfff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menuu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Platillo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caracter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menuu", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menuu");
        }
    }
}
