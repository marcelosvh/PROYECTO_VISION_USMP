using System;   
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROYECTO_VISION_USMP.Models 
{ 
    public class Pabellon
 
    { 

        [Key]
        [Required] 
        [Display(Name="Codigo de Pabellón")]
        public string IDPabellon { get; set; }
        [ForeignKey("IDPabellon")] 
        [Display(Name="Nombre de Pabellón")]
        [Required] 
        public string NomPab { get; set; } 

           public ICollection<Taller> Talleres {get; set;}
        public ICollection<Conferencia> Conferencias {get; set;}
        
 
    }
}
