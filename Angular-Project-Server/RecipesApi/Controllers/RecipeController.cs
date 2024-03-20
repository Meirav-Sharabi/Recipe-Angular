using Microsoft.AspNetCore.Mvc;
using RecipesApi.Entities;

namespace RecipesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController: ControllerBase
    {
        public static List<Recipe> recipes = new List<Recipe>()
        {
            new Recipe("Chocolate", 1, 60, 3, new DateTime(2004,1,1),
                new List<string>() { "eggs", "chocolate", "water", "oil", "cocoa" },
                new List<string>() { "melt chocolate", "Add the rest of the ingredients",
                    "boil in a pot", "to stir", "put in the oven", "eat with pleasure" }, 1, "../../assets/images/saled.jpg")
        };
        [HttpGet]
        public IEnumerable<Recipe> Get()
        {
            return recipes;
        }
        [HttpGet("{id}")]
        public Recipe Get(int id)
        {
            var r = recipes.Find(x => x.codeRecipe == id);
            if(r!=null)
            {
                return r;
            }
            return null;
        }
        [HttpPost]
        public bool Post([FromBody] Recipe r)
        {
            recipes.Add(r);
            return true;
        }
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Recipe value)
        {
            var recipe = recipes.Find(x => x.codeRecipe == id);
            if (recipe != null)
            {
                recipe.codeRecipe = value.codeRecipe;
                recipe.image = value.image;
                recipe.nameRecipe = value.nameRecipe;
                recipe.products = value.products;
                recipe.duration = value.duration;
                recipe.codeCategory = value.codeCategory;
                recipe.date = value.date;
                recipe.degree = value.degree;
                recipe.codeUser = value.codeUser;
                return true;
            }
            return false;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var recipe = recipes.Find(x => x.codeRecipe == id);
            if (recipe != null)
            {
                recipes.Remove(recipe);
                return true;
            }
            return false;
        }
    }

}

