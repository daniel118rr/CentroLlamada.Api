using Microsoft.AspNetCore.Mvc;
using CentroLlamada.Application.ApplicationService;

namespace CentroLlamada.Api.Controllers
{
    [ApiController]
    [Route("api/paciente")]
    public class PacienteApi : ControllerBase
    {
        private readonly ICreateUserApplicationService createUserApplicationService;

        public PacienteApi(ICreateUserApplicationService createUserApplicationService)
        {
            this.createUserApplicationService = createUserApplicationService;
        }

        [HttpPost]
        public CentroLlamada.Domain.Paciente CrearPaciente(CentroLlamada.Domain.Paciente paciente)
        {
            return createUserApplicationService.CrearPaciente(paciente);
        }
    }
}
