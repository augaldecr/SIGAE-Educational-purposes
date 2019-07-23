using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities
{
    public class Persona : IEntity
    {
        public int Id { get; set; }
        [PersonalData]
        [Display(Name = "Cédula")]
        [Required]
        public string Cedula { get; set; }
        [PersonalData]
        [Required]
        public string Nombre { get; set; }
        [Display(Name = "Primer apellido")]
        [PersonalData]
        [Required]
        public string Apellido1 { get; set; }
        [Display(Name = "Segundo apellido")]
        [PersonalData]
        [Required]
        public string Apellido2 { get; set; }
        [PersonalData]
        public string Celular { get; set; }
        [Display(Name = "Correo electrónico")]
        [PersonalData]
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{this.Cedula} - {this.Apellido1} {this.Apellido2} {this.Nombre}";
        }
    }
}
