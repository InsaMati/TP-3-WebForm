using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_3_WebForm
{
    public partial class ArticuloSeleccionado : System.Web.UI.Page
    {
        public Articulo MostrarArticulo { get; set; }
        public List<Articulo> ListaArticulos { get; set; }

        public List<Carrito> ListaCarro = new List<Carrito>();

        public Carrito Carro = new Carrito();

        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioArticulo NegocioArticulo = new NegocioArticulo();

            if (!IsPostBack)
            {
                //////
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

        }

        protected void BtnAumentar_Click(object sender, EventArgs e)
        {

        }
    }
}