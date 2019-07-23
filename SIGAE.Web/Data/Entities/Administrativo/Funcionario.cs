namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.ComponentModel.DataAnnotations;

    public class Funcionario : IEntity
    {
        public int Id { get; set; }
        [Required]
        public Persona Persona { get; set; }
        [Required]
        public Puesto Puesto { get; set; }

        public override string ToString()
        {
            return this.Persona.ToString();
        }
    }
}
