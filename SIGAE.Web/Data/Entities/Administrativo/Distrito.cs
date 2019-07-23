﻿namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Distrito : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Cantón")]
        public Canton Canton { get; set; }

        public virtual IEnumerable<Localidad> Localidades { get; set; }
    }
}