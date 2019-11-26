using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data.Entities;
using SIGAE.Web.Models;
using SIGAE.Web.Data.Entities.Becas;

namespace SIGAE.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*var cascadeFKs = builder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }      */

            base.OnModelCreating(builder);
        }

        public DbSet<Identificacion> Identificaciones { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Entities.Academico.TipoEvaluacion> TiposEvaluacion { get; set; }
        public DbSet<Entities.Academico.TipoAsignatura> TiposAsignatura { get; set; }
        public DbSet<Entities.Academico.TipoAsignacion> TiposAsignacion { get; set; }
        public DbSet<Entities.Academico.Modalidad> Modalidades { get; set; }
        public DbSet<Entities.Academico.Especialidad> Especialidades { get; set; }
        public DbSet<Entities.Academico.SubArea> SubAreas { get; set; }
        public DbSet<Entities.Academico.Asignatura> Asignaturas { get; set; }
        public DbSet<Entities.Academico.Tema> Temas { get; set; }
        public DbSet<Entities.Misc.Archivo> Archivos { get; set; }
        public DbSet<Entities.Administrativo.TipoPuesto> TiposPuesto { get; set; }
        public DbSet<Entities.Administrativo.Puesto> Puestos { get; set; }
        public DbSet<Entities.Administrativo.Funcionario> Funcionarios { get; set; }
        public DbSet<Entities.Academico.Material> Materiales { get; set; }
        public DbSet<Entities.Academico.Asignacion> Asignaciones { get; set; }
        public DbSet<Entities.Academico.Publicacion> Publicaciones { get; set; }
        public DbSet<Entities.Misc.Notificacion> Notificaciones { get; set; }
        public DbSet<Entities.Administrativo.TipoNombramiento> TiposNombramiento { get; set; }
        public DbSet<Entities.Administrativo.TipoLocalizacion> TiposLocalizacion { get; set; }
        public DbSet<Entities.Administrativo.Regional> Regionales { get; set; }
        public DbSet<Entities.Administrativo.Pais> Paises { get; set; }
        public DbSet<Entities.Administrativo.Provincia> Provincias { get; set; }
        public DbSet<Entities.Administrativo.Nivel> Niveles { get; set; }
        public DbSet<Entities.Administrativo.Canton> Cantones { get; set; }
        public DbSet<Entities.Administrativo.CursoLectivo> CursosLectivos { get; set; }
        public DbSet<Entities.Administrativo.Distrito> Distritos { get; set; }
        public DbSet<Entities.Administrativo.Localidad> Localidades { get; set; }
        public DbSet<Entities.Administrativo.Circuito> Circuitos { get; set; }
        public DbSet<Entities.Administrativo.TipoInstitucion> TiposInstitucion { get; set; }
        public DbSet<Entities.Administrativo.ModalidadInstitucion> ModalidadesInstitucion { get; set; }
        public DbSet<Entities.Administrativo.Institucion> Instituciones { get; set; }
        public DbSet<Entities.Administrativo.Nombramiento> Nombramientos { get; set; }
        public DbSet<Entities.Administrativo.Grupo> Grupos { get; set; }
        public DbSet<Entities.Administrativo.Matricula> Matriculas { get; set; }
        public DbSet<Entities.Administrativo.Asesoria.TipoTransporte> TiposTransporte { get; set; }
        public DbSet<Entities.Administrativo.Asesoria.TipoGasto> TiposGasto { get; set; }
        public DbSet<Entities.Administrativo.Asesoria.Gasto> Gastos { get; set; }
        public DbSet<Entities.Administrativo.Asesoria.Gira> Giras { get; set; }
        public DbSet<Entities.Administrativo.Asesoria.Liquidacion> Liquidaciones { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TipoIdentificacion> TiposIdentificacion { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Becas.TipoBeca> TipoBeca { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Becas.Subsidio> Subsidio { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Becas.Parentesco> Parentesco { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Becas.Beca> Beca { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Becas.BecaRemunerada> BecaRemunerada { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Becas.Familiar> Familiar { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Becas.Solicitud> Solicitud { get; set; }
    }
}