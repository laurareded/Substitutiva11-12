using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Atualizando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imcs_Alunos_AlunoId",
                table: "Imcs");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Imcs",
                newName: "AlunoId2");

            migrationBuilder.RenameColumn(
                name: "AlunoId",
                table: "Imcs",
                newName: "AlunoId1");

            migrationBuilder.RenameIndex(
                name: "IX_Imcs_AlunoId",
                table: "Imcs",
                newName: "IX_Imcs_AlunoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Imcs_AlunoId2",
                table: "Imcs",
                column: "AlunoId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Imcs_Alunos_AlunoId1",
                table: "Imcs",
                column: "AlunoId1",
                principalTable: "Alunos",
                principalColumn: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imcs_Alunos_AlunoId2",
                table: "Imcs",
                column: "AlunoId2",
                principalTable: "Alunos",
                principalColumn: "AlunoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imcs_Alunos_AlunoId1",
                table: "Imcs");

            migrationBuilder.DropForeignKey(
                name: "FK_Imcs_Alunos_AlunoId2",
                table: "Imcs");

            migrationBuilder.DropIndex(
                name: "IX_Imcs_AlunoId2",
                table: "Imcs");

            migrationBuilder.RenameColumn(
                name: "AlunoId2",
                table: "Imcs",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "AlunoId1",
                table: "Imcs",
                newName: "AlunoId");

            migrationBuilder.RenameIndex(
                name: "IX_Imcs_AlunoId1",
                table: "Imcs",
                newName: "IX_Imcs_AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imcs_Alunos_AlunoId",
                table: "Imcs",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId");
        }
    }
}
