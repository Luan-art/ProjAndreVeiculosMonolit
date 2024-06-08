using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjAPICarro.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Cartao_CartaoNumeroCartao",
                table: "Pagamento");

            migrationBuilder.AlterColumn<string>(
                name: "CartaoNumeroCartao",
                table: "Pagamento",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "CarroServico",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Cartao_CartaoNumeroCartao",
                table: "Pagamento",
                column: "CartaoNumeroCartao",
                principalTable: "Cartao",
                principalColumn: "NumeroCartao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Cartao_CartaoNumeroCartao",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "CarroServico");

            migrationBuilder.AlterColumn<string>(
                name: "CartaoNumeroCartao",
                table: "Pagamento",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Cartao_CartaoNumeroCartao",
                table: "Pagamento",
                column: "CartaoNumeroCartao",
                principalTable: "Cartao",
                principalColumn: "NumeroCartao",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
