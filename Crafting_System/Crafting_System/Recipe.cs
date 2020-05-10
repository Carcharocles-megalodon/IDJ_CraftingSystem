using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    
    class Recipe : IItemRequirements, IOutputItem
    {
        public string Name 
        {
            get
            { return Name; } 
            set
            {}
        }
        
        public List<int> RequiredItemsID { get ; set; }
        public Item[] RequiredItems { get; set; }
        public Item OutputItem { get; set; }
        public int OutputItemID { get; set; }

        public bool learned = false;
        public Recipe(Item [] RequiredItems, Item OutputItem)
        {
            this.RequiredItems = RequiredItems;
            this.OutputItem = OutputItem;
        }
    }
}
