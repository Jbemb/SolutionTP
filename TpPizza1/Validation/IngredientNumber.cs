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
        private int min;
        private int max;

        public IngredientNumber(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public override bool IsValid(object value)
        {
            //add vairables and constructor with the variables to be able to pass the min and max in the annotation
            bool result = false;
            var testItem = value as List<int>;
            //use count function instead
           if(testItem.Count() >= this.min && testItem.Count() <= this.max) 
            {
                result = true;
            }
            return result;
        }

        public override string FormatErrorMessage(string name)
        {

            return $"You must have between {this.min} and {this.max} ingredients";
        }

    }
}