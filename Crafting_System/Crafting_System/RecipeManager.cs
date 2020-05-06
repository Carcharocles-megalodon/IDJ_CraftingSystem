using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    class RecipeManager
    {
        public List<Recipe> recipeList { get; set; }

        public void Add(Recipe toAdd)
        {
            recipeList.Add(toAdd);
        }
        public bool IsLearned(Recipe recipe)
        {
            if (recipe.learned != true) return false;
            else return true;
        }
    }
}
