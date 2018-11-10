using System;  
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using PROYECTO_APP_VISION_VISUAL_STUDIO;

namespace PROYECTO_VISION_USMP.Models
{

    public class Alumno
    {

        [Key]
        [Required]
        
        [Display(Name="DNI de Alumno")]
        public string DNI {get; set;}
        [Required]
        [Display(Name="Apellido Paterno")]
        
        public string ApePat {get; set;}
        [Required]
        [Display(Name="Apellido Materno")]
        public string ApeMat {get; set;}
        [Required]
        [Display(Name="Nombre del Alumno")]
        public string NomAlumno {get; set;}
        [Required]
        [EmailAddress]
        [Display(Name="Correo del Alumno")]
        public string CorreoAlum {get; set;}
        [Required]
        public int Celular {get; set;}
        [Display(Name="Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        public DateTime FechaNac { get; set; }
        public string IDCarrera {get; set;}
        public virtual Carrera CodigoCarrera {get; set;}

    }
    
}