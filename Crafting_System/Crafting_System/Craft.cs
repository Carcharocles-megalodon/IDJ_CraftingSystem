using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    class Craft
    {
        public void CraftItem(Item[]item, Recipe recipe)
        {
            for(int i = 0; i < item.Length; i++)
            {
                if (item[i] == recipe.requiredItems[i])
                {
                    
                }
            }
        }
    }
}
