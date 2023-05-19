using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaApi.Migrations
{
    public partial class Relationtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_GradeCurricular_GradeCurricularId",
                table: "Disciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Escolas_Enderecos_EnderecoId",
                table: "Escolas");

            migrationBuilder.DropIndex(
                name: "IX_GradeCurricular_AlunoId",
                table: "GradeCurricular");

            migrationBuilder.DropIndex(
                name: "IX_Disciplinas_GradeCurricularId",
                table: "Disciplinas");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "GradeCurricularId",
                table: "Disciplinas");

            migrationBuilder.CreateIndex(
                name: "IX_GradeCurricular_AlunoId",
                table: "GradeCurricular",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeCurricular_DisciplinaId",
                table: "GradeCurricular",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos",
                column: "EscolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Escolas_Enderecos_EnderecoId",
                table: "Escolas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GradeCurricular_Disciplinas_DisciplinaId",
                table: "GradeCurricular",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
