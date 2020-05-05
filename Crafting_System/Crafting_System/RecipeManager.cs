using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    class RecipeManager
    {
        List<Recipe> recipeList;

        public void Add(Recipe toAdd)
        {
            recipeList.Add(toAdd);
        }
    }
}
