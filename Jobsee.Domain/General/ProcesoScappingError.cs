using Jobsee.Domain.Common;

namespace Jobsee.Domain.General
{
    public partial class ProcesoScappingError : BaseDomainModel
    {
        public int ProcesoScappingErrorId { get; set; }

        public string? LogProcesoScappingId { get; set; }

        public int? EmpleoId { get; set; }

        public DateTime? Fecha { get; set; }

        public string? Descripcion { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string? UsuarioCreacion { get; set; }

        public DateTime? FechaActualización { get; set; }

        public string? UsuarioActualizacion { get; set; }

        public bool? Activo { get; set; }

        public virtual LogProcesoScapping? LogProcesoScapping { get; set; }
    }
}
