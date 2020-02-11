using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Padron.Data
{
    public class Persona
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Genero { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre { get; set; }
    }
}
