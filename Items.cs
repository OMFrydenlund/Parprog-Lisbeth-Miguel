﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprog_Lisbeth_Miguel
{
    internal class Item
    {
         public string IdentifyItem { get; set; }
        public Item(string identifyItem)
        {
                IdentifyItem = identifyItem;
        }
    }
}