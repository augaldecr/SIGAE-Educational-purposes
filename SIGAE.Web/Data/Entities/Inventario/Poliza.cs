namespace SIGAE.Web.Data.Entities.Inventario
{
    using System;

    public class Poliza : IEntity
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime FechaRige { get; set; }
        public DateTime FechaVence { get; set; }
    }
}
