using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsee.Application.Features.General.Constantes.Queries.Vms
{
    public class ConstantesWithinIncludesVmResponse
    {

        public int ConstanteId { get; set; }
        public int ConstanteValor { get; set; }

        public string? Variable { get; set; }

        public string? Descripcion { get; set; }

        public string? TipoVariable { get; set; }

        public string? ValVar { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string? UsuarioCreacion { get; set; }

        public bool? Activo { get; set; }
    }
}
