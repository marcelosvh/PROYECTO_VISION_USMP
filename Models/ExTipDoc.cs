using System;  
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace PROYECTO_VISION_USMP.Models

{
        public class ExpTipDoc
    {
        
        [Display(Name="Codigo de Tipo de Documento")]
        public string IDTip {get; set;}
        
        [Display(Name="Codigo de Expositor")]

        public string IDExpositor {get; set;}
        [Required]
        [MaxLength(12)]
        public int Número { get;set;}
        public virtual TipoDocumento CodigoTipoDocumento {get; set;}
        public virtual Expositor CodigoExpositor {get; set;}

    }
}