using System;
using System.Collections.Generic;
using System.Text;

namespace SIGAE.Common.Entities.Academico
{
    public class Publicacion
    {
        public int Id { get; set; }
        public Persona Publicador { get; set; }
    }
}
