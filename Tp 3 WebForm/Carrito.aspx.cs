using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Antlr.Runtime.Misc;
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

                    CantidadArticulos += vaciado.Cantidad;
                    CantidadArticulos = CantidadArticulos - vaciado.Cantidad;

                    Session[Session.SessionID + "Cantidad"] = CantidadArticulos;

                }

                foreach (var Aux in ListaCarrito)
                {
                    CantidadArticulos += Aux.Cantidad;
                    Session[Session.SessionID + "Cantidad"] = CantidadArticulos;

                    if (Session[Session.SessionID + "Cantidad"] != null)
                    {
                        CantidadArticulos = (int)Session[Session.SessionID + "Cantidad"];
                    }

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
                    CantidadArticulos = 0;

                    Session[Session.SessionID + "Lista"] = ListaCarrito;
                    Session[Session.SessionID + "Cantidad"] = CantidadArticulos;

                    Response.Redirect("Carrito.aspx");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("Inicio.aspx");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}