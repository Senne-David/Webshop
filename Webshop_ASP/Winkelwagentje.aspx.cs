using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webshop_domain.Business;

namespace Webshop_ASP
{
    public partial class Winkelwagen : System.Web.UI.Page
    {
        Controller _controller;
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
               
                fillWinkelwagenLijst();
                GetTotaal();
            }

        }
        private void fillWinkelwagenLijst()
        {
            List<Winkelwagen_has_Producten> winkelwagenKlant = _controller.getWinkelwagenHasProducten();
            lbxWinkelwagen.DataSource = winkelwagenKlant;
            lbxWinkelwagen.DataBind();
        }
        private void GetTotaal()
        {
            double totaalprijs = _controller.getTotaal();
            lblTotaal.Text = Convert.ToString(Math.Round(totaalprijs, 2));
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _controller.DeleteItemFromWinkelwagen_Has_Producten(lbxWinkelwagen.SelectedIndex);
            fillWinkelwagenLijst();
        }

        protected void btnAfrekenen_Click(object sender, EventArgs e)
        {
            _controller.UpdateActieveWinkelwagen();
            Response.Redirect("WinkelwagenAanmaken.aspx");
        }
    }
}