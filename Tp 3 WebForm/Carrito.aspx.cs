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
           
            
            ListaCarrito = (List < CarritoCompra >) Session[Session.SessionID + "Lista"];

            if(ListaCarrito != null)
            {
                var Eliminar = Request.QueryString["ID"];

                if (Eliminar != null)
                {
                    CarritoCompra vaciado = ListaCarrito.Find(j => j.Articulo.Id == int.Parse(Eliminar));
                    ListaCarrito.Remove(vaciado);
                    Session[Session.SessionID + "Lista"] = ListaCarrito;
                }





            }

           
        }

        protected void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                if(ListaCarrito != null)
                {
                    ListaCarrito.Clear();
                    Session[Session.SessionID + "Lista"] = ListaCarrito;
                    Response.Redirect("Carrito.aspx");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}