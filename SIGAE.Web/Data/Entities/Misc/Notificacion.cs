namespace SIGAE.Web.Data.Entities.Misc
{
    using System.Collections.Generic;

    public class Notificacion : IEntity
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        //Número de teléfono, correo electrónico, etc
        public string Medio { get; set; }
        public string Mensaje { get; set; }
        public IEnumerable<Archivo> Adjuntos { get; set; }
    }
}
