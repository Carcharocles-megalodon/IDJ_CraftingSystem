using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    interface IItemRequirements
    {
        public List<int> RequiredItemsID { get; set; }
        public Item RequiredItems { get; set; }
    }
}
