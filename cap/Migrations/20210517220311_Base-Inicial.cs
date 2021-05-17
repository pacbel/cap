using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cap.Migrations
{
    public partial class BaseInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaPagar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdPessoaAprovadora = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCompra = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorLcto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdPessoaFinanceiro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Juros = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Multa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Correcao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorPgto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    DataHoraModificacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaPagar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PESSOA_FISICA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InscricaoEstadual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstcricaoMunicipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Papel = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    SemNumero = table.Column<bool>(type: "bit", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DataHoraModificacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PESSOA_FISICA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PESSOA_JURIDICA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Papel = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    SemNumero = table.Column<bool>(type: "bit", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DataHoraModificacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PESSOA_JURIDICA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FornecedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompradorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProdutoOuServico = table.Column<int>(type: "int", nullable: false),
                    Discriminacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorBruto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Retencoes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorLiquido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MeioPagamento = table.Column<int>(type: "int", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Documento = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    DataHoraModificacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_TB_PESSOA_FISICA_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "TB_PESSOA_FISICA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compra_TB_PESSOA_JURIDICA_CompradorId",
                        column: x => x.CompradorId,
                        principalTable: "TB_PESSOA_JURIDICA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_CompradorId",
                table: "Compra",
                column: "CompradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_FornecedorId",
                table: "Compra",
                column: "FornecedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "ContaPagar");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");

            migrationBuilder.DropTable(
                name: "TB_PESSOA_FISICA");

            migrationBuilder.DropTable(
                name: "TB_PESSOA_JURIDICA");
        }
    }
}
