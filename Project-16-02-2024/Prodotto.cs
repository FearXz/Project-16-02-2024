using System.Collections.Generic;

namespace Project_16_02_2024
{
    public class Prodotto
    {
        private int _id;
        public int Id { get => _id; set => _id = value; }

        private string _nome;
        public string Nome { get => _nome; set => _nome = value; }

        private string _descrizione;
        public string Descrizione { get => _descrizione; set => _descrizione = value; }

        private string _urlImage;
        public string UrlImage { get => _urlImage; set => _urlImage = value; }

        private double _prezzo;
        public double Prezzo { get => _prezzo; set => _prezzo = value; }


        public static List<Prodotto> listaProdotti = new List<Prodotto>();

        public static Prodotto ProductSearch(int id)
        {
            Prodotto foundProduct = null;

            foreach (var prodotto in listaProdotti)
            {
                if (prodotto.Id == id)
                {
                    foundProduct = prodotto;
                }
            }
            return foundProduct;
        }

    }
}