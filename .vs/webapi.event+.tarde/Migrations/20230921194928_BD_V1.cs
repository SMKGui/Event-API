using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.event_.tarde.Migrations
{
    /// <inheritdoc />
    public partial class BD_V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InstituicaoDomain",
                columns: table => new
                {
                    IdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CNPJ = table.Column<string>(type: "CHAR(14)", maxLength: 14, nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NomeFantasia = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituicaoDomain", x => x.IdInstituicao);
                });

            migrationBuilder.CreateTable(
                name: "TipoEventoDomain",
                columns: table => new
                {
                    IdTipoEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEventoDomain", x => x.IdTipoEvento);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuarioDomain",
                columns: table => new
                {
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloUsuario = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuarioDomain", x => x.IdTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "EventoDomain",
                columns: table => new
                {
                    IdEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataEvento = table.Column<DateTime>(type: "DATE", nullable: false),
                    NomeEvento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    IdTipoEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventoDomain", x => x.IdEvento);
                    table.ForeignKey(
                        name: "FK_EventoDomain_InstituicaoDomain_IdInstituicao",
                        column: x => x.IdInstituicao,
                        principalTable: "InstituicaoDomain",
                        principalColumn: "IdInstituicao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventoDomain_TipoEventoDomain_IdTipoEvento",
                        column: x => x.IdTipoEvento,
                        principalTable: "TipoEventoDomain",
                        principalColumn: "IdTipoEvento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioDomain",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Senha = table.Column<string>(type: "CHAR(60)", maxLength: 60, nullable: false),
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioDomain", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_UsuarioDomain_TipoUsuarioDomain_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TipoUsuarioDomain",
                        principalColumn: "IdTipoUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComentarioEventoDomain",
                columns: table => new
                {
                    IdComentarioEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Exibe = table.Column<bool>(type: "BIT", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentarioEventoDomain", x => x.IdComentarioEvento);
                    table.ForeignKey(
                        name: "FK_ComentarioEventoDomain_EventoDomain_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "EventoDomain",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComentarioEventoDomain_UsuarioDomain_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "UsuarioDomain",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PresencaEventoDomain",
                columns: table => new
                {
                    IdPresencaEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Situacao = table.Column<bool>(type: "BIT", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresencaEventoDomain", x => x.IdPresencaEvento);
                    table.ForeignKey(
                        name: "FK_PresencaEventoDomain_EventoDomain_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "EventoDomain",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PresencaEventoDomain_UsuarioDomain_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "UsuarioDomain",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioEventoDomain_IdEvento",
                table: "ComentarioEventoDomain",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioEventoDomain_IdUsuario",
                table: "ComentarioEventoDomain",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_EventoDomain_IdInstituicao",
                table: "EventoDomain",
                column: "IdInstituicao");

            migrationBuilder.CreateIndex(
                name: "IX_EventoDomain_IdTipoEvento",
                table: "EventoDomain",
                column: "IdTipoEvento");

            migrationBuilder.CreateIndex(
                name: "IX_InstituicaoDomain_CNPJ",
                table: "InstituicaoDomain",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PresencaEventoDomain_IdEvento",
                table: "PresencaEventoDomain",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_PresencaEventoDomain_IdUsuario",
                table: "PresencaEventoDomain",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioDomain_Email",
                table: "UsuarioDomain",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioDomain_IdTipoUsuario",
                table: "UsuarioDomain",
                column: "IdTipoUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComentarioEventoDomain");

            migrationBuilder.DropTable(
                name: "PresencaEventoDomain");

            migrationBuilder.DropTable(
                name: "EventoDomain");

            migrationBuilder.DropTable(
                name: "UsuarioDomain");

            migrationBuilder.DropTable(
                name: "InstituicaoDomain");

            migrationBuilder.DropTable(
                name: "TipoEventoDomain");

            migrationBuilder.DropTable(
                name: "TipoUsuarioDomain");
        }
    }
}
