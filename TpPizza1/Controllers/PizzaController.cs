using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TpPizza1.Data;
using TpPizza1.Models;

namespace TpPizza1.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            List<BO.Pizza> pizzaList = FakeDb.Instance.ListePizzas;
            return View(pizzaList);
        }

        // GET: Pizza/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                // TODO: Add insert logic here
                vm.Pizza.Pate = FakeDb.Instance.ListePates.FirstOrDefault(x => x.Id == vm.IdPate);
                foreach (var item in vm.IngredientsId) 
                {
                    vm.Pizza.Ingredients.Add(FakeDb.Instance.ListeIngredients.FirstOrDefault(x => x.Id == item));
                }
        
                FakeDb.Instance.ListePizzas.Add(vm.Pizza);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            CreateAndEditPizzaViewModel vm = new CreateAndEditPizzaViewModel();
            vm.Pizza = FakeDb.Instance.ListePizzas.FirstOrDefault(x => x.Id == vm.IdPate);
            vm.Pates = FakeDb.Instance.ListePates;
            vm.Ingredients = FakeDb.Instance.ListeIngredients;
            return View(vm);
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            Pizza pizza = FakeDb.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);
            return View(pizza);
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
