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
            bool result = true;
            var newIngredients = value as List<int>;
            List<Pizza> pizzas = FakeDb.Instance.ListePizzas;

            // answer with link

            //foreach (var pizza in pizzas)
            //{
            //    if (pizza.Ingredients.All(x => newIngredients.Contains(x.Id)))
            //    {
            //        result = false;
            //        break;
            //    }
            //}

            //...
            foreach (var pizza in pizzas) 
            {
                List<Ingredient> ingredients = pizza.Ingredients;

                Boolean checkIsSame = false;
                if (ingredients.Count == newIngredients.Count) 
                {
                    checkIsSame = true;
                    foreach (var ingredient in ingredients)
                    {
                        if (!newIngredients.Contains(ingredient.Id)) 
                        {
                            checkIsSame = false;
                            break;
                        }
                    }
                }

                if (checkIsSame) 
                {
                    result = false;
                    break;
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