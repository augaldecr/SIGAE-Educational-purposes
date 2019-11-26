namespace SIGAE.Web.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SIGAE.Web.Data.Entities.Administrativo.Asesoria;

    public class GastoViewModel : Gasto
    {
        [Required]
        [Display(Name ="Tipo de gasto")]
        public int TipoGastoId { get; set; }
        //Url donde se almacena la factura
        [Display(Name = "Factura")]
        public IFormFile FacturaImg { get; set; }
        public IEnumerable<SelectListItem> TiposGasto { get; set; }
    }
}
