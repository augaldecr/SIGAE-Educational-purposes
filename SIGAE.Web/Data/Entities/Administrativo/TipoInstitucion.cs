using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIGAE.Web.Data.Entities.Administrativo
{
    //Preescolar, I & II ciclos, III ciclo, Educación diversificada
    public class TipoInstitucion
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
