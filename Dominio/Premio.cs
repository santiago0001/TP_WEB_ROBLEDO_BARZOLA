using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Premio
    {
        public Int64 Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string URL_Imagen { get; set; }
        public Char Estado { get; set; }
        public DateTime Fecha_Registro { get; set; }

    }
}
