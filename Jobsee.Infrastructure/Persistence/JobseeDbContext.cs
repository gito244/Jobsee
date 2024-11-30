using Jobsee.Domain.General;
using Microsoft.EntityFrameworkCore;

namespace Jobsee.Infrastructure.Persistence
{
    public partial class JobseeDbContext : DbContext
    {
        public JobseeDbContext(DbContextOptions<JobseeDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Constante>(entity =>
            {
                entity.HasKey(e => e.NConstanteId).HasName("PK__Constant__351FF53D2D36AFF0");

                entity.ToTable("Constante");

                entity.Property(e => e.NConstanteId).HasColumnName("nConstanteId");
                entity.Property(e => e.BActivo).HasColumnName("bActivo");
                entity.Property(e => e.CDescripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.CTipoVariable)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cTipoVariable");
                entity.Property(e => e.CUsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.CUsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.CValVar)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cValVar");
                entity.Property(e => e.CVariable)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cVariable");
                entity.Property(e => e.DFechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
                entity.Property(e => e.NConstanteValor).HasColumnName("nConstanteValor");
            });

            modelBuilder.Entity<Empleo>(entity =>
            {
                entity.HasKey(e => e.NEmpleoId).HasName("PK__Empleo__8A80347AC3D5D648");

                entity.ToTable("Empleo");

                entity.Property(e => e.NEmpleoId).HasColumnName("nEmpleoId");
                entity.Property(e => e.BActivo).HasColumnName("bActivo");
                entity.Property(e => e.CBeneficios)
                    .IsUnicode(false)
                    .HasColumnName("cBeneficios");
                entity.Property(e => e.CDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.CFunciones)
                    .IsUnicode(false)
                    .HasColumnName("cFunciones");
                entity.Property(e => e.CHerramientas)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cHerramientas");
                entity.Property(e => e.CNacionalidad)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cNacionalidad");
                entity.Property(e => e.COpcionales)
                    .IsUnicode(false)
                    .HasColumnName("cOpcionales");
                entity.Property(e => e.CRangoSalarial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cRangoSalarial");
                entity.Property(e => e.CRequerimientos)
                    .IsUnicode(false)
                    .HasColumnName("cRequerimientos");
                entity.Property(e => e.CTeconologias)
                    .IsUnicode(false)
                    .HasColumnName("cTeconologias");
                entity.Property(e => e.CTitulo)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cTitulo");
                entity.Property(e => e.CUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cUrl");
                entity.Property(e => e.CUsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.CUsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.DFechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
                entity.Property(e => e.DFechaProceso)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaProceso");
                entity.Property(e => e.DFechaPublicacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaPublicacion");
                entity.Property(e => e.NEmpresaId).HasColumnName("nEmpresaId");
                entity.Property(e => e.NModalidadId).HasColumnName("nModalidadId");
                entity.Property(e => e.NMonedaId).HasColumnName("nMonedaId");
                entity.Property(e => e.NNivelId).HasColumnName("nNivelId");
                entity.Property(e => e.NPortalEmpleoId).HasColumnName("nPortalEmpleoId");

                entity.HasOne(d => d.NEmpresa).WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.NEmpresaId)
                    .HasConstraintName("PK_Empleo_Empresa");

                entity.HasOne(d => d.NModalidad).WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.NModalidadId)
                    .HasConstraintName("PK_Empleo_Modalidad");

                entity.HasOne(d => d.NMoneda).WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.NMonedaId)
                    .HasConstraintName("PK_Empleo_Moneda");

                entity.HasOne(d => d.NNivel).WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.NNivelId)
                    .HasConstraintName("PK_Empleo_Nivel");

                entity.HasOne(d => d.NPortalEmpleo).WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.NPortalEmpleoId)
                    .HasConstraintName("PK_Empleo_PortalEmpleo");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.NEmpresaId).HasName("PK__Empresa__F64573CF334CB006");

                entity.ToTable("Empresa");

                entity.Property(e => e.NEmpresaId).HasColumnName("nEmpresaId");
                entity.Property(e => e.BActivo).HasColumnName("bActivo");
                entity.Property(e => e.CDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.CNombre)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cNombre");
                entity.Property(e => e.CUrlLinkedin)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cUrlLinkedin");
                entity.Property(e => e.CUrlWeb)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cUrlWeb");
                entity.Property(e => e.CUsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.CUsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.DFechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
            });

            modelBuilder.Entity<LogProcesoScapping>(entity =>
            {
                entity.HasKey(e => new { e.CLogProcesoScappingId, e.NEmpleoId });

                entity.ToTable("LogProcesoScapping");

                entity.Property(e => e.CLogProcesoScappingId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cLogProcesoScappingId");
                entity.Property(e => e.NEmpleoId).HasColumnName("nEmpleoId");
                entity.Property(e => e.BProcesado).HasColumnName("bProcesado");
                entity.Property(e => e.CDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.CUsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.CUsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.DFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("dFecha");
                entity.Property(e => e.DFechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");

                entity.HasOne(d => d.NEmpleo).WithMany(p => p.LogProcesoScappings)
                    .HasForeignKey(d => d.NEmpleoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogProcesoScapping_Empleo");
            });

            modelBuilder.Entity<Modalidad>(entity =>
            {
                entity.HasKey(e => e.NModalidadId).HasName("PK__Modalida__3BFB9301B3F4AD3A");

                entity.ToTable("Modalidad");

                entity.Property(e => e.NModalidadId).HasColumnName("nModalidadId");
                entity.Property(e => e.BActivo).HasColumnName("bActivo");
                entity.Property(e => e.CDescripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.CUsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.CUsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.DFechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
            });

            modelBuilder.Entity<Moneda>(entity =>
            {
                entity.HasKey(e => e.NMonedaId).HasName("PK__Moneda__BCC4822C9F50B1CA");

                entity.Property(e => e.NMonedaId).HasColumnName("nMonedaId");
                entity.Property(e => e.BActivo).HasColumnName("bActivo");
                entity.Property(e => e.CDescripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.CUsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.CUsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.DFechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
            });

            modelBuilder.Entity<Nivel>(entity =>
            {
                entity.HasKey(e => e.NNivelId).HasName("PK__Nivel__F127DF57F57B722F");

                entity.ToTable("Nivel");

                entity.Property(e => e.NNivelId).HasColumnName("nNivelId");
                entity.Property(e => e.BActivo).HasColumnName("bActivo");
                entity.Property(e => e.CDescripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.CUsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.CUsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.DFechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
            });

            modelBuilder.Entity<PortalEmpleo>(entity =>
            {
                entity.HasKey(e => e.NPortalEmpleoId).HasName("PK__PortalEm__F85CC81A0D3BFF09");

                entity.ToTable("PortalEmpleo");

                entity.Property(e => e.NPortalEmpleoId).HasColumnName("nPortalEmpleoId");
                entity.Property(e => e.BActivo).HasColumnName("bActivo");
                entity.Property(e => e.CDescripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.CUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cUrl");
                entity.Property(e => e.CUsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.CUsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.DFechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
            });

            modelBuilder.Entity<ProcesoScapping>(entity =>
            {
                entity.HasKey(e => e.NProcesoScappingId).HasName("PK__ProcesoS__F45B21801A6CA6E4");

                entity.ToTable("ProcesoScapping");

                entity.Property(e => e.NProcesoScappingId).HasColumnName("nProcesoScappingId");
                entity.Property(e => e.BActivo).HasColumnName("bActivo");
                entity.Property(e => e.CUrlDinamica)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cUrlDinamica");
                entity.Property(e => e.CUsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.CUsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.DFechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
                entity.Property(e => e.NPortalEmpleoId).HasColumnName("nPortalEmpleoId");

                entity.HasOne(d => d.NPortalEmpleo).WithMany(p => p.ProcesoScappings)
                    .HasForeignKey(d => d.NPortalEmpleoId)
                    .HasConstraintName("FK_ProcesoScapping_PortalEmpleo");
            });

            modelBuilder.Entity<ProcesoScappingError>(entity =>
            {
                entity.HasKey(e => e.NProcesoScappingErrorId).HasName("PK__ProcesoS__D497F4BDA071E9EF");

                entity.ToTable("ProcesoScappingError");

                entity.Property(e => e.NProcesoScappingErrorId).HasColumnName("nProcesoScappingErrorId");
                entity.Property(e => e.BActivo).HasColumnName("bActivo");
                entity.Property(e => e.CDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.CLogProcesoScappingId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cLogProcesoScappingId");
                entity.Property(e => e.CUsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.CUsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.DFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("dFecha");
                entity.Property(e => e.DFechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
                entity.Property(e => e.NEmpleoId).HasColumnName("nEmpleoId");

                entity.HasOne(d => d.LogProcesoScapping).WithMany(p => p.ProcesoScappingErrors)
                    .HasForeignKey(d => new { d.CLogProcesoScappingId, d.NEmpleoId })
                    .HasConstraintName("FK_ProcesoScappingError_LogProcesoScapping");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public virtual DbSet<Constante> Constantes { get; set; }

        public virtual DbSet<Empleo> Empleos { get; set; }

        public virtual DbSet<Empresa> Empresas { get; set; }

        public virtual DbSet<LogProcesoScapping> LogProcesoScappings { get; set; }

        public virtual DbSet<Modalidad> Modalidades { get; set; }

        public virtual DbSet<Moneda> Monedas { get; set; }

        public virtual DbSet<Nivel> Niveles { get; set; }

        public virtual DbSet<PortalEmpleo> PortalEmpleos { get; set; }

        public virtual DbSet<ProcesoScapping> ProcesoScappings { get; set; }

        public virtual DbSet<ProcesoScappingError> ProcesoScappingErrors { get; set; }
    }
}