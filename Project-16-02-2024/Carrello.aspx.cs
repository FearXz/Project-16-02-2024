using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Project_16_02_2024
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Recupero la lista dei prodotti dal carrello dalla sessione
            List<Prodotto> cart = (List<Prodotto>)Session["cart"];

            // Controllo se esiste la sessione del carrello
            // Se esiste, mostro i prodotti nel carrello usando il repeater
            if (Session["cart"] != null && cart.Count > 0)
            {
                Repeater1.DataSource = cart;
                Repeater1.DataBind();

                // Calcolo il totale dei prezzi dei prodotti nel carrello
                double totale = 0;
                foreach (Prodotto prodotto in cart)
                {
                    totale += prodotto.Prezzo;
                }
                totaleCarrello.InnerText = "Totale: " + totale + "€";
            }
            // Se non esiste, mostro un messaggio che dice che il carrello è vuoto
            else
            {
                intestazioneCarrello.InnerText = "IL CARRELLO È VUOTO";
            }
        }
        // Metodo per rimuovere un prodotto dal carrello
        // Viene chiamato quando si clicca sul pulsante "Rimuovi dal carrello"
        // Il pulsante ha un CommandArgument che contiene l'id del prodotto da rimuovere
        protected void DeleteFromCart_Click(object sender, EventArgs e)
        {
            string idString = ((Button)sender).CommandArgument;
            int id = int.Parse(idString);

            List<Prodotto> cart = (List<Prodotto>)Session["cart"];

            foreach (Prodotto prodotto in cart)
            {
                if (prodotto.Id == id)
                {
                    cart.Remove(prodotto);
                    break;
                }
            }
            Session["cart"] = cart;
            Response.Redirect(Request.RawUrl);
        }
        // Metodo per svuotare il carrello
        // Viene chiamato quando si clicca sul pulsante "Svuota carrello"
        protected void DeleteAll_Click(object sender, EventArgs e)
        {
            Session["cart"] = null;
            Response.Redirect(Request.RawUrl);
        }
    }
}