using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaApi.Migrations
{
    public partial class AlteracaoPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Contato",
                type: "int",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11);

            migrationBuilder.InsertData(
                table: "Contato",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 1, "email1@email.com", "Primeiro Sobrenome", null });

            migrationBuilder.InsertData(
                table: "Contato",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 2, "email2@email.com", "Segundo Sobrenome", null });

            migrationBuilder.InsertData(
                table: "Contato",
                columns: new[] { "Id", "Email", "Nome", "Telefone" },
                values: new object[] { 3, "email3@email.com", "Terceiro Sobrenome", null });
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

            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Contato",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11,
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
    }
}
