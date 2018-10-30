using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace Models.MvcContext
{
    public class MvcContext: DbContext{
        public MvcContext(DbContextOptions<MvcContext> options) : base(options){

        }

        public DbSet<PROYECTO_APP_VISION_VISUAL_STUDIO.Models.RequisitosTaller> RequisitosTaller{get; set;}

        public DbSet<PROYECTO_APP_VISION_VISUAL_STUDIO.Models.Taller> Taller{get; set;}
         
        public DbSet<PROYECTO_APP_VISION_VISUAL_STUDIO.Models.TipoDocumento> TipoDocumento{get; set;}

        
    }


}
