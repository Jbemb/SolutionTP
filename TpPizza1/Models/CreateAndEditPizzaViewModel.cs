using BODojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TpPizza1.Validation;

namespace TpPizza1.Models
{
    public class CreateAndEditPizzaViewModel
    {
        
        public Pizza Pizza { get; set; }
        public List<Pate> Pates { get; set; } = new List<Pate>();
        [System.ComponentModel.DataAnnotations.Required]
        public int? IdPate { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        [UniqueIngredients]
        [System.ComponentModel.DataAnnotations.Required]
        [IngredientNumber]
        public List<int> IngredientsId { get; set; } = new List<int>();
    }
}
