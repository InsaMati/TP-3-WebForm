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
        public List<Marca> ListaMarca { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioMarca NegocioMarca = new NegocioMarca();

            ListaMarca = NegocioMarca.ListarMarcas();
        }
    }
}