using System;
using System.Collections.Generic;
using System.Text;

namespace CentroLlamada.Domain
{
    public class HistoriaPaciente : Entity<string>
    {
        public string PacienteId { get; set; }
        public string NumeroRadicado { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public string Descripcion { get; set; }
    }
}
