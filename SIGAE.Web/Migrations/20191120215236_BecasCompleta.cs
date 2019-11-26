using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGAE.Web.Migrations
{
    public partial class BecasCompleta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dialecto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dialecto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parentesco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parentesco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RutaTransporte",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutaTransporte", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subsidio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subsidio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoBeca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoBeca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoMedioTransporte",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMedioTransporte", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Familiar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentescoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familiar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Familiar_Parentesco_ParentescoId",
                        column: x => x.ParentescoId,
                        principalTable: "Parentesco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Beca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    TipoBecaId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Monto = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beca_TipoBeca_TipoBecaId",
                        column: x => x.TipoBecaId,
                        principalTable: "TipoBeca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Solicitud",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(nullable: false),
                    SolicitanteId = table.Column<int>(nullable: false),
                    EncargadoId = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    PobladoId = table.Column<int>(nullable: false),
                    DistanciaAlCentroEducativo = table.Column<string>(nullable: false),
                    BecaSolicitadaId = table.Column<int>(nullable: false),
                    NumSubsidioTransporteId = table.Column<int>(nullable: false),
                    RutaId = table.Column<int>(nullable: false),
                    TrnspPblcHorarioCentEduc = table.Column<bool>(nullable: false),
                    CentEducCercania = table.Column<bool>(nullable: false),
                    CentroEducativoCercanoId = table.Column<int>(nullable: true),
                    DistanciaAMasCercano = table.Column<string>(nullable: true),
                    RazonDeNoMatricula = table.Column<string>(nullable: true),
                    DistanciaAMatriculado = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true),
                    Aprobada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Solicitud_Beca_BecaSolicitadaId",
                        column: x => x.BecaSolicitadaId,
                        principalTable: "Beca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitud_Instituciones_CentroEducativoCercanoId",
                        column: x => x.CentroEducativoCercanoId,
                        principalTable: "Instituciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Solicitud_Personas_EncargadoId",
                        column: x => x.EncargadoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitud_Subsidio_NumSubsidioTransporteId",
                        column: x => x.NumSubsidioTransporteId,
                        principalTable: "Subsidio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitud_Localidades_PobladoId",
                        column: x => x.PobladoId,
                        principalTable: "Localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitud_RutaTransporte_RutaId",
                        column: x => x.RutaId,
                        principalTable: "RutaTransporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitud_Matriculas_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Matriculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DialectoHablado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DialectoId = table.Column<int>(nullable: false),
                    EstudianteId = table.Column<int>(nullable: true),
                    SolicitudId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DialectoHablado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DialectoHablado_Dialecto_DialectoId",
                        column: x => x.DialectoId,
                        principalTable: "Dialecto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DialectoHablado_Personas_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DialectoHablado_Solicitud_SolicitudId",
                        column: x => x.SolicitudId,
                        principalTable: "Solicitud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedioTransporteSolicitado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoMedioTransporteId = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    SolicitudId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedioTransporteSolicitado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedioTransporteSolicitado_Solicitud_SolicitudId",
                        column: x => x.SolicitudId,
                        principalTable: "Solicitud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedioTransporteSolicitado_TipoMedioTransporte_TipoMedioTransporteId",
                        column: x => x.TipoMedioTransporteId,
                        principalTable: "TipoMedioTransporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beca_TipoBecaId",
                table: "Beca",
                column: "TipoBecaId");

            migrationBuilder.CreateIndex(
                name: "IX_DialectoHablado_DialectoId",
                table: "DialectoHablado",
                column: "DialectoId");

            migrationBuilder.CreateIndex(
                name: "IX_DialectoHablado_EstudianteId",
                table: "DialectoHablado",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_DialectoHablado_SolicitudId",
                table: "DialectoHablado",
                column: "SolicitudId");

            migrationBuilder.CreateIndex(
                name: "IX_Familiar_ParentescoId",
                table: "Familiar",
                column: "ParentescoId");

            migrationBuilder.CreateIndex(
                name: "IX_MedioTransporteSolicitado_SolicitudId",
                table: "MedioTransporteSolicitado",
                column: "SolicitudId");

            migrationBuilder.CreateIndex(
                name: "IX_MedioTransporteSolicitado_TipoMedioTransporteId",
                table: "MedioTransporteSolicitado",
                column: "TipoMedioTransporteId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_BecaSolicitadaId",
                table: "Solicitud",
                column: "BecaSolicitadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_CentroEducativoCercanoId",
                table: "Solicitud",
                column: "CentroEducativoCercanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_EncargadoId",
                table: "Solicitud",
                column: "EncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_NumSubsidioTransporteId",
                table: "Solicitud",
                column: "NumSubsidioTransporteId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_PobladoId",
                table: "Solicitud",
                column: "PobladoId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_RutaId",
                table: "Solicitud",
                column: "RutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_SolicitanteId",
                table: "Solicitud",
                column: "SolicitanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DialectoHablado");

            migrationBuilder.DropTable(
                name: "Familiar");

            migrationBuilder.DropTable(
                name: "MedioTransporteSolicitado");

            migrationBuilder.DropTable(
                name: "Dialecto");

            migrationBuilder.DropTable(
                name: "Parentesco");

            migrationBuilder.DropTable(
                name: "Solicitud");

            migrationBuilder.DropTable(
                name: "TipoMedioTransporte");

            migrationBuilder.DropTable(
                name: "Beca");

            migrationBuilder.DropTable(
                name: "Subsidio");

            migrationBuilder.DropTable(
                name: "RutaTransporte");

            migrationBuilder.DropTable(
                name: "TipoBeca");
        }
    }
}
