using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGAE.Web.Migrations
{
    public partial class Becas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Archivo_Publicacion_AsignacionId",
                table: "Archivo");

            migrationBuilder.DropForeignKey(
                name: "FK_Archivo_Publicacion_MaterialId",
                table: "Archivo");

            migrationBuilder.DropForeignKey(
                name: "FK_Archivo_Notificacion_NotificacionId",
                table: "Archivo");

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
                name: "FK_Funcionario_Gira_GiraId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Personas_PersonaId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Gasto_Gira_GiraId",
                table: "Gasto");

            migrationBuilder.DropForeignKey(
                name: "FK_Gasto_TipoGasto_TipoGastoId",
                table: "Gasto");

            migrationBuilder.DropForeignKey(
                name: "FK_Gasto_AspNetUsers_UsuarioId",
                table: "Gasto");

            migrationBuilder.DropForeignKey(
                name: "FK_Gira_Liquidacion_LiquidacionId",
                table: "Gira");

            migrationBuilder.DropForeignKey(
                name: "FK_Gira_Localidad_LocalidadVisitadaId",
                table: "Gira");

            migrationBuilder.DropForeignKey(
                name: "FK_Gira_TipoTransporte_TipoTransporteId",
                table: "Gira");

            migrationBuilder.DropForeignKey(
                name: "FK_Gira_AspNetUsers_UsuarioId",
                table: "Gira");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_Publicacion_AsignacionId",
                table: "Grupo");

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
                name: "FK_Matricula_Grupo_GrupoId",
                table: "Matricula");

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
                name: "FK_Notificacion_Personas_PersonaId",
                table: "Notificacion");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoTransporte",
                table: "TipoTransporte");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPuesto",
                table: "TipoPuesto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoNombramiento",
                table: "TipoNombramiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoLocalizacion",
                table: "TipoLocalizacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoInstitucion",
                table: "TipoInstitucion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoGasto",
                table: "TipoGasto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoEvaluacion",
                table: "TipoEvaluacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoAsignatura",
                table: "TipoAsignatura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoAsignacion",
                table: "TipoAsignacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tema",
                table: "Tema");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regional",
                table: "Regional");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Puesto",
                table: "Puesto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publicacion",
                table: "Publicacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincia",
                table: "Provincia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pais",
                table: "Pais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notificacion",
                table: "Notificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nombramiento",
                table: "Nombramiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nivel",
                table: "Nivel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModalidadInstitucion",
                table: "ModalidadInstitucion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modalidad",
                table: "Modalidad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matricula",
                table: "Matricula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Localidad",
                table: "Localidad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Liquidacion",
                table: "Liquidacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Institucion",
                table: "Institucion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupo",
                table: "Grupo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gira",
                table: "Gira");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gasto",
                table: "Gasto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especialidad",
                table: "Especialidad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Distrito",
                table: "Distrito");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CursoLectivo",
                table: "CursoLectivo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Circuito",
                table: "Circuito");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Canton",
                table: "Canton");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Asignatura",
                table: "Asignatura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Archivo",
                table: "Archivo");

            migrationBuilder.RenameTable(
                name: "TipoTransporte",
                newName: "TiposTransporte");

            migrationBuilder.RenameTable(
                name: "TipoPuesto",
                newName: "TiposPuesto");

            migrationBuilder.RenameTable(
                name: "TipoNombramiento",
                newName: "TiposNombramiento");

            migrationBuilder.RenameTable(
                name: "TipoLocalizacion",
                newName: "TiposLocalizacion");

            migrationBuilder.RenameTable(
                name: "TipoInstitucion",
                newName: "TiposInstitucion");

            migrationBuilder.RenameTable(
                name: "TipoGasto",
                newName: "TiposGasto");

            migrationBuilder.RenameTable(
                name: "TipoEvaluacion",
                newName: "TiposEvaluacion");

            migrationBuilder.RenameTable(
                name: "TipoAsignatura",
                newName: "TiposAsignatura");

            migrationBuilder.RenameTable(
                name: "TipoAsignacion",
                newName: "TiposAsignacion");

            migrationBuilder.RenameTable(
                name: "Tema",
                newName: "Temas");

            migrationBuilder.RenameTable(
                name: "Regional",
                newName: "Regionales");

            migrationBuilder.RenameTable(
                name: "Puesto",
                newName: "Puestos");

            migrationBuilder.RenameTable(
                name: "Publicacion",
                newName: "Publicaciones");

            migrationBuilder.RenameTable(
                name: "Provincia",
                newName: "Provincias");

            migrationBuilder.RenameTable(
                name: "Pais",
                newName: "Paises");

            migrationBuilder.RenameTable(
                name: "Notificacion",
                newName: "Notificaciones");

            migrationBuilder.RenameTable(
                name: "Nombramiento",
                newName: "Nombramientos");

            migrationBuilder.RenameTable(
                name: "Nivel",
                newName: "Niveles");

            migrationBuilder.RenameTable(
                name: "ModalidadInstitucion",
                newName: "ModalidadesInstitucion");

            migrationBuilder.RenameTable(
                name: "Modalidad",
                newName: "Modalidades");

            migrationBuilder.RenameTable(
                name: "Matricula",
                newName: "Matriculas");

            migrationBuilder.RenameTable(
                name: "Localidad",
                newName: "Localidades");

            migrationBuilder.RenameTable(
                name: "Liquidacion",
                newName: "Liquidaciones");

            migrationBuilder.RenameTable(
                name: "Institucion",
                newName: "Instituciones");

            migrationBuilder.RenameTable(
                name: "Grupo",
                newName: "Grupos");

            migrationBuilder.RenameTable(
                name: "Gira",
                newName: "Giras");

            migrationBuilder.RenameTable(
                name: "Gasto",
                newName: "Gastos");

            migrationBuilder.RenameTable(
                name: "Funcionario",
                newName: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "Especialidad",
                newName: "Especialidades");

            migrationBuilder.RenameTable(
                name: "Distrito",
                newName: "Distritos");

            migrationBuilder.RenameTable(
                name: "CursoLectivo",
                newName: "CursosLectivos");

            migrationBuilder.RenameTable(
                name: "Circuito",
                newName: "Circuitos");

            migrationBuilder.RenameTable(
                name: "Canton",
                newName: "Cantones");

            migrationBuilder.RenameTable(
                name: "Asignatura",
                newName: "Asignaturas");

            migrationBuilder.RenameTable(
                name: "Archivo",
                newName: "Archivos");

            migrationBuilder.RenameColumn(
                name: "Cedula",
                table: "Personas",
                newName: "Discriminator");

            migrationBuilder.RenameIndex(
                name: "IX_Tema_AsignaturaId",
                table: "Temas",
                newName: "IX_Temas_AsignaturaId");

            migrationBuilder.RenameIndex(
                name: "IX_Puesto_TipoPuestoId",
                table: "Puestos",
                newName: "IX_Puestos_TipoPuestoId");

            migrationBuilder.RenameIndex(
                name: "IX_Publicacion_TemaId",
                table: "Publicaciones",
                newName: "IX_Publicaciones_TemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Publicacion_PublicadorId",
                table: "Publicaciones",
                newName: "IX_Publicaciones_PublicadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Publicacion_TipoAsignacionId",
                table: "Publicaciones",
                newName: "IX_Publicaciones_TipoAsignacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Provincia_PaisId",
                table: "Provincias",
                newName: "IX_Provincias_PaisId");

            migrationBuilder.RenameIndex(
                name: "IX_Notificacion_PersonaId",
                table: "Notificaciones",
                newName: "IX_Notificaciones_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Nombramiento_TipoNombramientoId",
                table: "Nombramientos",
                newName: "IX_Nombramientos_TipoNombramientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Nombramiento_PuestoId",
                table: "Nombramientos",
                newName: "IX_Nombramientos_PuestoId");

            migrationBuilder.RenameIndex(
                name: "IX_Nombramiento_InstitucionId",
                table: "Nombramientos",
                newName: "IX_Nombramientos_InstitucionId");

            migrationBuilder.RenameIndex(
                name: "IX_Nombramiento_FuncionarioId",
                table: "Nombramientos",
                newName: "IX_Nombramientos_FuncionarioId");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "Matriculas",
                newName: "EstudianteId");

            migrationBuilder.RenameIndex(
                name: "IX_Matricula_PersonaId",
                table: "Matriculas",
                newName: "IX_Matriculas_EstudianteId");

            migrationBuilder.RenameIndex(
                name: "IX_Matricula_GrupoId",
                table: "Matriculas",
                newName: "IX_Matriculas_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_Localidad_DistritoId",
                table: "Localidades",
                newName: "IX_Localidades_DistritoId");

            migrationBuilder.RenameIndex(
                name: "IX_Liquidacion_UsuarioId",
                table: "Liquidaciones",
                newName: "IX_Liquidaciones_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Institucion_TipoInstitucionId",
                table: "Instituciones",
                newName: "IX_Instituciones_TipoInstitucionId");

            migrationBuilder.RenameIndex(
                name: "IX_Institucion_ModalidadId",
                table: "Instituciones",
                newName: "IX_Instituciones_ModalidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Institucion_LocalidadId",
                table: "Instituciones",
                newName: "IX_Instituciones_LocalidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Institucion_CircuitoId",
                table: "Instituciones",
                newName: "IX_Instituciones_CircuitoId");

            migrationBuilder.RenameIndex(
                name: "IX_Grupo_NivelId",
                table: "Grupos",
                newName: "IX_Grupos_NivelId");

            migrationBuilder.RenameIndex(
                name: "IX_Grupo_InstitucionId",
                table: "Grupos",
                newName: "IX_Grupos_InstitucionId");

            migrationBuilder.RenameIndex(
                name: "IX_Grupo_CursoLectivoId",
                table: "Grupos",
                newName: "IX_Grupos_CursoLectivoId");

            migrationBuilder.RenameIndex(
                name: "IX_Grupo_AsignacionId",
                table: "Grupos",
                newName: "IX_Grupos_AsignacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Gira_UsuarioId",
                table: "Giras",
                newName: "IX_Giras_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Gira_TipoTransporteId",
                table: "Giras",
                newName: "IX_Giras_TipoTransporteId");

            migrationBuilder.RenameIndex(
                name: "IX_Gira_LocalidadVisitadaId",
                table: "Giras",
                newName: "IX_Giras_LocalidadVisitadaId");

            migrationBuilder.RenameIndex(
                name: "IX_Gira_LiquidacionId",
                table: "Giras",
                newName: "IX_Giras_LiquidacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Gasto_UsuarioId",
                table: "Gastos",
                newName: "IX_Gastos_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Gasto_TipoGastoId",
                table: "Gastos",
                newName: "IX_Gastos_TipoGastoId");

            migrationBuilder.RenameIndex(
                name: "IX_Gasto_GiraId",
                table: "Gastos",
                newName: "IX_Gastos_GiraId");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionario_PersonaId",
                table: "Funcionarios",
                newName: "IX_Funcionarios_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionario_GiraId",
                table: "Funcionarios",
                newName: "IX_Funcionarios_GiraId");

            migrationBuilder.RenameIndex(
                name: "IX_Especialidad_ModalidadId",
                table: "Especialidades",
                newName: "IX_Especialidades_ModalidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Distrito_CantonId",
                table: "Distritos",
                newName: "IX_Distritos_CantonId");

            migrationBuilder.RenameIndex(
                name: "IX_Circuito_RegionalId",
                table: "Circuitos",
                newName: "IX_Circuitos_RegionalId");

            migrationBuilder.RenameIndex(
                name: "IX_Canton_ProvinciaId",
                table: "Cantones",
                newName: "IX_Cantones_ProvinciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Asignatura_EspecialidadId",
                table: "Asignaturas",
                newName: "IX_Asignaturas_EspecialidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Asignatura_TipoEvaluacionId",
                table: "Asignaturas",
                newName: "IX_Asignaturas_TipoEvaluacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Asignatura_TipoAsignaturaId",
                table: "Asignaturas",
                newName: "IX_Asignaturas_TipoAsignaturaId");

            migrationBuilder.RenameIndex(
                name: "IX_Archivo_NotificacionId",
                table: "Archivos",
                newName: "IX_Archivos_NotificacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Archivo_MaterialId",
                table: "Archivos",
                newName: "IX_Archivos_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Archivo_AsignacionId",
                table: "Archivos",
                newName: "IX_Archivos_AsignacionId");

            migrationBuilder.AddColumn<int>(
                name: "EtniaIndigenaId",
                table: "Personas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Personas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Personas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdentificacionId",
                table: "Personas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CursoLectivoId",
                table: "Matriculas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Archivos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposTransporte",
                table: "TiposTransporte",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposPuesto",
                table: "TiposPuesto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposNombramiento",
                table: "TiposNombramiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposLocalizacion",
                table: "TiposLocalizacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposInstitucion",
                table: "TiposInstitucion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposGasto",
                table: "TiposGasto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposEvaluacion",
                table: "TiposEvaluacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposAsignatura",
                table: "TiposAsignatura",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposAsignacion",
                table: "TiposAsignacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Temas",
                table: "Temas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regionales",
                table: "Regionales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Puestos",
                table: "Puestos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publicaciones",
                table: "Publicaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paises",
                table: "Paises",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notificaciones",
                table: "Notificaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nombramientos",
                table: "Nombramientos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Niveles",
                table: "Niveles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModalidadesInstitucion",
                table: "ModalidadesInstitucion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modalidades",
                table: "Modalidades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matriculas",
                table: "Matriculas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Localidades",
                table: "Localidades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Liquidaciones",
                table: "Liquidaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instituciones",
                table: "Instituciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Giras",
                table: "Giras",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gastos",
                table: "Gastos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distritos",
                table: "Distritos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CursosLectivos",
                table: "CursosLectivos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Circuitos",
                table: "Circuitos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cantones",
                table: "Cantones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Asignaturas",
                table: "Asignaturas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Archivos",
                table: "Archivos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Etnia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etnia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Identificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumIdentificacion = table.Column<string>(nullable: false),
                    FechaExpedicion = table.Column<DateTime>(nullable: false),
                    FechaVencimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identificaciones", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EtniaIndigenaId",
                table: "Personas",
                column: "EtniaIndigenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_GeneroId",
                table: "Personas",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdentificacionId",
                table: "Personas",
                column: "IdentificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_CursoLectivoId",
                table: "Matriculas",
                column: "CursoLectivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Archivos_Publicaciones_AsignacionId",
                table: "Archivos",
                column: "AsignacionId",
                principalTable: "Publicaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Archivos_Publicaciones_MaterialId",
                table: "Archivos",
                column: "MaterialId",
                principalTable: "Publicaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Archivos_Notificaciones_NotificacionId",
                table: "Archivos",
                column: "NotificacionId",
                principalTable: "Notificaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_TiposAsignatura_TipoAsignaturaId",
                table: "Asignaturas",
                column: "TipoAsignaturaId",
                principalTable: "TiposAsignatura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_TiposEvaluacion_TipoEvaluacionId",
                table: "Asignaturas",
                column: "TipoEvaluacionId",
                principalTable: "TiposEvaluacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Especialidades_EspecialidadId",
                table: "Asignaturas",
                column: "EspecialidadId",
                principalTable: "Especialidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cantones_Provincias_ProvinciaId",
                table: "Cantones",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Circuitos_Regionales_RegionalId",
                table: "Circuitos",
                column: "RegionalId",
                principalTable: "Regionales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Distritos_Cantones_CantonId",
                table: "Distritos",
                column: "CantonId",
                principalTable: "Cantones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_Modalidades_ModalidadId",
                table: "Especialidades",
                column: "ModalidadId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Giras_GiraId",
                table: "Funcionarios",
                column: "GiraId",
                principalTable: "Giras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Personas_PersonaId",
                table: "Funcionarios",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Giras_GiraId",
                table: "Gastos",
                column: "GiraId",
                principalTable: "Giras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_TiposGasto_TipoGastoId",
                table: "Gastos",
                column: "TipoGastoId",
                principalTable: "TiposGasto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_AspNetUsers_UsuarioId",
                table: "Gastos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Giras_Liquidaciones_LiquidacionId",
                table: "Giras",
                column: "LiquidacionId",
                principalTable: "Liquidaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Giras_Localidades_LocalidadVisitadaId",
                table: "Giras",
                column: "LocalidadVisitadaId",
                principalTable: "Localidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Giras_TiposTransporte_TipoTransporteId",
                table: "Giras",
                column: "TipoTransporteId",
                principalTable: "TiposTransporte",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Giras_AspNetUsers_UsuarioId",
                table: "Giras",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Publicaciones_AsignacionId",
                table: "Grupos",
                column: "AsignacionId",
                principalTable: "Publicaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_CursosLectivos_CursoLectivoId",
                table: "Grupos",
                column: "CursoLectivoId",
                principalTable: "CursosLectivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Instituciones_InstitucionId",
                table: "Grupos",
                column: "InstitucionId",
                principalTable: "Instituciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Niveles_NivelId",
                table: "Grupos",
                column: "NivelId",
                principalTable: "Niveles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instituciones_Circuitos_CircuitoId",
                table: "Instituciones",
                column: "CircuitoId",
                principalTable: "Circuitos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instituciones_Localidades_LocalidadId",
                table: "Instituciones",
                column: "LocalidadId",
                principalTable: "Localidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instituciones_ModalidadesInstitucion_ModalidadId",
                table: "Instituciones",
                column: "ModalidadId",
                principalTable: "ModalidadesInstitucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instituciones_TiposInstitucion_TipoInstitucionId",
                table: "Instituciones",
                column: "TipoInstitucionId",
                principalTable: "TiposInstitucion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Liquidaciones_AspNetUsers_UsuarioId",
                table: "Liquidaciones",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Localidades_Distritos_DistritoId",
                table: "Localidades",
                column: "DistritoId",
                principalTable: "Distritos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_CursosLectivos_CursoLectivoId",
                table: "Matriculas",
                column: "CursoLectivoId",
                principalTable: "CursosLectivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Personas_EstudianteId",
                table: "Matriculas",
                column: "EstudianteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Grupos_GrupoId",
                table: "Matriculas",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramientos_Funcionarios_FuncionarioId",
                table: "Nombramientos",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramientos_Instituciones_InstitucionId",
                table: "Nombramientos",
                column: "InstitucionId",
                principalTable: "Instituciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramientos_Puestos_PuestoId",
                table: "Nombramientos",
                column: "PuestoId",
                principalTable: "Puestos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nombramientos_TiposNombramiento_TipoNombramientoId",
                table: "Nombramientos",
                column: "TipoNombramientoId",
                principalTable: "TiposNombramiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Personas_PersonaId",
                table: "Notificaciones",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Etnia_EtniaIndigenaId",
                table: "Personas",
                column: "EtniaIndigenaId",
                principalTable: "Etnia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Genero_GeneroId",
                table: "Personas",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Identificaciones_IdentificacionId",
                table: "Personas",
                column: "IdentificacionId",
                principalTable: "Identificaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_Paises_PaisId",
                table: "Provincias",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicaciones_TiposAsignacion_TipoAsignacionId",
                table: "Publicaciones",
                column: "TipoAsignacionId",
                principalTable: "TiposAsignacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicaciones_Funcionarios_PublicadorId",
                table: "Publicaciones",
                column: "PublicadorId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicaciones_Temas_TemaId",
                table: "Publicaciones",
                column: "TemaId",
                principalTable: "Temas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Puestos_TiposPuesto_TipoPuestoId",
                table: "Puestos",
                column: "TipoPuestoId",
                principalTable: "TiposPuesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Temas_Asignaturas_AsignaturaId",
                table: "Temas",
                column: "AsignaturaId",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Archivos_Publicaciones_AsignacionId",
                table: "Archivos");

            migrationBuilder.DropForeignKey(
                name: "FK_Archivos_Publicaciones_MaterialId",
                table: "Archivos");

            migrationBuilder.DropForeignKey(
                name: "FK_Archivos_Notificaciones_NotificacionId",
                table: "Archivos");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_TiposAsignatura_TipoAsignaturaId",
                table: "Asignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_TiposEvaluacion_TipoEvaluacionId",
                table: "Asignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Especialidades_EspecialidadId",
                table: "Asignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Cantones_Provincias_ProvinciaId",
                table: "Cantones");

            migrationBuilder.DropForeignKey(
                name: "FK_Circuitos_Regionales_RegionalId",
                table: "Circuitos");

            migrationBuilder.DropForeignKey(
                name: "FK_Distritos_Cantones_CantonId",
                table: "Distritos");

            migrationBuilder.DropForeignKey(
                name: "FK_Especialidades_Modalidades_ModalidadId",
                table: "Especialidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Giras_GiraId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Personas_PersonaId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Giras_GiraId",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_TiposGasto_TipoGastoId",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_AspNetUsers_UsuarioId",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Giras_Liquidaciones_LiquidacionId",
                table: "Giras");

            migrationBuilder.DropForeignKey(
                name: "FK_Giras_Localidades_LocalidadVisitadaId",
                table: "Giras");

            migrationBuilder.DropForeignKey(
                name: "FK_Giras_TiposTransporte_TipoTransporteId",
                table: "Giras");

            migrationBuilder.DropForeignKey(
                name: "FK_Giras_AspNetUsers_UsuarioId",
                table: "Giras");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Publicaciones_AsignacionId",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_CursosLectivos_CursoLectivoId",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Instituciones_InstitucionId",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Niveles_NivelId",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_Instituciones_Circuitos_CircuitoId",
                table: "Instituciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Instituciones_Localidades_LocalidadId",
                table: "Instituciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Instituciones_ModalidadesInstitucion_ModalidadId",
                table: "Instituciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Instituciones_TiposInstitucion_TipoInstitucionId",
                table: "Instituciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Liquidaciones_AspNetUsers_UsuarioId",
                table: "Liquidaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Localidades_Distritos_DistritoId",
                table: "Localidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_CursosLectivos_CursoLectivoId",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Personas_EstudianteId",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Grupos_GrupoId",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramientos_Funcionarios_FuncionarioId",
                table: "Nombramientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramientos_Instituciones_InstitucionId",
                table: "Nombramientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramientos_Puestos_PuestoId",
                table: "Nombramientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Nombramientos_TiposNombramiento_TipoNombramientoId",
                table: "Nombramientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_Personas_PersonaId",
                table: "Notificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Etnia_EtniaIndigenaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Genero_GeneroId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Identificaciones_IdentificacionId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_Paises_PaisId",
                table: "Provincias");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicaciones_TiposAsignacion_TipoAsignacionId",
                table: "Publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicaciones_Funcionarios_PublicadorId",
                table: "Publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Publicaciones_Temas_TemaId",
                table: "Publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Puestos_TiposPuesto_TipoPuestoId",
                table: "Puestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Temas_Asignaturas_AsignaturaId",
                table: "Temas");

            migrationBuilder.DropTable(
                name: "Etnia");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Identificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EtniaIndigenaId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_GeneroId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_IdentificacionId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposTransporte",
                table: "TiposTransporte");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposPuesto",
                table: "TiposPuesto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposNombramiento",
                table: "TiposNombramiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposLocalizacion",
                table: "TiposLocalizacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposInstitucion",
                table: "TiposInstitucion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposGasto",
                table: "TiposGasto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposEvaluacion",
                table: "TiposEvaluacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposAsignatura",
                table: "TiposAsignatura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposAsignacion",
                table: "TiposAsignacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Temas",
                table: "Temas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regionales",
                table: "Regionales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Puestos",
                table: "Puestos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publicaciones",
                table: "Publicaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paises",
                table: "Paises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notificaciones",
                table: "Notificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nombramientos",
                table: "Nombramientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Niveles",
                table: "Niveles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModalidadesInstitucion",
                table: "ModalidadesInstitucion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modalidades",
                table: "Modalidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matriculas",
                table: "Matriculas");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_CursoLectivoId",
                table: "Matriculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Localidades",
                table: "Localidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Liquidaciones",
                table: "Liquidaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instituciones",
                table: "Instituciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Giras",
                table: "Giras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gastos",
                table: "Gastos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Distritos",
                table: "Distritos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CursosLectivos",
                table: "CursosLectivos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Circuitos",
                table: "Circuitos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cantones",
                table: "Cantones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Asignaturas",
                table: "Asignaturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Archivos",
                table: "Archivos");

            migrationBuilder.DropColumn(
                name: "EtniaIndigenaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdentificacionId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "CursoLectivoId",
                table: "Matriculas");

            migrationBuilder.RenameTable(
                name: "TiposTransporte",
                newName: "TipoTransporte");

            migrationBuilder.RenameTable(
                name: "TiposPuesto",
                newName: "TipoPuesto");

            migrationBuilder.RenameTable(
                name: "TiposNombramiento",
                newName: "TipoNombramiento");

            migrationBuilder.RenameTable(
                name: "TiposLocalizacion",
                newName: "TipoLocalizacion");

            migrationBuilder.RenameTable(
                name: "TiposInstitucion",
                newName: "TipoInstitucion");

            migrationBuilder.RenameTable(
                name: "TiposGasto",
                newName: "TipoGasto");

            migrationBuilder.RenameTable(
                name: "TiposEvaluacion",
                newName: "TipoEvaluacion");

            migrationBuilder.RenameTable(
                name: "TiposAsignatura",
                newName: "TipoAsignatura");

            migrationBuilder.RenameTable(
                name: "TiposAsignacion",
                newName: "TipoAsignacion");

            migrationBuilder.RenameTable(
                name: "Temas",
                newName: "Tema");

            migrationBuilder.RenameTable(
                name: "Regionales",
                newName: "Regional");

            migrationBuilder.RenameTable(
                name: "Puestos",
                newName: "Puesto");

            migrationBuilder.RenameTable(
                name: "Publicaciones",
                newName: "Publicacion");

            migrationBuilder.RenameTable(
                name: "Provincias",
                newName: "Provincia");

            migrationBuilder.RenameTable(
                name: "Paises",
                newName: "Pais");

            migrationBuilder.RenameTable(
                name: "Notificaciones",
                newName: "Notificacion");

            migrationBuilder.RenameTable(
                name: "Nombramientos",
                newName: "Nombramiento");

            migrationBuilder.RenameTable(
                name: "Niveles",
                newName: "Nivel");

            migrationBuilder.RenameTable(
                name: "ModalidadesInstitucion",
                newName: "ModalidadInstitucion");

            migrationBuilder.RenameTable(
                name: "Modalidades",
                newName: "Modalidad");

            migrationBuilder.RenameTable(
                name: "Matriculas",
                newName: "Matricula");

            migrationBuilder.RenameTable(
                name: "Localidades",
                newName: "Localidad");

            migrationBuilder.RenameTable(
                name: "Liquidaciones",
                newName: "Liquidacion");

            migrationBuilder.RenameTable(
                name: "Instituciones",
                newName: "Institucion");

            migrationBuilder.RenameTable(
                name: "Grupos",
                newName: "Grupo");

            migrationBuilder.RenameTable(
                name: "Giras",
                newName: "Gira");

            migrationBuilder.RenameTable(
                name: "Gastos",
                newName: "Gasto");

            migrationBuilder.RenameTable(
                name: "Funcionarios",
                newName: "Funcionario");

            migrationBuilder.RenameTable(
                name: "Especialidades",
                newName: "Especialidad");

            migrationBuilder.RenameTable(
                name: "Distritos",
                newName: "Distrito");

            migrationBuilder.RenameTable(
                name: "CursosLectivos",
                newName: "CursoLectivo");

            migrationBuilder.RenameTable(
                name: "Circuitos",
                newName: "Circuito");

            migrationBuilder.RenameTable(
                name: "Cantones",
                newName: "Canton");

            migrationBuilder.RenameTable(
                name: "Asignaturas",
                newName: "Asignatura");

            migrationBuilder.RenameTable(
                name: "Archivos",
                newName: "Archivo");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Personas",
                newName: "Cedula");

            migrationBuilder.RenameIndex(
                name: "IX_Temas_AsignaturaId",
                table: "Tema",
                newName: "IX_Tema_AsignaturaId");

            migrationBuilder.RenameIndex(
                name: "IX_Puestos_TipoPuestoId",
                table: "Puesto",
                newName: "IX_Puesto_TipoPuestoId");

            migrationBuilder.RenameIndex(
                name: "IX_Publicaciones_TemaId",
                table: "Publicacion",
                newName: "IX_Publicacion_TemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Publicaciones_PublicadorId",
                table: "Publicacion",
                newName: "IX_Publicacion_PublicadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Publicaciones_TipoAsignacionId",
                table: "Publicacion",
                newName: "IX_Publicacion_TipoAsignacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Provincias_PaisId",
                table: "Provincia",
                newName: "IX_Provincia_PaisId");

            migrationBuilder.RenameIndex(
                name: "IX_Notificaciones_PersonaId",
                table: "Notificacion",
                newName: "IX_Notificacion_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Nombramientos_TipoNombramientoId",
                table: "Nombramiento",
                newName: "IX_Nombramiento_TipoNombramientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Nombramientos_PuestoId",
                table: "Nombramiento",
                newName: "IX_Nombramiento_PuestoId");

            migrationBuilder.RenameIndex(
                name: "IX_Nombramientos_InstitucionId",
                table: "Nombramiento",
                newName: "IX_Nombramiento_InstitucionId");

            migrationBuilder.RenameIndex(
                name: "IX_Nombramientos_FuncionarioId",
                table: "Nombramiento",
                newName: "IX_Nombramiento_FuncionarioId");

            migrationBuilder.RenameColumn(
                name: "EstudianteId",
                table: "Matricula",
                newName: "PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Matriculas_GrupoId",
                table: "Matricula",
                newName: "IX_Matricula_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_Matriculas_EstudianteId",
                table: "Matricula",
                newName: "IX_Matricula_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Localidades_DistritoId",
                table: "Localidad",
                newName: "IX_Localidad_DistritoId");

            migrationBuilder.RenameIndex(
                name: "IX_Liquidaciones_UsuarioId",
                table: "Liquidacion",
                newName: "IX_Liquidacion_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Instituciones_TipoInstitucionId",
                table: "Institucion",
                newName: "IX_Institucion_TipoInstitucionId");

            migrationBuilder.RenameIndex(
                name: "IX_Instituciones_ModalidadId",
                table: "Institucion",
                newName: "IX_Institucion_ModalidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Instituciones_LocalidadId",
                table: "Institucion",
                newName: "IX_Institucion_LocalidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Instituciones_CircuitoId",
                table: "Institucion",
                newName: "IX_Institucion_CircuitoId");

            migrationBuilder.RenameIndex(
                name: "IX_Grupos_NivelId",
                table: "Grupo",
                newName: "IX_Grupo_NivelId");

            migrationBuilder.RenameIndex(
                name: "IX_Grupos_InstitucionId",
                table: "Grupo",
                newName: "IX_Grupo_InstitucionId");

            migrationBuilder.RenameIndex(
                name: "IX_Grupos_CursoLectivoId",
                table: "Grupo",
                newName: "IX_Grupo_CursoLectivoId");

            migrationBuilder.RenameIndex(
                name: "IX_Grupos_AsignacionId",
                table: "Grupo",
                newName: "IX_Grupo_AsignacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Giras_UsuarioId",
                table: "Gira",
                newName: "IX_Gira_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Giras_TipoTransporteId",
                table: "Gira",
                newName: "IX_Gira_TipoTransporteId");

            migrationBuilder.RenameIndex(
                name: "IX_Giras_LocalidadVisitadaId",
                table: "Gira",
                newName: "IX_Gira_LocalidadVisitadaId");

            migrationBuilder.RenameIndex(
                name: "IX_Giras_LiquidacionId",
                table: "Gira",
                newName: "IX_Gira_LiquidacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Gastos_UsuarioId",
                table: "Gasto",
                newName: "IX_Gasto_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Gastos_TipoGastoId",
                table: "Gasto",
                newName: "IX_Gasto_TipoGastoId");

            migrationBuilder.RenameIndex(
                name: "IX_Gastos_GiraId",
                table: "Gasto",
                newName: "IX_Gasto_GiraId");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionarios_PersonaId",
                table: "Funcionario",
                newName: "IX_Funcionario_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionarios_GiraId",
                table: "Funcionario",
                newName: "IX_Funcionario_GiraId");

            migrationBuilder.RenameIndex(
                name: "IX_Especialidades_ModalidadId",
                table: "Especialidad",
                newName: "IX_Especialidad_ModalidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Distritos_CantonId",
                table: "Distrito",
                newName: "IX_Distrito_CantonId");

            migrationBuilder.RenameIndex(
                name: "IX_Circuitos_RegionalId",
                table: "Circuito",
                newName: "IX_Circuito_RegionalId");

            migrationBuilder.RenameIndex(
                name: "IX_Cantones_ProvinciaId",
                table: "Canton",
                newName: "IX_Canton_ProvinciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Asignaturas_EspecialidadId",
                table: "Asignatura",
                newName: "IX_Asignatura_EspecialidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Asignaturas_TipoEvaluacionId",
                table: "Asignatura",
                newName: "IX_Asignatura_TipoEvaluacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Asignaturas_TipoAsignaturaId",
                table: "Asignatura",
                newName: "IX_Asignatura_TipoAsignaturaId");

            migrationBuilder.RenameIndex(
                name: "IX_Archivos_NotificacionId",
                table: "Archivo",
                newName: "IX_Archivo_NotificacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Archivos_MaterialId",
                table: "Archivo",
                newName: "IX_Archivo_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Archivos_AsignacionId",
                table: "Archivo",
                newName: "IX_Archivo_AsignacionId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Archivo",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoTransporte",
                table: "TipoTransporte",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPuesto",
                table: "TipoPuesto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoNombramiento",
                table: "TipoNombramiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoLocalizacion",
                table: "TipoLocalizacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoInstitucion",
                table: "TipoInstitucion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoGasto",
                table: "TipoGasto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoEvaluacion",
                table: "TipoEvaluacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoAsignatura",
                table: "TipoAsignatura",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoAsignacion",
                table: "TipoAsignacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tema",
                table: "Tema",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regional",
                table: "Regional",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Puesto",
                table: "Puesto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publicacion",
                table: "Publicacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincia",
                table: "Provincia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pais",
                table: "Pais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notificacion",
                table: "Notificacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nombramiento",
                table: "Nombramiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nivel",
                table: "Nivel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModalidadInstitucion",
                table: "ModalidadInstitucion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modalidad",
                table: "Modalidad",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matricula",
                table: "Matricula",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Localidad",
                table: "Localidad",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Liquidacion",
                table: "Liquidacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Institucion",
                table: "Institucion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupo",
                table: "Grupo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gira",
                table: "Gira",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gasto",
                table: "Gasto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especialidad",
                table: "Especialidad",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distrito",
                table: "Distrito",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CursoLectivo",
                table: "CursoLectivo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Circuito",
                table: "Circuito",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Canton",
                table: "Canton",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Asignatura",
                table: "Asignatura",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Archivo",
                table: "Archivo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Archivo_Publicacion_AsignacionId",
                table: "Archivo",
                column: "AsignacionId",
                principalTable: "Publicacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Archivo_Publicacion_MaterialId",
                table: "Archivo",
                column: "MaterialId",
                principalTable: "Publicacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Archivo_Notificacion_NotificacionId",
                table: "Archivo",
                column: "NotificacionId",
                principalTable: "Notificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Funcionario_Gira_GiraId",
                table: "Funcionario",
                column: "GiraId",
                principalTable: "Gira",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Personas_PersonaId",
                table: "Funcionario",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gasto_Gira_GiraId",
                table: "Gasto",
                column: "GiraId",
                principalTable: "Gira",
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
                name: "FK_Gasto_AspNetUsers_UsuarioId",
                table: "Gasto",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gira_Liquidacion_LiquidacionId",
                table: "Gira",
                column: "LiquidacionId",
                principalTable: "Liquidacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Gira_AspNetUsers_UsuarioId",
                table: "Gira",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupo_Publicacion_AsignacionId",
                table: "Grupo",
                column: "AsignacionId",
                principalTable: "Publicacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Matricula_Grupo_GrupoId",
                table: "Matricula",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Notificacion_Personas_PersonaId",
                table: "Notificacion",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
