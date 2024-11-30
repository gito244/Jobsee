﻿using Jobsee.Domain.Common;

namespace Jobsee.Domain.Operaciones
{
    public class Persona : BaseDomainModel
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Identificacion { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
    }
}
