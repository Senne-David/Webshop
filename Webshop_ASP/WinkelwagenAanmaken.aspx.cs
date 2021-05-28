using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webshop_domain.Business;

namespace Webshop_ASP
{
    public partial class WinkelwagenAanmaken : System.Web.UI.Page
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
                
            }
        }
        string verzendmethode;
        protected void btnBevestigen_Click(object sender, EventArgs e)
        {
            int verzendkosten = 5;
            int status = 0;
            string Datum = tbxDatum.Text;
            string kaartnummer = tbxKaartnummer.Text; 
            _controller.addWinkelwagen(Datum, verzendkosten, kaartnummer, verzendmethode, status);
            Response.Redirect("Home.aspx");
        }
        protected void rbtAfhalen_CheckedChanged(object sender, EventArgs e)
        {
            verzendmethode = "afhalen";
        }

        protected void rbtBezorgen_CheckedChanged(object sender, EventArgs e)
        {
            verzendmethode = "bezorgen";
        }
    }
}