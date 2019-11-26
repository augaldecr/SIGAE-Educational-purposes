using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Administrativo
{
    public class Funcionario : IEntity
    {
        public int Id { get; set; }
        [Required]
        public Persona Persona { get; set; }

        public override string ToString() => this.Persona.ToString();
    }
}