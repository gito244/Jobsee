using MediatR;

namespace Jobsee.Application.Features.Operaciones.Personas.Commands.DeletePersona
{
    public class DeletePersonaCommand : IRequest<int>
    {
        public int PersonaId { get; set; }
    }
}
