using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TpPizza1.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class IngredientNumber : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = false;
            int n = 0;
            var testItem = value as List<int>;
            foreach (var item in testItem) 
            { 
                n++;
            }
            if(n > 1 && n < 6) 
            {
                result = true;
            }
            return result;
        }

        public override string FormatErrorMessage(string name)
        {
         
            return "Number of ingredients must be between 2 and 5";
        }

    }
}