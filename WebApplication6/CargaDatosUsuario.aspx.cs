using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebApplication6
{ 
    
    public partial class CargaDatosUsuario : System.Web.UI.Page
    {
        Usuario usuarioLocal = new Usuario();
        UsuarioNegocio negocioUS = new UsuarioNegocio();
        int max = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
           max= negocioUS.maximoIDusuario();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!(bool)Session["encontrado"]) {
            usuarioLocal.Nombre = txtNombre.Text;
            usuarioLocal.Apellido = txtApellido.Text;
            usuarioLocal.Dni =Convert.ToInt32( txtDni.Text);
            usuarioLocal.Email = txtEmail.Text;
            usuarioLocal.Direccion = txtDireccion.Text;
            usuarioLocal.Ciudad = txtCiudad.Text;
            usuarioLocal.Codigo_Postal = txtCP.Text;
            negocioUS.AgregarUsuario(usuarioLocal);
            negocioUS.UsuarioXVoucher( (Int64)Session["IdVoucher"], max + 1);
            Response.Redirect("ExitoAgregado.aspx");
            }
            else
            {
                negocioUS.UsuarioXVoucher((Int64)Session["IdVoucher"],Convert.ToInt32( IDlab.Text));
                Response.Redirect("ExitoAgregado.aspx");

            }



        }

        protected void txtDni_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != "") { 
            List<Usuario> dniLocal = negocioUS.BuscarDni(Convert.ToInt32(txtDni.Text));
            
            if (dniLocal.Count > 0) { 
            txtNombre.Text = dniLocal[0].Nombre;
            txtApellido.Text = dniLocal[0].Apellido;
            txtEmail.Text = dniLocal[0].Email;
            txtDireccion.Text = dniLocal[0].Direccion;
            txtCP.Text = dniLocal[0].Codigo_Postal;
            txtCiudad.Text = dniLocal[0].Ciudad;
            IDlab.Text = dniLocal[0].Id.ToString();
           Session["encontrado"] = true;
            }
            }
        }
    }
}