using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webshop_domain.Business;

namespace Webshop_ASP
{
    public partial class _default : System.Web.UI.Page
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
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string gebruikersnaam = tbxGebruikersnaam.Text;
            string paswoord = tbxpaswoord.Text;
            if (gebruikersnaam == "Administrator" && paswoord == "Administrator123")
            {
                Response.Redirect("administratorPage.aspx");
            }
            else
            {
                if (_controller.CheckKlant(gebruikersnaam, paswoord) == true)
                {
                    Response.Redirect("Home.aspx");
                    Response.Write("<script>alert('U bent succesvol ingelogd.');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Ongeldige inloggegevens. Controleer of u uw gegevens correct heeft ingevuld.');</script>");
                }
            }
        }

        protected void btnRegistreren_Click(object sender, EventArgs e)
        {
            Response.Redirect("registreren.aspx");
        }
    }
}