using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Procesos.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public string Doctor { get; set; }
        public string EmailDoctor { get; set; }
        public string Paciente { get; set; }
        public string EmailPaciente { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
    }
}
