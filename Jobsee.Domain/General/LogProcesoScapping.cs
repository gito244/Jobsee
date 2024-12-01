using Jobsee.Domain.Common;

namespace Jobsee.Domain.General
{
    public partial class LogProcesoScapping : BaseDomainModel
    {
        public string LogProcesoScappingId { get; set; } = null!;

        public int EmpleoId { get; set; }

        public DateTime? Fecha { get; set; }

        public string? Descripcion { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string? UsuarioCreacion { get; set; }

        public DateTime? FechaActualización { get; set; }

        public string? UsuarioActualizacion { get; set; }

        public bool? Procesado { get; set; }

        public virtual Empleo Empleo { get; set; } = null!;

        public virtual ICollection<ProcesoScappingError> ProcesoScappingErrors { get; set; } = new List<ProcesoScappingError>();
    }
}
