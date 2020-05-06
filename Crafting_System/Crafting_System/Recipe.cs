using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    class Recipe
    {
        public Item [] requiredItems { get; set; }



        public Item [] outputItem { get; set; }
        public bool learned = false;
        public Recipe(Item[]requiredItems, Item [] outputItem)
        {
            this.requiredItems = requiredItems;
            this.outputItem = outputItem;
        }
    }
}
