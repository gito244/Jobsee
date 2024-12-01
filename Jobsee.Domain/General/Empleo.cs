using Jobsee.Domain.Common;

namespace Jobsee.Domain.General
{
    public partial class Empleo : BaseDomainModel
    {
        public int EmpleoId { get; set; }

        public int? EmpresaId { get; set; }

        public int? ModalidadId { get; set; }

        public int? NivelId { get; set; }

        public int? MonedaId { get; set; }

        public int? PortalEmpleoId { get; set; }

        public DateTime? FechaProceso { get; set; }

        public DateTime? FechaPublicacion { get; set; }

        public string? Titulo { get; set; }

        public string? Descripcion { get; set; }

        public string? Funciones { get; set; }

        public string? Requerimientos { get; set; }

        public string? Opcionales { get; set; }

        public string? Beneficios { get; set; }

        public string? Nacionalidad { get; set; }

        public string? RangoSalarial { get; set; }

        public string? Herramientas { get; set; }

        public string? Teconologias { get; set; }

        public string? Url { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string? UsuarioCreacion { get; set; }

        public DateTime? FechaActualización { get; set; }

        public string? UsuarioActualizacion { get; set; }

        public bool? Activo { get; set; }

        public virtual ICollection<LogProcesoScapping> LogProcesoScappings { get; set; } = new List<LogProcesoScapping>();

        public virtual Empresa? Empresa { get; set; }

        public virtual Modalidad? Modalidad { get; set; }

        public virtual Moneda? Moneda { get; set; }

        public virtual Nivel? Nivel { get; set; }

        public virtual PortalEmpleo? PortalEmpleo { get; set; }
    }
}
