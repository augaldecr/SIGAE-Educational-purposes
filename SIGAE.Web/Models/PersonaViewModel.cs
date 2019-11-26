using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using SIGAE.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Models
{
    public class PersonaViewModel
    {
        public int Id { get; set; }
        [PersonalData]
        [Display(Name = "Cédula")]
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

        public Genero Genero { get; set; }
        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [PersonalData]
        public string Celular { get; set; }
        [Display(Name = "Correo electrónico")]
        [PersonalData]
        public string Email { get; set; }

        [Display(Name = "Género")]
        public int GeneroId { get; set; }

        public int IdentificacionId { get; set; }

        [Display(Name ="Número de cédula")]
        public string NumCedula { get; set; }

        [Display(Name = "Tipo de identificación")]
        public TipoIdentificacion TipoIdentificacion { get; set; }

        [Display(Name = "Tipo de identificación")]
        public int TipoIdentificacionId { get; set; }

        public IEnumerable<SelectListItem> Generos { get; set; }
        public IEnumerable<SelectListItem> TiposIdentificacion { get; set; }
    }
}