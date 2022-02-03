using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    public class Commande
    {
        public Serveur LeServeur { get; private set; }
        public Client LeClient { get; private set; }
        public List<Produit> LesProduits { get; private set; } = new List<Produit>();

        public Commande(Serveur leServeur, Client leClient)
        {
            LeServeur = leServeur;
            LeClient = leClient;
        }

        public void AjouterUnProduit(Produit propro)
        {
            LesProduits.Add(propro);
        }

        public void EnleverUnProduit(Produit propro)
        {
            if (LesProduits.Contains(propro))
            {
                LesProduits.Remove(propro);
            }
        }

        public void AjouterDesProduits(List<Produit> lesPropro)
        {
            foreach (Produit propro in lesPropro)
            {
                LesProduits.Add(propro);
            }
        }

        public void EnleverDesProduits(List<Produit> lesPropro)
        {
            foreach (Produit propro in lesPropro)
            {
                if (LesProduits.Contains(propro))
                {
                    LesProduits.Remove(propro);
                }
            }
        }

        public float ObtenirLaSommeDesProduits()
        {
            float sommeDesProduits = 0;
            foreach (Produit produit in LesProduits)
            {
                sommeDesProduits += produit.Prix;
            }
            return sommeDesProduits;
        }
    }
}
