namespace Jobsee.Domain.General
{
    public partial class Constante
    {
        public int NConstanteId { get; set; }

        public int NConstanteValor { get; set; }

        public string? CVariable { get; set; }

        public string? CDescripcion { get; set; }

        public string? CTipoVariable { get; set; }

        public string? CValVar { get; set; }

        public DateTime? DFechaCreacion { get; set; }

        public string? CUsuarioCreacion { get; set; }

        public DateTime? DFechaActualización { get; set; }

        public string? CUsuarioActualizacion { get; set; }

        public bool? BActivo { get; set; }
    }
}
