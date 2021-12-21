using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudProjeto365.Migrations
{
    public partial class Banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Cliente_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Cliente_id);
                });

            migrationBuilder.CreateTable(
                name: "passagem",
                columns: table => new
                {
                    Passagem_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Horario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poltrona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Classe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preço = table.Column<double>(type: "float", nullable: false),
                    Cliente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passagem", x => x.Passagem_id);
                    table.ForeignKey(
                        name: "FK_passagem_cliente_Cliente_id",
                        column: x => x.Cliente_id,
                        principalTable: "cliente",
                        principalColumn: "Cliente_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_passagem_Cliente_id",
                table: "passagem",
                column: "Cliente_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "passagem");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
