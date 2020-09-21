using BODojo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BODojo.Data;

namespace BODojo.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class PizzaUnique : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = true;
            //foreach in pizza list
            String test = null;
            List<Pizza> pizzas = FakeDb.Instance.ListePizzas;
            foreach (var item in pizzas) 
            {
                test = item.Nom;
                if (value.ToString().Equals(test))
                {
                    result = false;
                    break;
                }

            }

            return result;
        }

        public override string FormatErrorMessage(string name)
        {
            return "This pizza name is taken";
        }
    }
}