using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastrodeClientes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    sexo = table.Column<int>(type: "int", nullable: false),
                    cep = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    endereco = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    numero = table.Column<int>(type: "int", nullable: false),
                    complemento = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    bairro = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    cidade = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    estado = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
