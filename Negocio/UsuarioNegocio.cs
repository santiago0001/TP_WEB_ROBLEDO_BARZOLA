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
   public class UsuarioNegocio
    {
        public int  maximoIDusuario()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "select * From usuarios";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                Usuario us;
                int max = -1;
                while (lector.Read())
                {
                    us = new Usuario();
                    us.Id = lector.GetInt64(0);

                    if (us.Id>max)
                    {
                        max = Convert.ToInt32( us.Id);
                    }
              
                }

                return max;

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



        public void AgregarUsuario(Usuario nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into usuarios (DNI, Nombre, Apellido, Email, Direccion, Ciudad, Codigo_Postal) values";
                comando.CommandText += "(" + nuevo.Dni + ", '" + nuevo.Nombre + "', '" + nuevo.Apellido + "', '" + nuevo.Email + "','" + nuevo.Direccion + "','"+nuevo.Ciudad+ "',"+nuevo.Codigo_Postal+")";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

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

        public void UsuarioXVoucher(Int64 idVoucher, Int64 idusuario)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update vouchers Set idusuario=@idusuario ,estado='B'   Where Id=" + idVoucher.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@idusuario", idusuario);
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
