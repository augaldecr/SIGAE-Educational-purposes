namespace SIGAE.Web.Data.Entities.Administrativo.Asesoria
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class TipoGasto : IEntity
    {
        public int Id { get; set; }
        //Desayuno, almuerzo, cena, hospedaje, etc
        [Required]
        public String Nombre { get; set; }
    }
}
