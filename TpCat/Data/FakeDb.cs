using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TpCat.Models;

namespace TpCat.Data
{
    public class FakeDb
    {
        private static readonly Lazy<FakeDb> lazy =
           new Lazy<FakeDb>(() => new FakeDb());

        public static FakeDb Instance { get { return lazy.Value; } }

        private FakeDb()
        {
           
            this.ListeChats = new List<Chat>();
            this.InitializeData();

        }

        public List<Chat> ListeChats { get; private set; }

        public void InitializeData()
        {
            var i = 1;
            ListeChats.Add(new Chat { Id = i++, Nom = "Felix", Age = 3, Couleur = "Roux" });
            ListeChats.Add(new Chat { Id = i++, Nom = "Minette", Age = 1, Couleur = "Noire" });
            ListeChats.Add(new Chat { Id = i++, Nom = "Miss", Age = 10, Couleur = "Blanche" });
            ListeChats.Add(new Chat { Id = i++, Nom = "Garfield", Age = 6, Couleur = "Gris" });
            ListeChats.Add(new Chat { Id = i++, Nom = "Chatran", Age = 4, Couleur = "Fauve" });
            ListeChats.Add(new Chat { Id = i++, Nom = "Minou", Age = 2, Couleur = "Blanc" });
            ListeChats.Add(new Chat { Id = i, Nom = "Bichette", Age = 12, Couleur = "Rousse" });   
            
        }
    }
}