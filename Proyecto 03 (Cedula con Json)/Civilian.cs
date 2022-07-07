using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio
{
    public class Civilian
    {

        public  int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Sangre { get; set; }
        public string LugarNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }

        public DateTime Nacimiento { get; set; }
        public DateTime Expiracion { get; set; }

        public string Telefono { get; set; }

        public string Foto { get; set; }
    }
}
