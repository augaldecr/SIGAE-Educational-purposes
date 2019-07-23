using SIGAE.Common.Entities.Academico;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGAE.Common.Entities.Misc
{
    public class Archivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string URL { get; set; }
        public Publicacion Publicacion { get; set; }

    }
}
