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

        protected void FiltroBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> Filtro;

            try
            {
                if(FiltroBusqueda.Text == "")
                {
                    Filtro = ListaArticulos;
                }

                else
                {
                    Filtro = ListaArticulos.FindAll(J => J.Nombre.ToLower().Contains(FiltroBusqueda.Text.ToLower()));
                    repetidor.DataSource = Filtro;
                    repetidor.DataBind();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}