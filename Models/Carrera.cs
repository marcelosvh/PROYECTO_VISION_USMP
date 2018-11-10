using System;

namespace PROYECTO_APP_VISION_VISUAL_STUDIO {
    public class Carrera {
       [Key]
        [Required]
        [Display(Name="Codigo de Carrera")]
        
        public string IDCarrera {get; set;}
        [Display(Name="Nombre de Carrera")]
        [Required]
        public string NomCarrera { get; set;}
        public ICollection<Taller> Talleres {get; set;}
        public ICollection<Alumno> Alumnos {get; set;}
        public ICollection<Conferencia> Conferencias {get; set;}
    }

}