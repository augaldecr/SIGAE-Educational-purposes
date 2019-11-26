using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGAE.Web.Migrations
{
    public partial class InicializadorDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gasto_TipoGasto_TipoGastoId",
                table: "Gasto");

            migrationBuilder.AlterColumn<int>(
                name: "TipoGastoId",
                table: "Gasto",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Gasto_TipoGasto_TipoGastoId",
                table: "Gasto",
                column: "TipoGastoId",
                principalTable: "TipoGasto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gasto_TipoGasto_TipoGastoId",
                table: "Gasto");

            migrationBuilder.AlterColumn<int>(
                name: "TipoGastoId",
                table: "Gasto",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gasto_TipoGasto_TipoGastoId",
                table: "Gasto",
                column: "TipoGastoId",
                principalTable: "TipoGasto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
