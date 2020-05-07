using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    class Item
    {
        public string title { get; set; }
        public int id { get; set; }
        

        public Dictionary<string,int> stats { get; set; }
        public Item(string title, int id, Dictionary<string, int> stats)
        {
            this.title = title;
            this.id = id;
            this.stats = stats;
        }
    }
}
