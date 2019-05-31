using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vouchers
    {
        public Int64 Id { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public Int64 IdUsuario { get; set; }
        public Int64 IdProducto { get; set; }
        public DateTime Fecha_Registro { get; set; }

    }
}

