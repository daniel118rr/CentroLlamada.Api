using System;
using System.Collections.Generic;
using System.Text;

namespace CentroLlamada.Domain.DomainService
{
    public interface IFiltrarPaciente
    {
        public Paciente GetPacienteById(int id);
    }
}
