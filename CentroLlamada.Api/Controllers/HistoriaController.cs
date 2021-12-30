using CentroLlamada.Application.ApplicationService;
using CentroLlamada.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CentroLlamada.Api.Controllers
{
    [ApiController]
    [Route("api/historiaPaciente")]
    public class HistoriaController : BaseController<CentroLlamada.Domain.HistoriaPaciente, string>
    {
        public HistoriaController(ICrudService<CentroLlamada.Domain.HistoriaPaciente, string> crudService) : base(crudService)
        {
        }

        [HttpGet]
        [Route("getByPacienteId/{id}")]
        public List<HistoriaPaciente> GetByPacienteId(string id)
        {
            return crudService.FindByExpression(x => x.PacienteId == id).ToList();
        }
    }
}
