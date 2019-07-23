namespace SIGAE.Web.Data
{
    using Entities;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var cascadeFKs = builder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(builder);
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Entities.Academico.TipoEvaluacion> TipoEvaluacion { get; set; }
        public DbSet<Entities.Academico.TipoAsignatura> TipoAsignatura { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Academico.TipoAsignacion> TipoAsignacion { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Academico.Modalidad> Modalidad { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Academico.Especialidad> Especialidad { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Academico.SubArea> SubArea { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Academico.Asignatura> Asignatura { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Academico.Tema> Tema { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Misc.Archivo> Archivo { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.TipoPuesto> TipoPuesto { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Puesto> Puesto { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Funcionario> Funcionario { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Academico.Material> Material { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Academico.Asignacion> Asignacion { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Academico.Publicacion> Publicacion { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Misc.Notificacion> Notificacion { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.TipoNombramiento> TipoNombramiento { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.TipoLocalizacion> TipoLocalizacion { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Regional> Regional { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Pais> Pais { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Provincia> Provincia { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Nivel> Nivel { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Canton> Canton { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.CursoLectivo> CursoLectivo { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Distrito> Distrito { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Localidad> Localidad { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Circuito> Circuito { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.TipoInstitucion> TipoInstitucion { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.ModalidadInstitucion> ModalidadInstitucion { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Institucion> Institucion { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Nombramiento> Nombramiento { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Grupo> Grupo { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Matricula> Matricula { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Asesoria.TipoTransporte> TipoTransporte { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Asesoria.TipoGasto> TipoGasto { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Asesoria.Gasto> Gasto { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Asesoria.Gira> Gira { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.Administrativo.Asesoria.Liquidacion> Liquidacion { get; set; }
        public DbSet<SIGAE.Web.Data.Entities.User> User { get; set; }
    }
}
