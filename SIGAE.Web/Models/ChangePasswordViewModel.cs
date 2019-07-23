using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Models
{
    public class ChangePasswordViewModel
    {
        [Required]
        [Display(Name = "Contraseña actual")]
        public string OldPassword { get; set; }
        [Required]
        [Display(Name = "Contraseña nueva")]
        public string NewPassword { get; set; }
        [Required]
        [Display(Name = "Confirmación")]
        [Compare("NewPassword")]
        public string Confirm { get; set; }
    }
}
