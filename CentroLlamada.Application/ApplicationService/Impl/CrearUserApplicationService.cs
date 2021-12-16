using CentroLlamada.Domain.DomainService;

namespace CentroLlamada.Application.ApplicationService.Impl
{
    public class CrearUserApplicationService : ICreateUserApplicationService
    {
        private readonly ICrearPaciente crearPaciente;

        public CrearUserApplicationService(ICrearPaciente crearPaciente)
        {
            this.crearPaciente = crearPaciente;
        }

        public Domain.Paciente CrearPaciente(Domain.Paciente paciente)
        {
            return crearPaciente.CrearPaciente(paciente);
        }
    }
}
