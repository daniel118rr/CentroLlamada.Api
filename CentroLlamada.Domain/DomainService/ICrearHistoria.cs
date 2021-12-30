using System;
using System.Collections.Generic;
using System.Text;

namespace CentroLlamada.Domain.DomainService
{
    public interface ICrearHistoria
    {
        public HistoriaPaciente CrearHistoria(HistoriaPaciente historia);
    }
}
