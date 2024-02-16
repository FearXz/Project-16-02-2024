using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Project_16_02_2024
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] != null)
            {
                Cart.Text = "Carrello (" + ((List<Prodotto>)Session["cart"]).Count + ")";
            }
            else
            {
                Cart.Text = "Carrello (0)";
            }
        }

        protected void Cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrello.aspx");
        }
    }
}