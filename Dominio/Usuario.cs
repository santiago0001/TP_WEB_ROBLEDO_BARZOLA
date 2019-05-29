using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Int32 Dni { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Codigo_Postal { get; set; }
        public DateTime Fecha_Registro { get; set; }



    }
}
