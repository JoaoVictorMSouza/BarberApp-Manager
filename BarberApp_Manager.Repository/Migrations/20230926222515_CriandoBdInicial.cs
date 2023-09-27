using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarberApp_Manager.Repository.Migrations
{
    /// <inheritdoc />
    public partial class CriandoBdInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CABELEIREIRO",
                columns: table => new
                {
                    PK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DS_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DS_PERMISAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DS_LOGIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DS_SENHA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TG_ACEITANDO_SERVICO = table.Column<bool>(type: "bit", nullable: false),
                    DH_LIMITE_SERVICO_INICIO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DH_LIMITE_SERVICO_FIM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DS_CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DS_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TG_INATIVO = table.Column<bool>(type: "bit", nullable: false),
                    DH_INCLUSAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DH_ALTERACAO = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CABELEIREIRO", x => x.PK_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CABELEIREIRO");
        }
    }
}
