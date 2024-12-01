using Jobsee.Application.Features.General.Constantes.Queries.Vms;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsee.Application.Features.General.Constantes.Queries.GetAllConstantesList
{
    public class GetAllConstantesListQuery : IRequest<List<ConstantesWithinIncludesVmResponse>>
    {
    }
}
