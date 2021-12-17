using System;
using System.Collections.Generic;
using System.Text;

namespace CentroLlamada.Domain
{
    public class CentroMedico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
    }
}
