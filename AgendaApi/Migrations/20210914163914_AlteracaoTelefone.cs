using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaApi.Migrations
{
    public partial class AlteracaoTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Contato",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Contato",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Contato",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 1, "email1@email.com", "Primeiro Sobrenome", 0 });

            migrationBuilder.InsertData(
                table: "Contato",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 2, "email2@email.com", "Segundo Sobrenome", 0 });

            migrationBuilder.InsertData(
                table: "Contato",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 3, "email3@email.com", "Terceiro Sobrenome", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contato",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contato",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contato",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Contato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldNullable: true);
        }
    }
}
