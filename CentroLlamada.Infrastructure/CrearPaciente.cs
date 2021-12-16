using CentroLlamada.Domain;
using CentroLlamada.Domain.DomainService;
using System;
using System.Collections.Generic;

namespace CentroLlamada.Infrastructure
{
    public class CrearPaciente : ICrearPaciente
    {
        private static IList<Domain.Paciente> Pacientes = new List<Domain.Paciente>();
        public CrearPaciente()
        {

        }
        Domain.Paciente ICrearPaciente.CrearPaciente(Domain.Paciente paciente)
        {
            Pacientes.Add(paciente);
            return paciente;
        }
    }
}
