using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webshop_domain.Business;

namespace Webshop_ASP
{
    public partial class Home : System.Web.UI.Page
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
                fillProductenLijst();
            }
            
        }
        private void fillProductenLijst()
        {
            List<Product> Productenlijst = _controller.getProduct();
            lbxProducten.DataSource = Productenlijst;
            lbxProducten.DataBind();
        }

        

        protected void btnWinkelwagen_Click(object sender, EventArgs e)
        {
            if(_controller.CheckWinkelwagen() == false)
            {
                Response.Redirect("WinkelwagenAanmaken.aspx");
            }
            int aantal = Convert.ToInt32(tbxAantal.Text);
            _controller.addToWinkelwagentje(lbxProducten.SelectedIndex, aantal);
        }

        protected void btnVerlanglijstje_Click(object sender, EventArgs e)
        {
            Response.Redirect("Verlanglijstje.aspx");
        }

        protected void btnaddVerlanglijstje_Click(object sender, EventArgs e)
        {
            _controller.addVerlanglijstje(lbxProducten.SelectedIndex);            
        }

        protected void btnGoToWinkelwagen_Click1(object sender, EventArgs e)
        {
            if (_controller.CheckWinkelwagen() == false)
            {
                Response.Redirect("WinkelwagenAanmaken.aspx");
            }
            Response.Redirect("Winkelwagentje.aspx");
        }
    }
}