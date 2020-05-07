using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    class Craft
    {
        RecipeManager manager = new RecipeManager();
        public void CraftItem(Item[]item, Recipe recipe)
        {
            manager.Add(recipe);
            for(int i = 0; i < item.Length; i++)
            {
                if (item[i] == recipe.requiredItems[i])
                {
                    
                }
            }
        }
    }
}
