using CentroLlamada.Domain;
using CentroLlamada.Domain.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentroLlamada.Infrastructure
{
    public class PacientePersistence : ICrearPaciente, IFiltrarPaciente
    {
        private static IList<Domain.Paciente> Pacientes = new List<Domain.Paciente>();
        public PacientePersistence()
        {

        }

        public Domain.Paciente GetPacienteById(int id)
        {
            var result = Pacientes.Where(it => IsValid(it));
            return (Domain.Paciente)result;
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
