using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudProjeto365.Migrations
{
    public partial class AgenciaViagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Pessoa_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Pessoa_id);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Cliente_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Contato", x => x.Cliente_id);
                });

            migrationBuilder.CreateTable(
                name: "Promocao",
                columns: table => new
                {
                    Passageiro_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocao", x => x.Passageiro_id);
                });

            migrationBuilder.CreateTable(
                name: "Passagem",
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
                    table.PrimaryKey("PK_Passagem", x => x.Passagem_id);
                    table.ForeignKey(
                        name: "FK_Passagem_Contato_Cliente_id",
                        column: x => x.Cliente_id,
                        principalTable: "Contato",
                        principalColumn: "Cliente_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passagem_Cliente_id",
                table: "Passagem",
                column: "Cliente_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Passagem");

            migrationBuilder.DropTable(
                name: "Promocao");

            migrationBuilder.DropTable(
                name: "Contato");
        }
    }
}
