using Dominio;
using Microsoft.Ajax.Utilities;
using Negocio;
using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Globalization;
using System.Web.UI.WebControls;
using System.Web.SessionState;

namespace Tp_3_WebForm
{
    public partial class ArticuloSeleccionado : System.Web.UI.Page
    {
        public Articulo MostrarArticulo { get; set; }
        public List<Articulo> ListaArticulos { get; set; }

        public List<CarritoCompra> ListaCarro = new List<CarritoCompra>();

        public CarritoCompra Carro = new CarritoCompra();

        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioArticulo NegocioArticulo = new NegocioArticulo();

            if (!IsPostBack)
            {
                TxtCantidad.Text = Convert.ToString(1);
            }

            try
            {
                ListaArticulos = NegocioArticulo.ListaDeArticulos();

                var ArtSelec = Convert.ToInt32(Request.QueryString["Id"]);

                MostrarArticulo = ListaArticulos.Find(J => J.Id == ArtSelec);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void BtnDisminuir_Click(object sender, EventArgs e)
        {
            int GuardarValor = Convert.ToInt32(TxtCantidad.Text);
            int NuevoValor = 0;

            if (GuardarValor >= 2)
            {
                NuevoValor = GuardarValor - 1;

                TxtCantidad.Text = Convert.ToString(NuevoValor);
            }
        }

        protected void BtnAumentar_Click(object sender, EventArgs e)
        {
            int GuardarValor = Convert.ToInt32(TxtCantidad.Text);
            int NuevoValor = 0;

            if (GuardarValor >= 1)
            {
                NuevoValor = GuardarValor + 1;

                TxtCantidad.Text = Convert.ToString(NuevoValor);
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (MostrarArticulo != null)
            {
                Carro.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                Carro.Articulo = MostrarArticulo;

                bool validar = new bool();
                
                if (Session[Session.SessionID + "Lista"] != null)
                {
                    ListaCarro = (List<CarritoCompra>)Session[Session.SessionID + "Lista"];
                }

                foreach (var J in ListaCarro)
                {
                    if (J.Articulo.Id == MostrarArticulo.Id)
                    {
                        //int cant = J.Cantidad + Convert.ToInt32(TxtCantidad.Text);
                        //Carro.Cantidad = cant;
                        //var indice = ListaCarro.FindIndex(K => K.Articulo.Id == Carro.Articulo.Id);
                        //ListaCarro.Insert(indice, Carro);

                        J.Cantidad += Convert.ToInt32(TxtCantidad.Text);
                        ListaCarro.Remove(J);
                        ListaCarro.Add(J);
                        Session[Session.SessionID + "Lista"] = ListaCarro;
                        Response.Redirect("Carrito.aspx");

                        validar = true;
                    }
                    else
                    {
                        validar = false;
                    }
                 
                   
                }

                if(validar == false)
                {
                        ListaCarro.Add(Carro);
                        Session[Session.SessionID + "Lista"] = ListaCarro;
                        Response.Redirect("Carrito.aspx");

                }
            }
        }
    }
}