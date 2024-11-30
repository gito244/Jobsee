using Jobsee.Domain.Operaciones;
using MediatR;

namespace Jobsee.Application.Features.Operaciones.Clientes.Commands.CreateCliente
{
    public class CreateClienteCommand : IRequest<int>
    {
        public string Contrasena { get; set; } = string.Empty!;
        public bool Estado { get; set; }
        public Persona? Persona { get; set; }

    }
}
