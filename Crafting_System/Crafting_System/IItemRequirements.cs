using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    interface IItemRequirements
    {
        public Item RequiredItems { get; set; }
        public List<int> RequiredItemsID { get; set; }
    }
}
