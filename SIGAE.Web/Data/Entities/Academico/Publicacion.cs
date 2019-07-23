namespace SIGAE.Web.Data.Entities.Academico
{
    using Administrativo;
    using System;
    using System.ComponentModel.DataAnnotations;

    //Clase base para las publicaciones
    public abstract class Publicacion : IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Fecha de creación")]
        public DateTime FechaCreacion { get; set; }
        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required]
        public Tema Tema { get; set; }
        [Required]
        public Funcionario Publicador { get; set; }
    }
}
