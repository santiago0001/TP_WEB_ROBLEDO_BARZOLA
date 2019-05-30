using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
   public class PremioNegocio
    {
        public List<Premio> listarPremios()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Premio> listado = new List<Premio>();
            Premio premio;

            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "select * From productos";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    premio = new Premio();
                    premio.Id = lector.GetInt64(0);
                    premio.Titulo= lector.GetString(1);
                    premio.URL_Imagen = lector.GetString(3);

                    //  voucher.Nombre = lector["Nombre"].ToString();
                    //if (!Convert.IsDBNull(lector["Debilidad"]))
                    //    heroe.Debilidad = lector.GetString(2);

                    //if (!Convert.IsDBNull(lector["UsaCapa"]))
                    //    heroe.UsaCapa = (bool)lector["UsaCapa"];

                    //if (!Convert.IsDBNull(lector["Volador"]))
                    //    heroe.Volador = (bool)lector["Volador"];



                    listado.Add(premio);
                }

                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
