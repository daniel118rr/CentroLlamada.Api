using CentroLlamada.Domain;
using CentroLlamada.Domain.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentroLlamada.Infrastructure
{
    public class PacientePersistence : ICrearPaciente
    {
        private static IList<Domain.Paciente> Pacientes = new List<Domain.Paciente>();
        public PacientePersistence()
        {

        }

        private bool IsValid(Domain.Paciente paciente)
        {
            return true;
        }

        Domain.Paciente ICrearPaciente.CrearPaciente(Domain.Paciente paciente)
        {
            Pacientes.Add(paciente);
            return paciente;
        }
    }
}
