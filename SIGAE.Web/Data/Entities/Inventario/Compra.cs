namespace SIGAE.Web.Data.Entities.Inventario
{
    using System;

    public class Compra : IEntity
    {
        public int Id { get; set; }
        public string NumFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
