using System;   
 
using System.ComponentModel.DataAnnotations; 
 
namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Models 

 
{ 
    public class Pabaula{

    
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