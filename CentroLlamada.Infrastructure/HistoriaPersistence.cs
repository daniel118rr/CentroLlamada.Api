using CentroLlamada.Domain;
using CentroLlamada.Domain.DomainService;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentroLlamada.Infrastructure
{
    class HistoriaPersistence : ICrearHistoria
    {
        private static IList<Domain.HistoriaPaciente> Historias = new List<Domain.HistoriaPaciente>();
        public HistoriaPersistence()
        {

        }

        public HistoriaPaciente CrearHistoria(HistoriaPaciente historia)
        {
            Historias.Add(historia);
            return historia;
        }
    }
}
