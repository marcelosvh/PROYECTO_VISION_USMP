using System;  
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace PROYECTO_VISION_USMP.Models

{
    public class Expositor
    {
        [Key]
        [Required]
        [Display(Name="Codigo de Expositor")]
        public string IDExpositor {get; set;}
        [ForeignKey("IDExpositor")]
        [Required]
        [Display(Name="Apellido Paterno")]
        
        public string ApePat {get; set;}
        [Required]
        [Display(Name="Apellido Materno")]
        
        public string ApeMat {get; set;}
        [Required]
        [Display(Name="Nombre del Expositor")]
        public string NomExp {get; set;}
        [Required]
        public string Nacionalidad {get; set;}
        [Required]
        [Display(Name="Tipo de Orador")]
        public string TipoOrador {get; set;}
        [Required]
        [EmailAddress]
        [Display(Name="Correo del Expositor")]
        public string CorreoExp {get; set;}
        [Required]
        [MinLength(1), MaxLength(1), ]
        public int Orden {get; set;}
        public string IDEmpresa { get; set;}
        public virtual Empresa CodigoEmpresa {get; set;}
            
    }
}