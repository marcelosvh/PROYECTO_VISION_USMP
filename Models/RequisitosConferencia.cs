using System;   
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 
 
namespace PROYECTO_VISION_USMP.Models 
{ 
    public class RequisitosConferencia
 
    { 

         
        [Display(Name="Codigo de Expositor")]
        public string IDExpositor { get; set; } 
        
        [Display(Name="Codigo de Conferencia")]
        
        public string IDConferencia { get; set; }
        [Required]
        [Display(Name="Descripción de Requisitos Conferencia")]
        public string DescReqConf { get; set; }
        public virtual Expositor CodigoExpositor {get; set;}
        public virtual Conferencia CodigoConferencia {get; set;} 


        }


}