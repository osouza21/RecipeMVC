using System.Collections.Generic;

namespace JustRecipe.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RecipePart> RecipeParts { get; set; }
    }
}