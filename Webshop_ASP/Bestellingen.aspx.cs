using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webshop_domain.Business;

namespace Webshop_ASP
{
    public partial class Bestellingen : System.Web.UI.Page
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
                Fill_lijstBestellingen();
            }

        }
        private void Fill_lijstBestellingen()
        {
            List<Webshop_domain.Business.Winkelwagen> bestellingen = _controller.getBestellingen();
            lbxWinkelwagens.DataSource = bestellingen;
            lbxWinkelwagens.DataBind();
        }
        protected void btnToonProducten_Click(object sender, EventArgs e)
        {
            List<Winkelwagen_has_Producten> producten = _controller.getProductenVanBestelling(Convert.ToInt32(tbxIDWinkelwagen.Text));
            lbxProducten.DataSource = producten;
            lbxProducten.DataBind();
        }
    }
}