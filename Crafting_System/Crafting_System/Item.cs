using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    class Item
    {
        public string Name { get; set; }

        public uint Tier { get; set; }


        public Item(string Name, uint Tier)
        {
            this.Name = Name;
            this.Tier = Tier;
        }
    }
}
