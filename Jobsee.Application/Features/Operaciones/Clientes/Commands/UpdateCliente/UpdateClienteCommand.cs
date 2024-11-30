using Jobsee.Application.Features.Operaciones.Personas.Commands.CreatePersona;
using Jobsee.Domain.Operaciones;
using MediatR;

namespace Jobsee.Application.Features.Operaciones.Clientes.Commands.UpdateCliente
{
    public class UpdateClienteCommand : IRequest<int>
    {
        public int ClienteId { get; set; }
        public int PersonaId { get; set; }
        public string Contrasena { get; set; } = string.Empty;
        public bool Estado { get; set; }
        //public CreatePersonaCommand? Persona { get; set; }
        public Persona? persona { get; set; }
    }
}
