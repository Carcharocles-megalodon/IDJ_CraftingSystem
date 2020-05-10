using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    interface IOutputItem
    {
        public Item OutputItem { get; set; }
        public int OutputItemID { get; set; }
    }
}
