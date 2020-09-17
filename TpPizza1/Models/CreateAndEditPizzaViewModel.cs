using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpPizza1.Models
{
    public class CreateAndEditPizzaViewModel
    {
        public Pizza Pizza { get; set; }
        public List<Pate> Pates { get; set; }
        public int IdPate { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public List<int> IngredientsId { get; set; }
    }
}
