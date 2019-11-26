using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities
{
    public class Persona : IEntity
    {
        public int Id { get; set; }
        [PersonalData]
        [Display(Name = "Cédula")]
        [Required]
        public Identificacion Identificacion { get; set; }
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
        [Required]
        [Display(Name = "Género")]
        public Genero Genero { get; set; }
        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [PersonalData]
        public string Celular { get; set; }
        [Display(Name = "Correo electrónico")]
        [PersonalData]
        public string Email { get; set; }

        public string NombreCorto() => $"{Apellido1} {Apellido2.Substring(0, 1)}. {Nombre}";

        public override string ToString() =>  $"{this.Identificacion} - {this.Apellido1} {this.Apellido2} {this.Nombre}";
    }
}