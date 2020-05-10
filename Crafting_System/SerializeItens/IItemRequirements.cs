using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    interface IItemRequirements
    {
        public List<int> RequiredItems { get; set; }
    }
}
