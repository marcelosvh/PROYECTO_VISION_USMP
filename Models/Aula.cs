using System;  
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROYECTO_VISION_USMP.Models
{
    public class Aula
    {

        [Key]
        [Required]
        [Display(Name="Codigo de Aula")]
        public string IDAula {get; set;}
        [ForeignKey("IDAula")]
        [Display(Name="Descripción de Aula")]
        [Required]
        public string DescAula {get; set;}
        
        public ICollection<Taller> Talleres { get; set;}

    }
    
}