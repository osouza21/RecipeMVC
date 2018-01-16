
namespace JustRecipe.Models
{
    public class RecipePart
    {
        public int ID { get; set; }
        public int IngredientID { get; set; }
        public int RecipeID { get; set; }
        public decimal Quantity { get; set; }

        public virtual Recipe Recipe { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}