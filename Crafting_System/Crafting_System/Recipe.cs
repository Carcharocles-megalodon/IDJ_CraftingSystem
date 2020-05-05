using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    class Recipe
    {
        Item [] requiredItems;
        Item outputItem;
        bool learned = false;
        public Recipe(Item[]requiredItems, Item outputItem)
        {
            this.requiredItems = requiredItems;
            this.outputItem = outputItem;
        }
    }
}
