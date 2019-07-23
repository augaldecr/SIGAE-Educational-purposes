namespace SIGAE.Web.Data.Entities.Inventario
{
    using System;

    public class Item : IEntity
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Localizacion Localizacion { get; set; }
        public string Placa { get; set; }
        public string Serie { get; set; }
        public Modelo Modelo { get; set; }
        public Estado Estado { get; set; }
        public Compra CompraAdquision { get; set; }
        public decimal Costo { get; set; }
        public DateTime GarantiaVence { get; set; }
        public Poliza Poliza { get; set; }
        public string LeyFinanciamiento { get; set; }
    }
}
