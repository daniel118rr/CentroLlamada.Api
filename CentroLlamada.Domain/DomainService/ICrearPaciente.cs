using System;
using System.Collections.Generic;
using System.Text;

namespace CentroLlamada.Domain.DomainService
{
    public interface ICrearPaciente
    {
        public Paciente CrearPaciente(Paciente paciente);
    }
}
