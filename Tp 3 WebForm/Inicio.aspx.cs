using System;
using Negocio;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_3_WebForm
{
    public partial class _Default : Page
    {
        public List<Articulo> ListaArticulos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                NegocioArticulo NegocioArticulo = new NegocioArticulo();
                ListaArticulos = NegocioArticulo.ListaDeArticulos();

                repetidor.DataSource = ListaArticulos;
                repetidor.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}