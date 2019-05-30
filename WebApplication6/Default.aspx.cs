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
    
    public partial class _Default : Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            VoucherNegocio negocioV = new VoucherNegocio();
            List<Vouchers> lista = negocioV.listarVoucher();
           for(int i = 0; i < lista.Count; i++)

            {                            

                    if (lista[i].Codigo == TextBox1.Text.ToString())
                { i = lista.Count; Label1.Text = "SI SE PUEDE";
                }
                else
                {
                    Label1.Text = "NO SE PUEDE";
 }

            }


            //Response.Redirect("Premios.aspx");

        }
    }
}