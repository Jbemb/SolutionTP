using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpPizza1.Data
{
    public class FakeDb
    {
        private static readonly Lazy<FakeDb> lazy =
           new Lazy<FakeDb>(() => new FakeDb());

        public static FakeDb Instance { get { return lazy.Value; } }

        private FakeDb()
        {

         
            this.ListeIngredients = new List<BO.Ingredient>();
            this.ListePates = new List<BO.Pate>();
            this.ListePizzas = new List<BO.Pizza>();
            this.InitializeData();
        }

        public List<BO.Pizza> ListePizzas { get; set; }

        public List<BO.Ingredient> ListeIngredients { get; private set; }
        public List<BO.Pate> ListePates { get; private set; }

        private void InitializeData()
        {
            ListeIngredients.Add(new BO.Ingredient { Id = 1, Nom = "Mozzarella" });
            ListeIngredients.Add(new BO.Ingredient { Id = 2, Nom = "Jambon" });
            ListeIngredients.Add(new BO.Ingredient { Id = 3, Nom = "Tomate" });
            ListeIngredients.Add(new BO.Ingredient { Id = 4, Nom = "Oignon" });
            ListeIngredients.Add(new BO.Ingredient { Id = 5, Nom = "Cheddar" });
            ListeIngredients.Add(new BO.Ingredient { Id = 6, Nom = "Saumon" });
            ListeIngredients.Add(new BO.Ingredient { Id = 7, Nom = "Champignon" });
            ListeIngredients.Add(new BO.Ingredient { Id = 8, Nom = "Poulet" });

            ListePates.Add(new BO.Pate { Id = 1, Nom = "Pate fine, base crême" });
            ListePates.Add(new BO.Pate { Id = 2, Nom = "Pate fine, base tomate" });
            ListePates.Add(new BO.Pate { Id = 3, Nom = "Pate épaisse, base crême" });
            ListePates.Add(new BO.Pate { Id = 4, Nom = "Pate épaisse, base tomate" });
            
        }

    }
}