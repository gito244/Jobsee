namespace Jobsee.Domain.General
{
    public partial class LogProcesoScapping
    {
        public string CLogProcesoScappingId { get; set; } = null!;

        public int NEmpleoId { get; set; }

        public DateTime? DFecha { get; set; }

        public string? CDescripcion { get; set; }

        public DateTime? DFechaCreacion { get; set; }

        public string? CUsuarioCreacion { get; set; }

        public DateTime? DFechaActualización { get; set; }

        public string? CUsuarioActualizacion { get; set; }

        public bool? BProcesado { get; set; }

        public virtual Empleo NEmpleo { get; set; } = null!;

        public virtual ICollection<ProcesoScappingError> ProcesoScappingErrors { get; set; } = new List<ProcesoScappingError>();
    }
}
