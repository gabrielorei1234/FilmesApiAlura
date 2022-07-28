using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace FilmesApi.Migrations
{
    public partial class adiçãodegerente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GerenteFK",
                table: "Cinemas",
                newName: "GerenteId");

            migrationBuilder.AlterColumn<string>(
                name: "Genero",
                table: "Filmes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Diretor",
                table: "Filmes",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "ClassificacaoEtaria",
                table: "Filmes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Gerentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerentes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_GerenteId",
                table: "Cinemas",
                column: "GerenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Gerentes_GerenteId",
                table: "Cinemas",
                column: "GerenteId",
                principalTable: "Gerentes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Gerentes_GerenteId",
                table: "Cinemas");

            migrationBuilder.DropTable(
                name: "Gerentes");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_GerenteId",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "ClassificacaoEtaria",
                table: "Filmes");

            migrationBuilder.RenameColumn(
                name: "GerenteId",
                table: "Cinemas",
                newName: "GerenteFK");

            migrationBuilder.AlterColumn<string>(
                name: "Genero",
                table: "Filmes",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Diretor",
                table: "Filmes",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
