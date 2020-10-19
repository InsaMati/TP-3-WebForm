using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_3_WebForm
{
    public partial class SiteMaster : MasterPage
    {
        public int CantidadArticulos = new int();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Session.SessionID + "Cantidad"] != null)
            {
                CantidadArticulos += (int)Session[Session.SessionID + "Cantidad"];
            }
        }
    }
}