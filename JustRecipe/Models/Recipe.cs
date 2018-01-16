using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustRecipe.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Ingrediant> Ingrediants { get; set; }
    }
}