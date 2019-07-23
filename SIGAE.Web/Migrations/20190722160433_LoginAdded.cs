using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGAE.Web.Migrations
{
    public partial class LoginAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignatura_TipoAsignatura_TipoAsignaturaId",
                table: "Asignatura");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignatura_TipoEvaluacion_TipoEvaluacionId",
                table: "Asignatura");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignatura_Especialidad_EspecialidadId",
                table: "Asignatura");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Funcionario_FuncionarioId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Canton_Provincia_ProvinciaId",
                table: "Canton");

            migrationBuilder.DropForeignKey(
                name: "FK_Circuito_Regional_RegionalId",
                table: "Circuito");

            migrationBuilder.DropForeignKey(
                name: "FK_Distrito_Canton_CantonId",
                table: "Distrito");

            migrationBuilder.DropForeignKey(
                name: "FK_Especialidad_Modalidad_ModalidadId",
                table: "Especialidad");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Personas_PersonaId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Puesto_PuestoId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Gasto_TipoGasto_TipoGastoId",
                table: "Gasto");

            migrationBuilder.DropForeignKey(
                name: "FK_Gira_Localidad_LocalidadVisitadaId",
                table: "Gira");

            migrationBuilder.DropForeignKey(
                name: "FK_Gira_TipoTransporte_TipoTransporteId",
                table: "Gira");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_CursoLectivo_CursoLectivoId",
                table: "Grupo");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_Institucion_InstitucionId",
                table: "Grupo");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_Nivel_NivelId",
                table: "Grupo");

            migrationBuilder.DropForeignKey(
                name: "FK_Institucion_Circuito_CircuitoId",
                table: "Institucion");

            migrationBuilder.DropForeignKey(
                name: "FK_Institucion_Localidad_LocalidadId",
                table: "Institucion");

            migrationBuilder.DropForeignKey(
                name: "FK_Institucion_ModalidadInstitucion_ModalidadId",
                table: "Institucion");

            migrationBuilder.DropForeignKey(
                name: "FK_Institucion_TipoInstitucion_TipoInstitucionId",
                table: "Institucion");

            migrationBuilder.DropForeignKey(
                name: "FK_Liquidacion_AspNetUsers_UsuarioId",
                table: "Liquidacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Localidad_Distrito_DistritoId",
                table: "Localidad");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Personas_PersonaId",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramiento_Funcionario_FuncionarioId",
                table: "Nombramiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramiento_Institucion_InstitucionId",
                table: "Nombramiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramiento_Puesto_PuestoId",
                table: "Nombramiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramiento_TipoNombramiento_TipoNombramientoId",
                table: "Nombramiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincia_Pais_PaisId",
                table: "Provincia");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacion_TipoAsignacion_TipoAsignacionId",
                table: "Publicacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacion_Funcionario_PublicadorId",
                table: "Publicacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacion_Tema_TemaId",
                table: "Publicacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Puesto_TipoPuesto_TipoPuestoId",
                table: "Puesto");

            migrationBuilder.DropForeignKey(
                name: "FK_Tema_Asignatura_AsignaturaId",
                table: "Tema");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "AspNetUsers",
                newName: "PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_FuncionarioId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignatura_TipoAsignatura_TipoAsignaturaId",
                table: "Asignatura",
                column: "TipoAsignaturaId",
                principalTable: "TipoAsignatura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignatura_TipoEvaluacion_TipoEvaluacionId",
                table: "Asignatura",
                column: "TipoEvaluacionId",
                principalTable: "TipoEvaluacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignatura_Especialidad_EspecialidadId",
                table: "Asignatura",
                column: "EspecialidadId",
                principalTable: "Especialidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Personas_PersonaId",
                table: "AspNetUsers",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Canton_Provincia_ProvinciaId",
                table: "Canton",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Circuito_Regional_RegionalId",
                table: "Circuito",
                column: "RegionalId",
                principalTable: "Regional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Distrito_Canton_CantonId",
                table: "Distrito",
                column: "CantonId",
                principalTable: "Canton",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidad_Modalidad_ModalidadId",
                table: "Especialidad",
                column: "ModalidadId",
                principalTable: "Modalidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Personas_PersonaId",
                table: "Funcionario",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Puesto_PuestoId",
                table: "Funcionario",
                column: "PuestoId",
                principalTable: "Puesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gasto_TipoGasto_TipoGastoId",
                table: "Gasto",
                column: "TipoGastoId",
                principalTable: "TipoGasto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gira_Localidad_LocalidadVisitadaId",
                table: "Gira",
                column: "LocalidadVisitadaId",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gira_TipoTransporte_TipoTransporteId",
                table: "Gira",
                column: "TipoTransporteId",
                principalTable: "TipoTransporte",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupo_CursoLectivo_CursoLectivoId",
                table: "Grupo",
                column: "CursoLectivoId",
                principalTable: "CursoLectivo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupo_Institucion_InstitucionId",
                table: "Grupo",
                column: "InstitucionId",
                principalTable: "Institucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupo_Nivel_NivelId",
                table: "Grupo",
                column: "NivelId",
                principalTable: "Nivel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institucion_Circuito_CircuitoId",
                table: "Institucion",
                column: "CircuitoId",
                principalTable: "Circuito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institucion_Localidad_LocalidadId",
                table: "Institucion",
                column: "LocalidadId",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institucion_ModalidadInstitucion_ModalidadId",
                table: "Institucion",
                column: "ModalidadId",
                principalTable: "ModalidadInstitucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institucion_TipoInstitucion_TipoInstitucionId",
                table: "Institucion",
                column: "TipoInstitucionId",
                principalTable: "TipoInstitucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Liquidacion_AspNetUsers_UsuarioId",
                table: "Liquidacion",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Localidad_Distrito_DistritoId",
                table: "Localidad",
                column: "DistritoId",
                principalTable: "Distrito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Personas_PersonaId",
                table: "Matricula",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramiento_Funcionario_FuncionarioId",
                table: "Nombramiento",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramiento_Institucion_InstitucionId",
                table: "Nombramiento",
                column: "InstitucionId",
                principalTable: "Institucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramiento_Puesto_PuestoId",
                table: "Nombramiento",
                column: "PuestoId",
                principalTable: "Puesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramiento_TipoNombramiento_TipoNombramientoId",
                table: "Nombramiento",
                column: "TipoNombramientoId",
                principalTable: "TipoNombramiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provincia_Pais_PaisId",
                table: "Provincia",
                column: "PaisId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacion_TipoAsignacion_TipoAsignacionId",
                table: "Publicacion",
                column: "TipoAsignacionId",
                principalTable: "TipoAsignacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacion_Funcionario_PublicadorId",
                table: "Publicacion",
                column: "PublicadorId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacion_Tema_TemaId",
                table: "Publicacion",
                column: "TemaId",
                principalTable: "Tema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Puesto_TipoPuesto_TipoPuestoId",
                table: "Puesto",
                column: "TipoPuestoId",
                principalTable: "TipoPuesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tema_Asignatura_AsignaturaId",
                table: "Tema",
                column: "AsignaturaId",
                principalTable: "Asignatura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignatura_TipoAsignatura_TipoAsignaturaId",
                table: "Asignatura");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignatura_TipoEvaluacion_TipoEvaluacionId",
                table: "Asignatura");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignatura_Especialidad_EspecialidadId",
                table: "Asignatura");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Personas_PersonaId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Canton_Provincia_ProvinciaId",
                table: "Canton");

            migrationBuilder.DropForeignKey(
                name: "FK_Circuito_Regional_RegionalId",
                table: "Circuito");

            migrationBuilder.DropForeignKey(
                name: "FK_Distrito_Canton_CantonId",
                table: "Distrito");

            migrationBuilder.DropForeignKey(
                name: "FK_Especialidad_Modalidad_ModalidadId",
                table: "Especialidad");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Personas_PersonaId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Puesto_PuestoId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Gasto_TipoGasto_TipoGastoId",
                table: "Gasto");

            migrationBuilder.DropForeignKey(
                name: "FK_Gira_Localidad_LocalidadVisitadaId",
                table: "Gira");

            migrationBuilder.DropForeignKey(
                name: "FK_Gira_TipoTransporte_TipoTransporteId",
                table: "Gira");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_CursoLectivo_CursoLectivoId",
                table: "Grupo");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_Institucion_InstitucionId",
                table: "Grupo");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_Nivel_NivelId",
                table: "Grupo");

            migrationBuilder.DropForeignKey(
                name: "FK_Institucion_Circuito_CircuitoId",
                table: "Institucion");

            migrationBuilder.DropForeignKey(
                name: "FK_Institucion_Localidad_LocalidadId",
                table: "Institucion");

            migrationBuilder.DropForeignKey(
                name: "FK_Institucion_ModalidadInstitucion_ModalidadId",
                table: "Institucion");

            migrationBuilder.DropForeignKey(
                name: "FK_Institucion_TipoInstitucion_TipoInstitucionId",
                table: "Institucion");

            migrationBuilder.DropForeignKey(
                name: "FK_Liquidacion_AspNetUsers_UsuarioId",
                table: "Liquidacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Localidad_Distrito_DistritoId",
                table: "Localidad");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Personas_PersonaId",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramiento_Funcionario_FuncionarioId",
                table: "Nombramiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramiento_Institucion_InstitucionId",
                table: "Nombramiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramiento_Puesto_PuestoId",
                table: "Nombramiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramiento_TipoNombramiento_TipoNombramientoId",
                table: "Nombramiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincia_Pais_PaisId",
                table: "Provincia");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacion_TipoAsignacion_TipoAsignacionId",
                table: "Publicacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacion_Funcionario_PublicadorId",
                table: "Publicacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicacion_Tema_TemaId",
                table: "Publicacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Puesto_TipoPuesto_TipoPuestoId",
                table: "Puesto");

            migrationBuilder.DropForeignKey(
                name: "FK_Tema_Asignatura_AsignaturaId",
                table: "Tema");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "AspNetUsers",
                newName: "FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_PersonaId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignatura_TipoAsignatura_TipoAsignaturaId",
                table: "Asignatura",
                column: "TipoAsignaturaId",
                principalTable: "TipoAsignatura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignatura_TipoEvaluacion_TipoEvaluacionId",
                table: "Asignatura",
                column: "TipoEvaluacionId",
                principalTable: "TipoEvaluacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignatura_Especialidad_EspecialidadId",
                table: "Asignatura",
                column: "EspecialidadId",
                principalTable: "Especialidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Funcionario_FuncionarioId",
                table: "AspNetUsers",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Canton_Provincia_ProvinciaId",
                table: "Canton",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Circuito_Regional_RegionalId",
                table: "Circuito",
                column: "RegionalId",
                principalTable: "Regional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Distrito_Canton_CantonId",
                table: "Distrito",
                column: "CantonId",
                principalTable: "Canton",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidad_Modalidad_ModalidadId",
                table: "Especialidad",
                column: "ModalidadId",
                principalTable: "Modalidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Personas_PersonaId",
                table: "Funcionario",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Puesto_PuestoId",
                table: "Funcionario",
                column: "PuestoId",
                principalTable: "Puesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gasto_TipoGasto_TipoGastoId",
                table: "Gasto",
                column: "TipoGastoId",
                principalTable: "TipoGasto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gira_Localidad_LocalidadVisitadaId",
                table: "Gira",
                column: "LocalidadVisitadaId",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gira_TipoTransporte_TipoTransporteId",
                table: "Gira",
                column: "TipoTransporteId",
                principalTable: "TipoTransporte",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupo_CursoLectivo_CursoLectivoId",
                table: "Grupo",
                column: "CursoLectivoId",
                principalTable: "CursoLectivo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupo_Institucion_InstitucionId",
                table: "Grupo",
                column: "InstitucionId",
                principalTable: "Institucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupo_Nivel_NivelId",
                table: "Grupo",
                column: "NivelId",
                principalTable: "Nivel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Institucion_Circuito_CircuitoId",
                table: "Institucion",
                column: "CircuitoId",
                principalTable: "Circuito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Institucion_Localidad_LocalidadId",
                table: "Institucion",
                column: "LocalidadId",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Institucion_ModalidadInstitucion_ModalidadId",
                table: "Institucion",
                column: "ModalidadId",
                principalTable: "ModalidadInstitucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Institucion_TipoInstitucion_TipoInstitucionId",
                table: "Institucion",
                column: "TipoInstitucionId",
                principalTable: "TipoInstitucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Liquidacion_AspNetUsers_UsuarioId",
                table: "Liquidacion",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Localidad_Distrito_DistritoId",
                table: "Localidad",
                column: "DistritoId",
                principalTable: "Distrito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Personas_PersonaId",
                table: "Matricula",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramiento_Funcionario_FuncionarioId",
                table: "Nombramiento",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramiento_Institucion_InstitucionId",
                table: "Nombramiento",
                column: "InstitucionId",
                principalTable: "Institucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramiento_Puesto_PuestoId",
                table: "Nombramiento",
                column: "PuestoId",
                principalTable: "Puesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramiento_TipoNombramiento_TipoNombramientoId",
                table: "Nombramiento",
                column: "TipoNombramientoId",
                principalTable: "TipoNombramiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provincia_Pais_PaisId",
                table: "Provincia",
                column: "PaisId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacion_TipoAsignacion_TipoAsignacionId",
                table: "Publicacion",
                column: "TipoAsignacionId",
                principalTable: "TipoAsignacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacion_Funcionario_PublicadorId",
                table: "Publicacion",
                column: "PublicadorId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicacion_Tema_TemaId",
                table: "Publicacion",
                column: "TemaId",
                principalTable: "Tema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Puesto_TipoPuesto_TipoPuestoId",
                table: "Puesto",
                column: "TipoPuestoId",
                principalTable: "TipoPuesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tema_Asignatura_AsignaturaId",
                table: "Tema",
                column: "AsignaturaId",
                principalTable: "Asignatura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
