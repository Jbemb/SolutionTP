using BODojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BODojo.Data;
using TpPizza1.Models;

namespace TpPizza1.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            List<Pizza> pizzaList = FakeDb.Instance.ListePizzas;
            return View(pizzaList);
        }

        // GET: Pizza/Details/5
        public ActionResult Details(int id)
        {
            CreateAndEditPizzaViewModel vm = new CreateAndEditPizzaViewModel();
            Pizza pizza = FakeDb.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);
            vm.Pizza = pizza;
            return View(vm);
            
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {
            CreateAndEditPizzaViewModel vm = new CreateAndEditPizzaViewModel();
            vm.Pates = FakeDb.Instance.ListePates;
            vm.Ingredients = FakeDb.Instance.ListeIngredients;
            return View(vm);
        }

        // POST: Pizza/Create
        [HttpPost]
        public ActionResult Create(CreateAndEditPizzaViewModel vm)
        {
            try
            {
                Pizza pizza = vm.Pizza;
                pizza.Pate = FakeDb.Instance.ListePates.FirstOrDefault(x => x.Id == vm.IdPate);
                foreach (var item in vm.IngredientsId)
                {
                    pizza.Ingredients.Add(BODojo.Data.FakeDb.Instance.ListeIngredients.FirstOrDefault(x => x.Id == item));
                }
                //for refractioning
                if (ModelState.IsValid)
                {
                    
                    // TODO: Add insert logic here
                    
                    pizza.Id = FakeDb.Instance.ListePizzas.Count == 0 ? 1 : FakeDb.Instance.ListePizzas.Max(x => x.Id) + 1;

                    FakeDb.Instance.ListePizzas.Add(pizza);

                    return RedirectToAction("Index");
                }
                else 
                {
                 
                    vm.Pates = FakeDb.Instance.ListePates;
                    vm.Ingredients = FakeDb.Instance.ListeIngredients;
                    return View(vm);
                }
                
            }
            catch
            {
                vm.Pates = FakeDb.Instance.ListePates;
                vm.Ingredients = FakeDb.Instance.ListeIngredients;
                return View(vm);
            }
        }

        private bool ValidateVM(CreateAndEditPizzaViewModel vm)
        {
            bool result = true;
            return result;
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            CreateAndEditPizzaViewModel vm = new CreateAndEditPizzaViewModel();
            vm.Pizza = FakeDb.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);
            vm.Pates = FakeDb.Instance.ListePates;
            vm.Ingredients = FakeDb.Instance.ListeIngredients;

            if (vm.Pizza.Pate != null) 
            {
                vm.IdPate = vm.Pizza.Pate.Id;
            }

            if (vm.Pizza.Ingredients.Any())
            {
                
                vm.IngredientsId = vm.Pizza.Ingredients.Select(x=> x.Id).ToList();
            }
            return View(vm);
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        public ActionResult Edit(CreateAndEditPizzaViewModel vm)
        {
            try
            {
                // TODO: Add update logic here
                Pizza pizza = FakeDb.Instance.ListePizzas.FirstOrDefault(x => x.Id == vm.Pizza.Id);
                pizza.Nom = vm.Pizza.Nom;
                pizza.Pate = FakeDb.Instance.ListePates.FirstOrDefault(x => x.Id == vm.IdPate);
                pizza.Ingredients = FakeDb.Instance.ListeIngredients.Where(x => vm.IngredientsId.Contains(x.Id)).ToList();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            CreateAndEditPizzaViewModel vm = new CreateAndEditPizzaViewModel();
            Pizza pizza = FakeDb.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);
            vm.Pizza = pizza;
            return View(vm);
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Pizza pizza = FakeDb.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);
                FakeDb.Instance.ListePizzas.Remove(pizza);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
