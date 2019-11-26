using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGAE.Web.Migrations
{
    public partial class PersonasCorregido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Genero_GeneroId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genero",
                table: "Genero");

            migrationBuilder.RenameTable(
                name: "Genero",
                newName: "Generos");

            migrationBuilder.AddColumn<int>(
                name: "TipoIdentificacionId",
                table: "Identificaciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Generos",
                table: "Generos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TiposIdentificacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIdentificacion", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Identificaciones_TipoIdentificacionId",
                table: "Identificaciones",
                column: "TipoIdentificacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Identificaciones_TiposIdentificacion_TipoIdentificacionId",
                table: "Identificaciones",
                column: "TipoIdentificacionId",
                principalTable: "TiposIdentificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Generos_GeneroId",
                table: "Personas",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identificaciones_TiposIdentificacion_TipoIdentificacionId",
                table: "Identificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Generos_GeneroId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "TiposIdentificacion");

            migrationBuilder.DropIndex(
                name: "IX_Identificaciones_TipoIdentificacionId",
                table: "Identificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Generos",
                table: "Generos");

            migrationBuilder.DropColumn(
                name: "TipoIdentificacionId",
                table: "Identificaciones");

            migrationBuilder.RenameTable(
                name: "Generos",
                newName: "Genero");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genero",
                table: "Genero",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Genero_GeneroId",
                table: "Personas",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
