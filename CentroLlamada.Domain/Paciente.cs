using System;
using System.Collections.Generic;

namespace CentroLlamada.Domain
{
    public class Paciente : Entity<string>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
    }
}
