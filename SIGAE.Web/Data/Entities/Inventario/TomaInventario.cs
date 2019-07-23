using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Data.Entities.Inventario
{
    public class TomaInventario : IEntity
    {
        public int Id { get; set; }
        public string MyProperty { get; set; }
    }
}
