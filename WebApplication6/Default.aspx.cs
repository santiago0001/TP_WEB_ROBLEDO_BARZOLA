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
            int aux = -1;
            VoucherNegocio negocioV = new VoucherNegocio();
            List<Vouchers> lista = negocioV.listarVoucher();
           for(int i = 0; i < lista.Count; i++)

            {                            

                    if (lista[i].Codigo == TextBox1.Text.ToString())
                {
                    aux = i; i = lista.Count;
                }
            }

           if (aux>=0)
            {
                Session["idVoucher"] = lista[aux].Id;

                Response.Redirect("Premios.aspx");
            }
           else
            {
                Response.Redirect("ErrorVoucher.aspx");
            }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}