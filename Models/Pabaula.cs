using System;  
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace PROYECTO_VISION_USMP.Models 
{ 

  public class PabAula
    {
        
        [Display(Name="Codigo de Pabellón")]
        public string IDPabellon { get; set;}


        
    
        [Required] 
        public string IdPab { get; set; } 
        [Required] 
        public string Pab { get; set; } 
        [Required] 
 
        public string IdAula { get; set; } 
        [Required]
        public string Aula{ get; set; } 
        [Required] 
        public string Piso { get; set; } 
        [Required] 
        public int Cap { get; set; } 
    }


}