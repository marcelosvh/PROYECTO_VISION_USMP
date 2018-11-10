using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROYECTO_VISION_USMP.Models;

    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExpTipDoc>()
            .HasKey(c => new { c.IDTip, c. IDExpositor });
            modelBuilder.Entity<PabAula>()
            .HasKey(c => new { c.IDPabellon, c. IDAula });
            modelBuilder.Entity<RequisitosConferencia>()
            .HasKey(c => new { c.IDExpositor, c. IDConferencia });
            modelBuilder.Entity<RequisitosTaller>()
            .HasKey(c => new { c.IDExpositor, c. IDTaller });

    }

        public DbSet<PROYECTO_VISION_USMP.Models.Alumno> Alumno { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.Aula> Aula { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.Carrera> Carrera { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.Conferencia> Conferencia { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.Empresa> Empresa { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.Evento> Evento { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.Expositor> Expositor { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.ExpTipDoc> ExpTipDoc { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.PabAula> PabAula { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.Pabellon> Pabellon { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.RequisitosConferencia> RequisitosConferencia { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.RequisitosTaller> RequisitosTaller { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.Taller> Taller { get; set; }

        public DbSet<PROYECTO_VISION_USMP.Models.TipoDocumento> TipoDocumento { get; set; }
    }
