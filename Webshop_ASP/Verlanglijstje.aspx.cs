using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webshop_domain.Business;

namespace Webshop_ASP
{
    public partial class Verlanglijstje : System.Web.UI.Page
    {
        private Controller _controller;
        protected void Page_Load(object sender, EventArgs e)
        {
            _controller = new Controller();
            if (IsPostBack)
            {
                _controller = (Controller)HttpContext.Current.Session["_controller"];
            }
            else
            {
                if (HttpContext.Current.Session["_controller"] == null)
                {
                    _controller = new Controller();
                    HttpContext.Current.Session["_controller"] = _controller;
                }
                else
                {
                    _controller = (Controller)HttpContext.Current.Session["_controller"];
                }
                fillVerlanglijstje();
            }
        }
        private void fillVerlanglijstje()
        {
            List<Verlanglijst> Verlanglijst = _controller.getVerlanglijstje();
            lbxVerlanglijstje.DataSource = Verlanglijst;
            lbxVerlanglijstje.DataBind();
        }

        protected void btnDeleteFromList_Click(object sender, EventArgs e)
        {
            _controller.DeleteItemFromVerlanglijst(lbxVerlanglijstje.SelectedIndex);
            fillVerlanglijstje();
        }
    }
}