using System;  
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROYECTO_APP_VISION_VISUAL_STUDIO {
    public class Conferencia {
         [Key]
        [Required]
        [Display(Name="Codigo de Conferencia")]
        public string IDConferencia { get; set; }
        [ForeignKey("IDConferencia")]
        [Display(Name="Nombre de Conferencia")]
        [Required]
        public string NomConferencia { get; set; }
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