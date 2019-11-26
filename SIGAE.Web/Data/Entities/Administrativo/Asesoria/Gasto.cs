namespace SIGAE.Web.Data.Entities.Administrativo.Asesoria
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Gasto : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Tipo de gasto")]
        public TipoGasto TipoGasto { get; set; }
        [Required]
        public int Monto { get; set; }
        //Url donde se almacena la factura
        public String Factura { get; set; }
        public User Usuario { get; set; }
        public bool Asignado { get; set; }

        public override string ToString() => $"{this.TipoGasto.Nombre} {this.Monto}";   
    }
}