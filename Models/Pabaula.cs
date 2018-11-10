using System;  
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using PROYECTO_APP_VISION_VISUAL_STUDIO.Models;

namespace PROYECTO_VISION_USMP.Models 
{ 

  public class PabAula
    {
        
        [Display(Name="Codigo de Pabellón")]
        public string IDPabellon { get; set;}

        [Display(Name="Codigo de Aula")]
        public string IDAula{ get; set;}
        [Required]
        [MaxLength(1)]
        public int Piso {get; set;}

         [Required]
        public int Capacidad {get; set;}
        public virtual pabellon CodigoPabellon {get; set;}
        public virtual Aula CodigoAula {get;set;}
       
    
       
    }


}


