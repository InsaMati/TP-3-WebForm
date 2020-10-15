using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Tp_3_WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<CarritoCompra> ListaCarrito = new List<CarritoCompra>();

        public double Subtotal = new double();

        public int CantidadArticulos = new int();



        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ListaCarrito = (List < CarritoCompra > Session["Lista"]);


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}