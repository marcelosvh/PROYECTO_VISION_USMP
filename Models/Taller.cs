using System;  
using System.ComponentModel.DataAnnotations;



namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Models
{
    public class Taller
    {
        [Required]
        public string Idtaller { get; set; }
        [Required]
        public string NomTaller { get; set; }
        [Required]
        public string Horaini { get; set; }
        [Required]
        public string Horafin { get; set; }
        [Required]
        public string Fecha { get; set; }
        [Required]
        public string Idaula { get; set; }
        [Required]
        public string Idcar { get; set; }
        [Required]
        public string Ideve { get; set; }
    }
}