using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webshop_domain.Business;

namespace Webshop_ASP
{
    public partial class administratorPage : System.Web.UI.Page
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
                FillProductenlijst();
            }

        }
        private void FillProductenlijst()
        {
            List<Product> productlijst = _controller.getProduct();
            lbxProducten.DataSource = productlijst;
            lbxProducten.DataBind();
        }
        private void ClearBoxes()
        {
            tbxNaam.Text = "";
            tbxCategorie.Text = "";
            tbxOmschrijving.Text = "";
            tbxPrijs.Text = "";
        }
        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product nieuwproduct = new Product(
                tbxNaam.Text, tbxCategorie.Text, tbxOmschrijving.Text, Convert.ToDouble(tbxPrijs.Text));
            _controller.addProduct(nieuwproduct);
            FillProductenlijst();
            ClearBoxes();
        }

        protected void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            _controller.DeleteProductFromList(lbxProducten.SelectedIndex);
        }

        protected void btnKlanten_Click(object sender, EventArgs e)
        {
            Response.Redirect("KlantenLijst.aspx");
        }

        protected void btnWinkelwagens_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bestellingen.aspx");
        }
    }
}