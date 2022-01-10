using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForRefugees.Migrations
{
    public partial class removerAvaliacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacao");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Refugiado",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Refugiado",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Avaliacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratanteId = table.Column<int>(type: "int", nullable: false),
                    Negativo = table.Column<int>(type: "int", nullable: false),
                    Positivo = table.Column<int>(type: "int", nullable: false),
                    RefugiadoId = table.Column<int>(type: "int", nullable: false),
                    dataAvaliacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Contratante_ContratanteId",
                        column: x => x.ContratanteId,
                        principalTable: "Contratante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Refugiado_RefugiadoId",
                        column: x => x.RefugiadoId,
                        principalTable: "Refugiado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_ContratanteId",
                table: "Avaliacao",
                column: "ContratanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_RefugiadoId",
                table: "Avaliacao",
                column: "RefugiadoId");
        }
    }
}
