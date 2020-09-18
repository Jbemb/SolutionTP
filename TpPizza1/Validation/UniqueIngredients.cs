using BO;
using BO.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TpPizza1.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UniqueIngredients : ValidationAttribute

    {

        public override bool IsValid(object value)
        {
            bool result = false;
            var newIngredients = value as List<int>;
            List<Pizza> pizzas = FakeDb.Instance.ListePizzas;


            //...
            foreach (var pizza in pizzas) 
            {
                List<Ingredient> ingredients = pizza.Ingredients;

                foreach (var ingredient in ingredients) 
                { 
                
                }
            }

            return result;
        }

        public override string FormatErrorMessage(string name)
        {

            return "A pizza with the same ingredients already exists";
        }
    }
}