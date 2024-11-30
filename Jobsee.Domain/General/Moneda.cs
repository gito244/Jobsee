namespace Jobsee.Domain.General
{
    public partial class Moneda
    {
        public int NMonedaId { get; set; }

        public string? CDescripcion { get; set; }

        public DateTime? DFechaCreacion { get; set; }

        public string? CUsuarioCreacion { get; set; }

        public DateTime? DFechaActualización { get; set; }

        public string? CUsuarioActualizacion { get; set; }

        public bool? BActivo { get; set; }

        public virtual ICollection<Empleo> Empleos { get; set; } = new List<Empleo>();
    }
}
