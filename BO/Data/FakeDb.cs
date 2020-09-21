using BODojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BODojo.Data
{
    public class FakeDb
    {
        private static readonly Lazy<FakeDb> lazy =
           new Lazy<FakeDb>(() => new FakeDb());

        public static FakeDb Instance { get { return lazy.Value; } }

        private FakeDb()
        {

         
            this.ListeIngredients = new List<Ingredient>();
            this.ListePates = new List<Pate>();
            this.ListePizzas = new List<Pizza>();
            this.InitializeData();
        }

        public List<Pizza> ListePizzas { get; set; }

        public List<Ingredient> ListeIngredients { get; private set; }
        public List<Pate> ListePates { get; private set; }

        private void InitializeData()
        {
            ListeIngredients.Add(new Ingredient { Id = 1, Nom = "Mozzarella" });
            ListeIngredients.Add(new Ingredient { Id = 2, Nom = "Jambon" });
            ListeIngredients.Add(new Ingredient { Id = 3, Nom = "Tomate" });
            ListeIngredients.Add(new Ingredient { Id = 4, Nom = "Oignon" });
            ListeIngredients.Add(new Ingredient { Id = 5, Nom = "Cheddar" });
            ListeIngredients.Add(new Ingredient { Id = 6, Nom = "Saumon" });
            ListeIngredients.Add(new Ingredient { Id = 7, Nom = "Champignon" });
            ListeIngredients.Add(new Ingredient { Id = 8, Nom = "Poulet" });

            ListePates.Add(new Pate { Id = 1, Nom = "Pate fine, base crême" });
            ListePates.Add(new Pate { Id = 2, Nom = "Pate fine, base tomate" });
            ListePates.Add(new Pate { Id = 3, Nom = "Pate épaisse, base crême" });
            ListePates.Add(new Pate { Id = 4, Nom = "Pate épaisse, base tomate" });
            
        }

    }
}