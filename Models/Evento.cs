using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PROYECTO_VISION_USMP.Models

{
    public class Evento
    {
        [Key]
        [Required]
        [Display(Name="Codigo de Evento")]

        public string IDEvento {get; set;}
        [Required]
        [Display(Name="Tema de Evento")]
        public string TemaEvento {get; set;}
        [Display(Name="Fecha de Inicio ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        [Required]
        public string Fecha_Ini {get; set;}
        [Display(Name="Fecha de Fin ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        [Required]
        public string Fecha_Fin {get; set;}
        public ICollection<Conferencia> Conferencias {get; set;}
        public ICollection<Taller> Tallers {get; set;}
    }
}