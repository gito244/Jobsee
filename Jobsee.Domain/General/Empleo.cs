namespace Jobsee.Domain.General
{
    public partial class Empleo
    {
        public int NEmpleoId { get; set; }

        public int? NEmpresaId { get; set; }

        public int? NModalidadId { get; set; }

        public int? NNivelId { get; set; }

        public int? NMonedaId { get; set; }

        public int? NPortalEmpleoId { get; set; }

        public DateTime? DFechaProceso { get; set; }

        public DateTime? DFechaPublicacion { get; set; }

        public string? CTitulo { get; set; }

        public string? CDescripcion { get; set; }

        public string? CFunciones { get; set; }

        public string? CRequerimientos { get; set; }

        public string? COpcionales { get; set; }

        public string? CBeneficios { get; set; }

        public string? CNacionalidad { get; set; }

        public string? CRangoSalarial { get; set; }

        public string? CHerramientas { get; set; }

        public string? CTeconologias { get; set; }

        public string? CUrl { get; set; }

        public DateTime? DFechaCreacion { get; set; }

        public string? CUsuarioCreacion { get; set; }

        public DateTime? DFechaActualización { get; set; }

        public string? CUsuarioActualizacion { get; set; }

        public bool? BActivo { get; set; }

        public virtual ICollection<LogProcesoScapping> LogProcesoScappings { get; set; } = new List<LogProcesoScapping>();

        public virtual Empresa? NEmpresa { get; set; }

        public virtual Modalidad? NModalidad { get; set; }

        public virtual Moneda? NMoneda { get; set; }

        public virtual Nivel? NNivel { get; set; }

        public virtual PortalEmpleo? NPortalEmpleo { get; set; }
    }
}
