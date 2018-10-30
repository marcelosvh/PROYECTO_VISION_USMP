using System;  
using System.ComponentModel.DataAnnotations;



namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Models
{
    public class Taller
    {
        
        public int Idtaller { get; set; }
        [Required]
        public string NomTaller { get; set; }
        [Required]
        public string Hora_ini { get; set; }
        [Required]
        public string Hora_fin { get; set; }
        [Required]
        public string Fecha { get; set; }
        [Required]
        public string Idpab { get; set; }
        [Required]
        public string Idaula { get; set; }
        [Required]
        public string Idcarrera { get; set; }
        [Required]
        public string idevento { get; set; }
    }
}