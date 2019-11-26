﻿using Microsoft.AspNetCore.Mvc.Rendering;
using SIGAE.Web.Data.Entities.Becas;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Models.Becas
{
    public class BecaRemuneradaViewModel
    {
        [Display(Name = "Tipo de beca")]
        public TipoBeca TipoBeca { get; set; }

        public decimal Monto { get; set; }

        public int TipoBecaId { get; set; }

        public IEnumerable<SelectListItem> TiposBeca { get; set; }
    }
}
