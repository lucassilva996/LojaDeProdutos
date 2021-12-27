using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaProdutos.Infra.Data.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    IdProduto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(nullable: false),
                    PrecoProduto = table.Column<decimal>(nullable: false),
                    QuantidadeProduto = table.Column<int>(nullable: false),
                    DataCadastroProduto = table.Column<DateTime>(nullable: false),
                    DataAtualizacaoProduto = table.Column<DateTime>(nullable: false),
                    ProdutoAtivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.IdProduto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
