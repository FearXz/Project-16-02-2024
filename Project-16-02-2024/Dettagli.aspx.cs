using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Project_16_02_2024
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IdProdotto"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            string idString = Request.QueryString["IdProdotto"];
            int id = int.Parse(idString);
            Prodotto product = Prodotto.ProductSearch(id);
            image.Src = product.UrlImage;
            titolo.InnerText = product.Nome;
            descrizione.InnerText = product.Descrizione;
            prezzo.InnerText = product.Prezzo.ToString("0.00 €");
            addToCart.CommandArgument = product.Id.ToString();

        }

        protected void addToCart_Click(object sender, EventArgs e)
        {
            string idString = ((Button)sender).CommandArgument;
            int id = int.Parse(idString);
            Prodotto productToAdd = Prodotto.ProductSearch(id);
            if (Session["cart"] == null)
            {
                Session["cart"] = new List<Prodotto>();
                List<Prodotto> cart = (List<Prodotto>)Session["cart"];
                cart.Add(productToAdd);
                Session["cart"] = cart;
            }
            else
            {
                List<Prodotto> cart = (List<Prodotto>)Session["cart"];
                cart.Add(productToAdd);
                Session["cart"] = cart;
            }
            Response.Redirect(Request.RawUrl);
        }
    }
}