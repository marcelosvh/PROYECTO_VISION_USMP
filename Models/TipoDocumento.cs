using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PROYECTO_VISION_USMP.Models
{
    public class TipoDocumento
    {
        [Key]
        [Required]
        [Display(Name="Codigo de Tipo de Documento")]
        public string IDTip { get; set; }
        [ForeignKey("IDTip")] 
        [Required]
<<<<<<< HEAD
        public string Tip { get; set; }
=======
        [Display(Name="Descripción de Tipo de Documento")]
        public string DescTip { get; set; }
             
        
>>>>>>> 596c4e5703fb90ccb04c636ec475146f1abf8d76
    }
}