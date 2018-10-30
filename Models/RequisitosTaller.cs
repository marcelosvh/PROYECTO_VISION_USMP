using System;  
using System.ComponentModel.DataAnnotations;



namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Models
{
    public class RequisitosTaller
    {
        
        public string Idexp { get; set; }
        [Required]
        public string Apepat { get; set; }
        [Required]
        public string Apemat { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Idtal { get; set; }
        [Required]
        public string NomTaller { get; set; }
        [Required]
        public string Reqtal { get; set; }

    }
}