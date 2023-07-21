using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMatricula.mvc.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_MATRICULAS",
                columns: table => new
                {
                    MatriculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME_ALUNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "CAMPO-VAZIO"),
                    NOME_CURSO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "CAMPO-VAZIO"),
                    UNIDADE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "CAMPO-VAZIO"),
                    DATA_MATRICULA = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 7, 21, 15, 42, 0, 693, DateTimeKind.Unspecified).AddTicks(5469), new TimeSpan(0, -3, 0, 0, 0)))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_MATRICULAS", x => x.MatriculaId);
                });

            migrationBuilder.InsertData(
                table: "TB_MATRICULAS",
                columns: new[] { "MatriculaId", "NOME_CURSO", "DATA_MATRICULA", "NOME_ALUNO", "UNIDADE" },
                values: new object[,]
                {
                    { 1, "Análise e Desenvolvimento de Sistemas", new DateTimeOffset(new DateTime(2023, 7, 21, 15, 42, 0, 693, DateTimeKind.Unspecified).AddTicks(5602), new TimeSpan(0, -3, 0, 0, 0)), "Erik Fernandes", "Vergueiro" },
                    { 2, "Enfermagem", new DateTimeOffset(new DateTime(2023, 7, 21, 15, 42, 0, 693, DateTimeKind.Unspecified).AddTicks(5607), new TimeSpan(0, -3, 0, 0, 0)), "Marcos Felipe", "São Judas" },
                    { 3, "Odontólogia", new DateTimeOffset(new DateTime(2023, 7, 21, 15, 42, 0, 693, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, -3, 0, 0, 0)), "Mariana Dias", "Vila Mariana" },
                    { 4, "Publicidade e Propaganda", new DateTimeOffset(new DateTime(2023, 7, 21, 15, 42, 0, 693, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, -3, 0, 0, 0)), "Leticia Silva", "Paulista" },
                    { 5, "Culínaria", new DateTimeOffset(new DateTime(2023, 7, 21, 15, 42, 0, 693, DateTimeKind.Unspecified).AddTicks(5615), new TimeSpan(0, -3, 0, 0, 0)), "Beatriz Reis", "Praça da Arvoré" },
                    { 6, "Administração", new DateTimeOffset(new DateTime(2023, 7, 21, 15, 42, 0, 693, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, -3, 0, 0, 0)), "Vinicius Muller", "Saúde" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MATRICULA_UNIQUE",
                table: "TB_MATRICULAS",
                column: "MatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_NOME_UNIQUE",
                table: "TB_MATRICULAS",
                column: "NOME_ALUNO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_MATRICULAS");
        }
    }
}
