using System;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Misc
{
    public class Archivo : EntidadBase, IEntity
    {
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string URL { get; set; }
    }
}