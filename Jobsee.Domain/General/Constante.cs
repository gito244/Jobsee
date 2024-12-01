using Jobsee.Domain.Common;

namespace Jobsee.Domain.General
{
    public partial class Constante : BaseDomainModel
    {
        public int ConstanteId { get; set; }

        public int ConstanteValor { get; set; }

        public string? Variable { get; set; }

        public string? Descripcion { get; set; }

        public string? TipoVariable { get; set; }

        public string? ValVar { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string? UsuarioCreacion { get; set; }

        public DateTime? FechaActualización { get; set; }

        public string? UsuarioActualizacion { get; set; }

        public bool? Activo { get; set; }
    }
}
