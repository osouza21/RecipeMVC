using JustRecipe.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace JustRecipe.DAL
{
    public class RecipeContext: DbContext
    {
        public RecipeContext() : base("RecipeContext")
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipePart> RecipeParts { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}