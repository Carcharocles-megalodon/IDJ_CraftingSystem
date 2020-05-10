using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    class Item
    {
        public string Title { get; set; }
        public int Id { get; set; }
        

        //public Dictionary<string,int> stats { get; set; }
        public Item(string title, int id)// Dictionary<string, int> stats)
        {
            this.Title = Title;
            this.Id = Id;
            //this.stats = stats;
        }

        public Item()
        {
        }
    }
}
