namespace Jobsee.Domain.General
{
    public partial class PortalEmpleo
    {
        public int NPortalEmpleoId { get; set; }

        public string? CDescripcion { get; set; }

        public string? CUrl { get; set; }

        public DateTime? DFechaCreacion { get; set; }

        public string? CUsuarioCreacion { get; set; }

        public DateTime? DFechaActualización { get; set; }

        public string? CUsuarioActualizacion { get; set; }

        public bool? BActivo { get; set; }

        public virtual ICollection<Empleo> Empleos { get; set; } = new List<Empleo>();

        public virtual ICollection<ProcesoScapping> ProcesoScappings { get; set; } = new List<ProcesoScapping>();
    }
}
