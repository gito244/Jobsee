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
                entity.HasKey(e => e.ConstanteId).HasName("PK__Constant__351FF53D2D36AFF0");

                entity.ToTable("Constante");

                entity.Property(e => e.ConstanteId).HasColumnName("nConstanteId");
                entity.Property(e => e.Activo).HasColumnName("bActivo");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.TipoVariable)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cTipoVariable");
                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.ValVar)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cValVar");
                entity.Property(e => e.Variable)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cVariable");
                entity.Property(e => e.FechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
                entity.Property(e => e.ConstanteValor).HasColumnName("nConstanteValor");
            });

            modelBuilder.Entity<Empleo>(entity =>
            {
                entity.HasKey(e => e.EmpleoId).HasName("PK__Empleo__8A80347AC3D5D648");

                entity.ToTable("Empleo");

                entity.Property(e => e.EmpleoId).HasColumnName("nEmpleoId");
                entity.Property(e => e.Activo).HasColumnName("bActivo");
                entity.Property(e => e.Beneficios)
                    .IsUnicode(false)
                    .HasColumnName("cBeneficios");
                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.Funciones)
                    .IsUnicode(false)
                    .HasColumnName("cFunciones");
                entity.Property(e => e.Herramientas)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cHerramientas");
                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cNacionalidad");
                entity.Property(e => e.Opcionales)
                    .IsUnicode(false)
                    .HasColumnName("cOpcionales");
                entity.Property(e => e.RangoSalarial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cRangoSalarial");
                entity.Property(e => e.Requerimientos)
                    .IsUnicode(false)
                    .HasColumnName("cRequerimientos");
                entity.Property(e => e.Teconologias)
                    .IsUnicode(false)
                    .HasColumnName("cTeconologias");
                entity.Property(e => e.Titulo)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cTitulo");
                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cUrl");
                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.FechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
                entity.Property(e => e.FechaProceso)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaProceso");
                entity.Property(e => e.FechaPublicacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaPublicacion");
                entity.Property(e => e.EmpresaId).HasColumnName("nEmpresaId");
                entity.Property(e => e.ModalidadId).HasColumnName("nModalidadId");
                entity.Property(e => e.MonedaId).HasColumnName("nMonedaId");
                entity.Property(e => e.NivelId).HasColumnName("nNivelId");
                entity.Property(e => e.PortalEmpleoId).HasColumnName("nPortalEmpleoId");

                entity.HasOne(d => d.Empresa).WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.EmpresaId)
                    .HasConstraintName("PK_Empleo_Empresa");

                entity.HasOne(d => d.Modalidad).WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.ModalidadId)
                    .HasConstraintName("PK_Empleo_Modalidad");

                entity.HasOne(d => d.Moneda).WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.MonedaId)
                    .HasConstraintName("PK_Empleo_Moneda");

                entity.HasOne(d => d.Nivel).WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.NivelId)
                    .HasConstraintName("PK_Empleo_Nivel");

                entity.HasOne(d => d.PortalEmpleo).WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.PortalEmpleoId)
                    .HasConstraintName("PK_Empleo_PortalEmpleo");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.EmpresaId).HasName("PK__Empresa__F64573CF334CB006");

                entity.ToTable("Empresa");

                entity.Property(e => e.EmpresaId).HasColumnName("nEmpresaId");
                entity.Property(e => e.Activo).HasColumnName("bActivo");
                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cNombre");
                entity.Property(e => e.UrlLinkedin)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cUrlLinkedin");
                entity.Property(e => e.UrlWeb)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cUrlWeb");
                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.FechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
            });

            modelBuilder.Entity<LogProcesoScapping>(entity =>
            {
                entity.HasKey(e => new { e.LogProcesoScappingId, e.EmpleoId });

                entity.ToTable("LogProcesoScapping");

                entity.Property(e => e.LogProcesoScappingId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cLogProcesoScappingId");
                entity.Property(e => e.EmpleoId).HasColumnName("nEmpleoId");
                entity.Property(e => e.Procesado).HasColumnName("bProcesado");
                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("dFecha");
                entity.Property(e => e.FechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");

                entity.HasOne(d => d.Empleo).WithMany(p => p.LogProcesoScappings)
                    .HasForeignKey(d => d.EmpleoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogProcesoScapping_Empleo");
            });

            modelBuilder.Entity<Modalidad>(entity =>
            {
                entity.HasKey(e => e.ModalidadId).HasName("PK__Modalida__3BFB9301B3F4AD3A");

                entity.ToTable("Modalidad");

                entity.Property(e => e.ModalidadId).HasColumnName("nModalidadId");
                entity.Property(e => e.Activo).HasColumnName("bActivo");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.FechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
            });

            modelBuilder.Entity<Moneda>(entity =>
            {
                entity.HasKey(e => e.MonedaId).HasName("PK__Moneda__BCC4822C9F50B1CA");

                entity.Property(e => e.MonedaId).HasColumnName("nMonedaId");
                entity.Property(e => e.Activo).HasColumnName("bActivo");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.FechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
            });

            modelBuilder.Entity<Nivel>(entity =>
            {
                entity.HasKey(e => e.NivelId).HasName("PK__Nivel__F127DF57F57B722F");

                entity.ToTable("Nivel");

                entity.Property(e => e.NivelId).HasColumnName("nNivelId");
                entity.Property(e => e.Activo).HasColumnName("bActivo");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.FechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
            });

            modelBuilder.Entity<PortalEmpleo>(entity =>
            {
                entity.HasKey(e => e.PortalEmpleoId).HasName("PK__PortalEm__F85CC81A0D3BFF09");

                entity.ToTable("PortalEmpleo");

                entity.Property(e => e.PortalEmpleoId).HasColumnName("nPortalEmpleoId");
                entity.Property(e => e.Activo).HasColumnName("bActivo");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cUrl");
                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.FechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
            });

            modelBuilder.Entity<ProcesoScapping>(entity =>
            {
                entity.HasKey(e => e.ProcesoScappingId).HasName("PK__ProcesoS__F45B21801A6CA6E4");

                entity.ToTable("ProcesoScapping");

                entity.Property(e => e.ProcesoScappingId).HasColumnName("nProcesoScappingId");
                entity.Property(e => e.Activo).HasColumnName("bActivo");
                entity.Property(e => e.UrlDinamica)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cUrlDinamica");
                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.FechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
                entity.Property(e => e.PortalEmpleoId).HasColumnName("nPortalEmpleoId");

                entity.HasOne(d => d.PortalEmpleo).WithMany(p => p.ProcesoScappings)
                    .HasForeignKey(d => d.PortalEmpleoId)
                    .HasConstraintName("FK_ProcesoScapping_PortalEmpleo");
            });

            modelBuilder.Entity<ProcesoScappingError>(entity =>
            {
                entity.HasKey(e => e.ProcesoScappingErrorId).HasName("PK__ProcesoS__D497F4BDA071E9EF");

                entity.ToTable("ProcesoScappingError");

                entity.Property(e => e.ProcesoScappingErrorId).HasColumnName("nProcesoScappingErrorId");
                entity.Property(e => e.Activo).HasColumnName("bActivo");
                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("cDescripcion");
                entity.Property(e => e.LogProcesoScappingId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cLogProcesoScappingId");
                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioActualizacion");
                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cUsuarioCreacion");
                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("dFecha");
                entity.Property(e => e.FechaActualización)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaActualización");
                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("dFechaCreacion");
                entity.Property(e => e.EmpleoId).HasColumnName("nEmpleoId");

                entity.HasOne(d => d.LogProcesoScapping).WithMany(p => p.ProcesoScappingErrors)
                    .HasForeignKey(d => new { d.LogProcesoScappingId, d.EmpleoId })
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