using Jobsee.Domain.Common;

namespace Jobsee.Domain.General
{
    public partial class Modalidad : BaseDomainModel
    {
        public int ModalidadId { get; set; }

        public string? Descripcion { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string? UsuarioCreacion { get; set; }

        public DateTime? FechaActualización { get; set; }

        public string? UsuarioActualizacion { get; set; }

        public bool? Activo { get; set; }

        public virtual ICollection<Empleo> Empleos { get; set; } = new List<Empleo>();
    }
}
