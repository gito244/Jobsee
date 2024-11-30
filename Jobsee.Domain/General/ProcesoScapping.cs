namespace Jobsee.Domain.General
{
    public partial class ProcesoScapping
    {
        public int NProcesoScappingId { get; set; }

        public int? NPortalEmpleoId { get; set; }

        public string? CUrlDinamica { get; set; }

        public DateTime? DFechaCreacion { get; set; }

        public string? CUsuarioCreacion { get; set; }

        public DateTime? DFechaActualización { get; set; }

        public string? CUsuarioActualizacion { get; set; }

        public bool? BActivo { get; set; }

        public virtual PortalEmpleo? NPortalEmpleo { get; set; }
    }
}
