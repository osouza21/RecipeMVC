
using JustRecipe.Models;
using System.Collections.Generic;

namespace JustRecipe.DAL
{
    public class RecipeInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<RecipeContext>
    {
        protected override void Seed(RecipeContext context)
        {
            var recipes = new List<Recipe>()
            {
                new Recipe{Name="Chicken and Rice"},
                new Recipe{Name="Chicken and Potatoes" },
                new Recipe{Name="Beans and Rice" },
                new Recipe{Name="Pork and Beans" }
            };

            recipes.ForEach(r => context.Recipes.Add(r));
            context.SaveChanges();

            var ingredients = new List<Ingredient>()
            {
                new Ingredient{Name="Chicken"},
                new Ingredient{Name="Rice" },
                new Ingredient{Name="Potatoes" },
                new Ingredient{Name="Beans" },
                new Ingredient{Name="Pork" }
            };

            ingredients.ForEach(i => context.Ingredients.Add(i));
            context.SaveChanges();

            var recipeParts = new List<RecipePart>
            {
                //Chicken
                new RecipePart{IngredientID=1, RecipeID=1, Quantity=1 },
                new RecipePart{IngredientID=1, RecipeID=2, Quantity=1 },
                //Rice
                new RecipePart{IngredientID=2, RecipeID=1, Quantity=2 },
                new RecipePart{IngredientID=2, RecipeID=3, Quantity=3 },
                //Potatoe
                new RecipePart{IngredientID=3, RecipeID=2, Quantity=5 },
                //Beans
                new RecipePart{IngredientID=4, RecipeID=3, Quantity=10 },
                new RecipePart{IngredientID=4, RecipeID=4, Quantity=10 },
                //Pork
                new RecipePart{IngredientID=5, RecipeID=4, Quantity=1 }
            };

            recipeParts.ForEach(rp => context.RecipeParts.Add(rp));
            context.SaveChanges();
        }
    }
}