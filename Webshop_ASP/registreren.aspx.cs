using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webshop_domain.Business;

namespace Webshop_ASP
{
    public partial class registreren : System.Web.UI.Page
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

        protected void btnRegisteren_Click1(object sender, EventArgs e)
        {
            string gebruikersnaam = tbxGebruikersnaam.Text;
            string paswoord = tbxPaswoord.Text;
            string voornaam = tbxVoornaam.Text;
            string achternaam = tbxAchternaam.Text;
            string geboortedatum = tbxGeboortedatum.Text;
            int postcode = Convert.ToInt32(tbxPostcode.Text);
            string straat = tbxStraat.Text;
            int huisnummer = Convert.ToInt32(tbxHuisnummer.Text);
            string email = tbxEmail.Text;
            string telefoon = tbxTelefoonnummer.Text;
            _controller.addKlant(gebruikersnaam, paswoord, voornaam, achternaam, geboortedatum, postcode, straat, huisnummer, email, telefoon);

            
            if (_controller.CheckKlant(gebruikersnaam, paswoord) == true)
            {
                Response.Redirect("WinkelwagenAanmaken.aspx");
                Response.Write("<script>alert('U bent succesvol geregistreerd.');</script>");
            }
            else
            {
                Response.Write("<script>alert('Er is een fout opgetreden, graag opnieuw proberen.');</script>");
            }
        }
    }
}