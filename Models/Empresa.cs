using System;  
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using PROYECTO_VISION_USMP.Models;

namespace PROYECTO_APP_VISION_VISUAL_STUDIO {
    public class Empresa {
         [Key]
        [Required]
        [Display(Name="Codigo de Empresa")]
        public string IDEmpresa { get; set;}
        [Required]
        [Display(Name="Codigo de Empresa")]
        public string NomEmpresa { get; set;}
        [Required]
        [Display(Name="Correo de Empresa")]
        [EmailAddress]
        public string CorreoEmpresa {get; set;}
        [Required]
        public string Pais {get; set;}
        [Required]
        public int Telefono { get; set;}
        public ICollection<Expositor> Expositores {get;set;}
    }
}