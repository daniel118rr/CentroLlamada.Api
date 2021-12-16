using System;
using System.Collections.Generic;
using System.Text;

namespace CentroLlamada.Domain
{
    public class HistoriaPaciente
    {
        public string NumeroRadicado { get; set; }
        public IEnumerable<EnumDiagnostico> Diagnostico { get; set; }
        public string Descripcion { get; set; }
    }
}
