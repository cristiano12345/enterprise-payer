using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanPayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClienteBeneficiario",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    IdCliente = table.Column<long>(nullable: false),
                    IdBeneficiario = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteBeneficiario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContaBancaria",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    IdClienteBeneficiario = table.Column<long>(nullable: false),
                    IdTipoConta = table.Column<long>(nullable: false),
                    NomeBanco = table.Column<string>(maxLength: 50, nullable: false),
                    NumBanco = table.Column<string>(maxLength: 50, nullable: false),
                    NumAgencia = table.Column<string>(maxLength: 50, nullable: false),
                    NumConta = table.Column<string>(maxLength: 50, nullable: false),
                    Recebe = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaBancaria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Ddd = table.Column<int>(maxLength: 2, nullable: false),
                    Telefone = table.Column<string>(maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalheVenda",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    IdVenda = table.Column<long>(nullable: false),
                    IdRecebimento = table.Column<long>(nullable: false),
                    IdFormaPagamento = table.Column<long>(nullable: false),
                    Parcela = table.Column<int>(nullable: false),
                    ValorParcela = table.Column<decimal>(nullable: false),
                    CodBarras = table.Column<string>(maxLength: 50, nullable: false),
                    Banco = table.Column<string>(maxLength: 50, nullable: false),
                    Agencia = table.Column<string>(maxLength: 50, nullable: false),
                    Conta = table.Column<string>(maxLength: 50, nullable: false),
                    NumCheque = table.Column<string>(maxLength: 50, nullable: true),
                    DtVencimento = table.Column<DateTime>(nullable: true),
                    LiberaComissao = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalheVenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalheVendaClienteBenefic",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    IdDetalheVenda = table.Column<long>(nullable: false),
                    IdClienteBeneficiario = table.Column<long>(nullable: false),
                    IdStatusPagamento = table.Column<long>(nullable: false),
                    VlComissao = table.Column<decimal>(nullable: false),
                    DtPagamento = table.Column<DateTime>(nullable: false),
                    Comprovante = table.Column<string>(maxLength: 100, nullable: false),
                    LiberaComissao = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalheVendaClienteBenefic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(maxLength: 50, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 200, nullable: false),
                    Numero = table.Column<long>(nullable: false),
                    Complemento = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusPagamento",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoConta",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoConta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Torre",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    IdEmpreendimento = table.Column<long>(nullable: false),
                    NomeTorre = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    IdTorre = table.Column<long>(nullable: false),
                    NomeUnidade = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    Perfil = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    IdUnidade = table.Column<long>(nullable: false),
                    IdComprador = table.Column<long>(nullable: false),
                    IdStatusVenda = table.Column<long>(nullable: false),
                    NumContrato = table.Column<long>(maxLength: 500, nullable: false),
                    ValorComissaoTotal = table.Column<decimal>(nullable: false),
                    QtdParcelas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comprador",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    UsuarioId = table.Column<long>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(maxLength: 11, nullable: false),
                    ContatoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comprador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comprador_Contato_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiario",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    UsuarioId = table.Column<long>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(maxLength: 11, nullable: false),
                    EnderecoId = table.Column<long>(nullable: false),
                    ContatoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beneficiario_Contato_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beneficiario_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    UsuarioId = table.Column<long>(nullable: false),
                    RazaoSocial = table.Column<string>(maxLength: 100, nullable: false),
                    NomeFantasia = table.Column<string>(maxLength: 100, nullable: false),
                    Cnpj = table.Column<string>(maxLength: 14, nullable: false),
                    EnderecoId = table.Column<long>(nullable: false),
                    ContatoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Contato_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cliente_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empreendimento",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtInsert = table.Column<DateTime>(nullable: true),
                    DtUpdate = table.Column<DateTime>(nullable: true),
                    DtDelete = table.Column<DateTime>(nullable: true),
                    IdUserCreate = table.Column<long>(nullable: true),
                    IdUserUpdate = table.Column<long>(nullable: true),
                    IdUserDelete = table.Column<long>(nullable: true),
                    IdCliente = table.Column<long>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    RazaoSocial = table.Column<string>(maxLength: 100, nullable: false),
                    NomeFantasia = table.Column<string>(maxLength: 100, nullable: false),
                    Cnpj = table.Column<string>(maxLength: 14, nullable: false),
                    EnderecoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empreendimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empreendimento_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiario_ContatoId",
                table: "Beneficiario",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiario_EnderecoId",
                table: "Beneficiario",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ContatoId",
                table: "Cliente",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Cliente",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comprador_ContatoId",
                table: "Comprador",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empreendimento_EnderecoId",
                table: "Empreendimento",
                column: "EnderecoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiario");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "ClienteBeneficiario");

            migrationBuilder.DropTable(
                name: "Comprador");

            migrationBuilder.DropTable(
                name: "ContaBancaria");

            migrationBuilder.DropTable(
                name: "DetalheVenda");

            migrationBuilder.DropTable(
                name: "DetalheVendaClienteBenefic");

            migrationBuilder.DropTable(
                name: "Empreendimento");

            migrationBuilder.DropTable(
                name: "FormaPagamento");

            migrationBuilder.DropTable(
                name: "StatusPagamento");

            migrationBuilder.DropTable(
                name: "TipoConta");

            migrationBuilder.DropTable(
                name: "Torre");

            migrationBuilder.DropTable(
                name: "Unidade");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
