namespace Jobsee.Domain.General
{
    public partial class ProcesoScappingError
    {
        public int NProcesoScappingErrorId { get; set; }

        public string? CLogProcesoScappingId { get; set; }

        public int? NEmpleoId { get; set; }

        public DateTime? DFecha { get; set; }

        public string? CDescripcion { get; set; }

        public DateTime? DFechaCreacion { get; set; }

        public string? CUsuarioCreacion { get; set; }

        public DateTime? DFechaActualización { get; set; }

        public string? CUsuarioActualizacion { get; set; }

        public bool? BActivo { get; set; }

        public virtual LogProcesoScapping? LogProcesoScapping { get; set; }
    }
}
