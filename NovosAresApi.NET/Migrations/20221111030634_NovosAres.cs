using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovosAresApi.NET.Migrations
{
    public partial class NovosAres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_cli = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Pacote",
                columns: table => new
                {
                    PacoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Partida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qtd_pessoas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pacote_ida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pacote_volta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Transfer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RuaHotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroHotel = table.Column<int>(type: "int", nullable: false),
                    CepHotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoHotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MunicipioHotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeHotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qtd_quartosHotel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacote", x => x.PacoteId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permissao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Pacote");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
