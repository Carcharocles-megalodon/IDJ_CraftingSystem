using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    
    class Recipe : IItemRequirements, IOutputItems
    {
        public string Name 
        {
            get
            { return Name; } 
            set
            { Name = OutputItems.title + "Recipe"; }
        }
        
        public Item[] RequiredItems { get ; set; }
        public Item OutputItems { get; set; }

        public bool learned = false;
        public Recipe(Item[]RequiredItems, Item OutputItems)
        {
            this.RequiredItems = RequiredItems;
            this.OutputItems = OutputItems;
        }
    }
}
