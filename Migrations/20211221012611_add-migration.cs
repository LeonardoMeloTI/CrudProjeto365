using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudProjeto365.Migrations
{
    public partial class addmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promocao",
                columns: table => new
                {
                    Promocao_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Embarque = table.Column<int>(type: "int", nullable: false),
                    Desembarque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocao", x => x.Promocao_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promocao");
        }
    }
}
