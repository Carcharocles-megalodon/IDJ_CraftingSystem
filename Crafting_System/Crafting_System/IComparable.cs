﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting_System
{
    interface IComparable
    {
        bool CompareItems(Item[] item, Recipe recipe);
    }
}
