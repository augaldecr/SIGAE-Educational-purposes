using SIGAE.Web.Data.Entities;
using SIGAE.Web.Data.Entities.Administrativo;
using SIGAE.Web.Data.Entities.Becas;
using SIGAE.Web.Data.Entities.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Models.Becas
{
    public class SolicitudViewModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public Matricula Solicitante { get; set; }
        public Persona Encargado { get; set; }
        [Required]
        [Display(Name = "Dirección")]
        public String Direccion { get; set; }
        public Localidad Poblado { get; set; }
        [Required]
        [Display(Name = "Distancia al centro educativo")]
        public String DistanciaAlCentroEducativo { get; set; }
        [Display(Name = "Beneficio solicitado")]
        public Beca BecaSolicitada { get; set; }
        [Display(Name = "Número de subsidio de transporte")]
        public Subsidio NumSubsidioTransporte { get; set; }

        public RutaTransporte Ruta { get; set; }

        [Required]
        [Display(Name = "¿Existe transporte público adecuado a los horarios del centro educativo?")]
        public bool TrnspPblcHorarioCentEduc { get; set; }

        [Required]
        [Display(Name = "¿El centro educativo en el que está matriculado es el más cercano a su lugar de residencia?")]
        public bool CentEducCercania { get; set; }

        [Display(Name = "Si en la pregunta anterior marcó no, indique cúal es")]
        public Institucion CentroEducativoCercano { get; set; }

        [Display(Name = "¿A qué distancia (KM) está dicho centro educativo de su hogar?")]
        public string DistanciaAMasCercano { get; set; }

        [Display(Name = "¿Por qué no matriculó en dicha institución?")]
        public string RazonDeNoMatricula { get; set; }

        [Display(Name = "¿A qué distancia (KM), de su hogar, está el centro educativo en el que está matriculado ?")]
        public string DistanciaAMatriculado { get; set; }

        public IList<MedioTransporteSolicitado> MediosSolicitados { get; }

        public IList<DialectoHablado> DialectoHablados { get; }

        public string Observaciones { get; set; }

        [Required]
        [DefaultValue(false)]
        [Display(Name = "Aprobada")]
        public bool Aprobada { get; set; }
    }
}