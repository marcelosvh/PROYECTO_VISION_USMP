using System;   
 
using System.ComponentModel.DataAnnotations; 
 
namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Models 

 
{ 
    public class Requisitos_Conferencia
 
    { 
        [Required] 
        public string IdExp { get; set; } 
        [Required] 
        public string ApePat { get; set; } 
          [Required] 
        public string ApeMat { get; set; } 
          [Required] 
        public string Nom { get; set; } 
          [Required] 
        public string IdConfe { get; set; } 
          [Required] 
        public string Confe{ get; set; } 
          [Required] 
        public string DesReqConfe { get; set; } 


        }


}
