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
    public partial class VoucherGrilla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VoucherNegocio VoucherNegocio = new VoucherNegocio();
            List<Vouchers> lista = VoucherNegocio.listarVoucher();
            GridView1.DataSource = lista;
            GridView1.DataBind();
        }
    }
}