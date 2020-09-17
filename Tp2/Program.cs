using ProjetLinq.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tp2
{
    class Program
    {


        private static List<Auteur> ListeAuteurs = new List<Auteur>();
        private static List<Livre> ListeLivres = new List<Livre>();

        private static void InitialiserDatas()
        {
            ListeAuteurs.Add(new Auteur("GROUSSARD", "Thierry"));
            ListeAuteurs.Add(new Auteur("GABILLAUD", "Jérôme"));
            ListeAuteurs.Add(new Auteur("HUGON", "Jérôme"));
            ListeAuteurs.Add(new Auteur("ALESSANDRI", "Olivier"));
            ListeAuteurs.Add(new Auteur("de QUAJOUX", "Benoit"));
            ListeLivres.Add(new Livre(1, "C# 4", "Les fondamentaux du langage", ListeAuteurs.ElementAt(0), 533));
            ListeLivres.Add(new Livre(2, "VB.NET", "Les fondamentaux du langage", ListeAuteurs.ElementAt(0), 539));
            ListeLivres.Add(new Livre(3, "SQL Server 2008", "SQL, Transact SQL", ListeAuteurs.ElementAt(1), 311));
            ListeLivres.Add(new Livre(4, "ASP.NET 4.0 et C#", "Sous visual studio 2010", ListeAuteurs.ElementAt(3), 544));
            ListeLivres.Add(new Livre(5, "C# 4", "Développez des applications windows avec visual studio 2010", ListeAuteurs.ElementAt(2), 452));
            ListeLivres.Add(new Livre(6, "Java 7", "les fondamentaux du langage", ListeAuteurs.ElementAt(0), 416));
            ListeLivres.Add(new Livre(7, "SQL et Algèbre relationnelle", "Notions de base", ListeAuteurs.ElementAt(1), 216));
            ListeAuteurs.ElementAt(0).addFacture(new Facture(3500, ListeAuteurs.ElementAt(0)));
            ListeAuteurs.ElementAt(0).addFacture(new Facture(3200, ListeAuteurs.ElementAt(0)));
            ListeAuteurs.ElementAt(1).addFacture(new Facture(4000, ListeAuteurs.ElementAt(1)));
            ListeAuteurs.ElementAt(2).addFacture(new Facture(4200, ListeAuteurs.ElementAt(2)));
            ListeAuteurs.ElementAt(3).addFacture(new Facture(3700, ListeAuteurs.ElementAt(3)));
        }
        static void Main(string[] args)
        {

            InitialiserDatas();

           
            foreach (var item in ListeAuteurs.Where(x => x.Nom.StartsWith("G")))
            {
                Console.WriteLine(item.Prenom);
            }

            //2
            //groups books by author with the most

            //ListeLivres.GroupBy(x => x.Auteur).OrderByDescending(x => x).First().Key.Nom);
            //{

            //    Console.WriteLine(item.Key.Prenom + " " + item.Key.Nom);
            //}

            //Dictionary<Auteur, List<Livre>> booksByAuthor = new Dictionary<Auteur, List<Livre>>(); 
            IGrouping<Auteur, Livre> liste = ListeLivres.GroupBy(x => x.Auteur).OrderByDescending(x => x.Count()).FirstOrDefault();
            Console.WriteLine("Question 2");
                Console.WriteLine(liste.Key.Prenom + " " + liste.Key.Nom);

            Console.WriteLine("Question 3");
            // 3 average pages by livres by author
            foreach (IGrouping<Auteur, Livre> item in ListeLivres.GroupBy(x => x.Auteur))
            {
                Console.WriteLine(item.Average(x => x.NbPages) + " " + item.Key.Nom);
                
                //do only once for the first one
                //.OrderByDescending(x => x)
                //Console.WriteLine(item.Key.Prenom + " " + item.Key.Nom);
            }
            Console.WriteLine("Question 4");
            // 4 Afficher le titre du livre avec le plus de pages
            Console.WriteLine(ListeLivres.OrderByDescending(x => x.NbPages).First().Titre);

            //5 Afficher combien ont gagné les auteurs en moyenne(moyenne des factures)
            //class1s.SelectMany(x => x.MyProperty)
            //foreach (var item in ListeAuteurs.SelectMany(x => x.Factures)) 
            //{ 

            //}
            Console.WriteLine("Question 6");
            //6 Afficher les auteurs et la liste de leurs livres
            foreach (IGrouping<Auteur, Livre> item in ListeLivres.GroupBy(x => x.Auteur)) 
            {
                Console.WriteLine(item.Key.Nom + ", " + item.Key.Prenom);
                foreach (var subitem in item)
                {
                    Console.WriteLine(subitem.Titre);
                }
                Console.WriteLine("/////////////");
            }
            Console.WriteLine("Question 7");
            // 7 Afficher les titres de tous les livres triés par ordre alphabétique
            foreach (var item in ListeLivres.OrderBy(x => x.Titre))
            {
                Console.WriteLine(item.Titre);
            }
            Console.WriteLine("Question 8");
            // 8 Afficher la liste des livres dont le nombre de pagesest supérieurà la moyenne
            Console.WriteLine("Afficher la liste des livres dont le nombre de pagesest supérieurà la moyenne");
            double average = ListeLivres.Average(x => x.NbPages);
            foreach (var item in ListeLivres.Where(n => n.NbPages > average))
            {
        
                Console.WriteLine(item.Titre + " " + item.NbPages);
            }

            // 9 Afficher l'auteur ayant écrit le moins de livres


            Console.ReadKey();

        }
    }
}
