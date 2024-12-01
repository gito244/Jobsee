using Jobsee.Domain.Common;

namespace Jobsee.Domain.General
{
    public partial class ProcesoScapping : BaseDomainModel
    {
        public int ProcesoScappingId { get; set; }

        public int? PortalEmpleoId { get; set; }

        public string? UrlDinamica { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string? UsuarioCreacion { get; set; }

        public DateTime? FechaActualización { get; set; }

        public string? UsuarioActualizacion { get; set; }

        public bool? Activo { get; set; }

        public virtual PortalEmpleo? PortalEmpleo { get; set; }
    }
}
