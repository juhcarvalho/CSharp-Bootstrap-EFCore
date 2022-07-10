using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_de_Habito.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Objetivo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Dias = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Horario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habito", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habito");
        }
    }
}
