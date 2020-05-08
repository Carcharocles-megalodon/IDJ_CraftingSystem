using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    class Craft : IComparable
    {
        RecipeManager manager = new RecipeManager();
        
        public bool CompareItems(Item[] item, Recipe recipe)
        {
            foreach(Item Item in item)
            {
                int i = 0;
                if (Item == recipe.RequiredItems[i])
                {
                    return true;
                }
                i++;
                
                
            }
            return false;
        }

        public Item CraftItem(Item[] item, Recipe recipe)
        {
            manager.Add(recipe);
            for (int i = 0; i < item.Length; i++)
            {
                if (CompareItems(item, recipe))
                {
                    return recipe.OutputItem;
                }
                else throw new InvalidOperationException("You can't make this!");
            }
        }
    }
}
