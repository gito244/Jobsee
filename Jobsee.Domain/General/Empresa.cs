namespace Jobsee.Domain.General
{
    public partial class Empresa
    {
        public int NEmpresaId { get; set; }

        public string? CNombre { get; set; }

        public string? CDescripcion { get; set; }

        public string? CUrlWeb { get; set; }

        public string? CUrlLinkedin { get; set; }

        public DateTime? DFechaCreacion { get; set; }

        public string? CUsuarioCreacion { get; set; }

        public DateTime? DFechaActualización { get; set; }

        public string? CUsuarioActualizacion { get; set; }

        public bool? BActivo { get; set; }

        public virtual ICollection<Empleo> Empleos { get; set; } = new List<Empleo>();
    }
}
