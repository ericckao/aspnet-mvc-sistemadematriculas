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
                    DATA_MATRICULA = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 24, 13, 47, 10, 345, DateTimeKind.Local).AddTicks(959))
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
                    { 1, "Análise e Desenvolvimento de Sistemas", new DateTime(2023, 7, 24, 13, 47, 10, 345, DateTimeKind.Local).AddTicks(1041), "Erik Fernandes", "Vergueiro" },
                    { 2, "Enfermagem", new DateTime(2023, 7, 24, 13, 47, 10, 345, DateTimeKind.Local).AddTicks(1043), "Marcos Felipe", "São Judas" },
                    { 3, "Odontólogia", new DateTime(2023, 7, 24, 13, 47, 10, 345, DateTimeKind.Local).AddTicks(1044), "Mariana Dias", "Vila Mariana" },
                    { 4, "Publicidade e Propaganda", new DateTime(2023, 7, 24, 13, 47, 10, 345, DateTimeKind.Local).AddTicks(1045), "Leticia Silva", "Paulista" },
                    { 5, "Culínaria", new DateTime(2023, 7, 24, 13, 47, 10, 345, DateTimeKind.Local).AddTicks(1046), "Beatriz Reis", "Praça da Arvoré" },
                    { 6, "Administração", new DateTime(2023, 7, 24, 13, 47, 10, 345, DateTimeKind.Local).AddTicks(1047), "Vinicius Muller", "Saúde" }
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
