using System;   
 
using System.ComponentModel.DataAnnotations; 
 
namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Models 

 
{ 
    public class Pabellon {

        [Required] 
        public string IdPab { get; set;} 
        [Required] 
        public string NomPab { get; set;} 
 
        }


}
