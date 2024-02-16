using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_16_02_2024
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Prodotto.listaProdotti.Clear();
                Prodotto p1 = new Prodotto();
                p1.Id = 1;
                p1.UrlImage = "https://resource.logitech.com/content/dam/gaming/en/products/pro-x-keyboard/pro-x-keyboard-gallery-1.png";
                p1.Nome = "Logitech Pro X";
                p1.Descrizione = "Una bella tastiera";
                p1.Prezzo = 154.50;
                Prodotto.listaProdotti.Add(p1);

                Prodotto p2 = new Prodotto();
                p2.Id = 2;
                p2.UrlImage = "https://resource.logitech.com/content/dam/gaming/en/products/pro-x/pro-headset-gallery-1.png";
                p2.Nome = "Logitech Pro X Headset";
                p2.Descrizione = "Un bel headset";
                p2.Prezzo = 145;
                Prodotto.listaProdotti.Add(p2);

                Prodotto p3 = new Prodotto();
                p3.Id = 3;
                p3.UrlImage = "https://resource.logitech.com/content/dam/gaming/en/products/pro-x-superlight/pro-x-superlight-black-gallery-1.png";
                p3.Nome = "Logitech Pro X Wireless";
                p3.Descrizione = "Un bel mouse";
                p3.Prezzo = 164.99;
                Prodotto.listaProdotti.Add(p3);

                Prodotto p4 = new Prodotto();
                p4.Id = 4;
                p4.UrlImage = "https://resource.logitechg.com/w_692,c_lpad,ar_4:3,q_auto,f_auto,dpr_1.0/d_transparent.gif/content/dam/gaming/en/products/g502-lightspeed-gaming-mouse/g502-lightspeed-gallery-1.png?v=1";
                p4.Nome = "G502 Mouse gaming wireless LIGHTSPEED";
                p4.Descrizione = "Il mio mouse";
                p4.Prezzo = 50;
                Prodotto.listaProdotti.Add(p4);

                Prodotto p5 = new Prodotto();
                p5.Id = 5;
                p5.UrlImage = "https://resource.logitech.com/content/dam/gaming/en/products/pro-wireless-gaming-mouse/pro-wireless-carbon-gallery-1.png";
                p5.Nome = "PRO Mouse gaming wireless";
                p5.Descrizione = "Un altro mouse";
                p5.Prezzo = 80.50;
                Prodotto.listaProdotti.Add(p5);


                Repeater1.DataSource = Prodotto.listaProdotti;
                Repeater1.DataBind();
            }
        }

        protected void addToCart_Click(object sender, EventArgs e)
        {
            string idString = ((Button)sender).CommandArgument;
            int id = int.Parse(idString);
            Prodotto productToAdd = Prodotto.ProductSearch(id);

            if (Session["cart"] == null)
            {
                Session["cart"] = new List<Prodotto>();
            }

            List<Prodotto> cart = (List<Prodotto>)Session["cart"];
            cart.Add(productToAdd);
            Session["cart"] = cart;

            Response.Redirect(Request.RawUrl);
        }
    }
}