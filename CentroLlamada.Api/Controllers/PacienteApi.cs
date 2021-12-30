using Microsoft.AspNetCore.Mvc;
using CentroLlamada.Application.ApplicationService;
using CentroLlamada.Domain;

namespace CentroLlamada.Api.Controllers
{
    [ApiController]
    [Route("api/paciente")]
    public class PacienteApi : BaseController<CentroLlamada.Domain.Paciente, string>
    {
        public PacienteApi(ICrudService<CentroLlamada.Domain.Paciente, string> crudService) : base(crudService)
        {
        }
    }
}
