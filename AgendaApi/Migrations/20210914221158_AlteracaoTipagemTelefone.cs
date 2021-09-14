using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaApi.Migrations
{
    public partial class AlteracaoTipagemTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contato",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Contato",
                keyColumn: "Id",
                keyValue: 1,
                column: "Telefone",
                value: "33911112222");

            migrationBuilder.UpdateData(
                table: "Contato",
                keyColumn: "Id",
                keyValue: 2,
                column: "Telefone",
                value: "33922223333");

            migrationBuilder.UpdateData(
                table: "Contato",
                keyColumn: "Id",
                keyValue: 3,
                column: "Telefone",
                value: "33933334444");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Contato",
                type: "int",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Contato",
                keyColumn: "Id",
                keyValue: 1,
                column: "Telefone",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contato",
                keyColumn: "Id",
                keyValue: 2,
                column: "Telefone",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contato",
                keyColumn: "Id",
                keyValue: 3,
                column: "Telefone",
                value: null);
        }
    }
}
