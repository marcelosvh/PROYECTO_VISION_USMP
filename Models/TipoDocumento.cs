using System;  
using System.ComponentModel.DataAnnotations;



namespace PROYECTO_APP_VISION_VISUAL_STUDIO.Models
{
    public class TipoDocumento
    {
        
        public string Idtip { get; set; }
        [Required]
        public string Tip { get; set; }
    }
}