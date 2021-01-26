using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica_Veterinaria_3.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    Id_Consulta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataConsulta = table.Column<DateTime>(nullable: false),
                    QuemAgendou = table.Column<string>(nullable: false),
                    Cliente = table.Column<string>(nullable: false),
                    Nome_Animal = table.Column<string>(nullable: false),
                    Historico_Animal = table.Column<string>(nullable: false),
                    PresencaCliente = table.Column<bool>(nullable: false),
                    Medico = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.Id_Consulta);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulta");
        }
    }
}
