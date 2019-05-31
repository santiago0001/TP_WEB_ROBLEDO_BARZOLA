using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebApplication6
{
    public partial class Contact : Page
    {
        Vouchers VoucherLocal = new Vouchers();
        VoucherNegocio negoVou = new VoucherNegocio();

        PremioNegocio premioNegocio = new PremioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Premio> listaVoucher = premioNegocio.listarPremios();
            Image1.ImageUrl = listaVoucher[0].URL_Imagen.ToString();
             Image2.ImageUrl = listaVoucher[1].URL_Imagen.ToString();
             Image3.ImageUrl = listaVoucher[2].URL_Imagen.ToString();

            VoucherLocal.Id = (Int64) Session["IdVoucher"];
            Session["encontrado"] = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            VoucherLocal.IdProducto = 1;
            
            negoVou.CargarProductoVoucher(VoucherLocal);

            Response.Redirect("CargaDatosUsuario.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            VoucherLocal.IdProducto = 2;

            negoVou.CargarProductoVoucher(VoucherLocal);

            Response.Redirect("CargaDatosUsuario.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            VoucherLocal.IdProducto = 3;

            negoVou.CargarProductoVoucher(VoucherLocal);

            Response.Redirect("CargaDatosUsuario.aspx");

        }
    }
}