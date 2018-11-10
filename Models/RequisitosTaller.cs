using System;  
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROYECTO_VISION_USMP.Models
{
    public class RequisitosTaller
    {
        
        [Display(Name="Codigo de Expositor")]
        public string IDExpositor { get; set; }
        
        
        [Display(Name="Codigo de Taller")]
        public string IDTaller { get; set; }
        
        [Required]
        [Display(Name="Descripción de Requisitos Taller")]
        public string DescReqTal { get; set; }
        public virtual Expositor CodigoExpositor {get; set;}
        public virtual Taller CodigoTaller {get; set;}

    }
}