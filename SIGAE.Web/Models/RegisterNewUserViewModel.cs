using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Models
{
    public class RegisterNewUserViewModel
    {
        [Required]
        [Display(Name = "Cédula")]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Primer apellido")]
        public string Apellido1 { get; set; }
        [Required]
        [Display(Name = "Segundo apellido")]
        public string Apellido2 { get; set; }
        [Required]
        [Display(Name = "Teléfono celular")]
        public string Celular { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }
    }
}
