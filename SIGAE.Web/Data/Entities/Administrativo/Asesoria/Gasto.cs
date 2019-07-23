namespace SIGAE.Web.Data.Entities.Administrativo.Asesoria
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Gasto : IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tipo de gasto")]
        public TipoGasto TipoGasto { get; set; }
        [Required]
        public int Monto { get; set; }
        //Url donde se almacena la factura
        public String Factura { get; set; }
        public User Usuario { get; set; }
    }
}
