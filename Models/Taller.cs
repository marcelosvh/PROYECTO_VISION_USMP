using System;  
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROYECTO_VISION_USMP.Models
{
    public class Taller
    {
        [Key]
        [Required]
        [Display(Name="Codigo de Taller")]
        public string IDTaller { get; set; }
        [ForeignKey("IDTaller")]
        [Display(Name="Nombre de Taller")]
        [Required]
        public string NomTaller { get; set; }
        [Display(Name="Hora de Inicio ")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Time)]
        [Required]
        public DateTime HoraIni { get; set; }
        [Display(Name="Hora de Fin")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Time)]
        [Required]
        public DateTime HoraFin { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        [Required]
        public string Fecha { get; set; }
        public string IDPabellon {get; set;}
        
        public string IDAula { get; set; }
        
        public string IDCarrera { get; set; }
        
        public string IDEvento { get; set; }
        
        public virtual Pabellon CodigoPabellon {get; set;}
        public virtual Aula CodigoAula { get; set;}
        public virtual Carrera CodigoCarrera {get; set;}
        public virtual Evento CodigoEvento {get; set;}
        
    }
}