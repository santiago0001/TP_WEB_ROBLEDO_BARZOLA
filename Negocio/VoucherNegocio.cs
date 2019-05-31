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
    public class VoucherNegocio
    {
        public List<Vouchers> listarVoucher()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Vouchers> listado = new List<Vouchers>();
            Vouchers voucher;

            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "select * From Vouchers";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    voucher = new Vouchers();
                    voucher.Id = lector.GetInt64(0);
                    voucher.Codigo = lector.GetString(1);
                    voucher.Estado = lector.GetString(2);


                    //  voucher.Nombre = lector["Nombre"].ToString();
                    //if (!Convert.IsDBNull(lector["Debilidad"]))
                    //    heroe.Debilidad = lector.GetString(2);

                    //if (!Convert.IsDBNull(lector["UsaCapa"]))
                    //    heroe.UsaCapa = (bool)lector["UsaCapa"];

                    //if (!Convert.IsDBNull(lector["Volador"]))
                    //    heroe.Volador = (bool)lector["Volador"];



                    listado.Add(voucher);
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

        public void CargarProductoVoucher(Vouchers modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update vouchers Set idproducto=@idproducto   Where Id=" + modificar.Id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@idproducto", modificar.IdProducto);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
       



    }
}
