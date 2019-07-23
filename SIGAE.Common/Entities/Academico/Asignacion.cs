using System;
using System.Collections.Generic;
using System.Text;

namespace SIGAE.Common.Entities.Academico
{
    public class Asignacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string  Instrucciones { get; set; }
        public int Puntos { get; set; }
        public DateTime FechaEntrega { get; set; }
        public Tema Tema { get; set; }
        
    }
}
