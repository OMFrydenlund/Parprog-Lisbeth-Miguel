using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprog_Lisbeth_Miguel
{
    internal class Wand : Item
    {
        public string StickProduct {  get; set; }
        public Wand(string stickProduct) : base(stickProduct)
        {
            StickProduct = stickProduct;
        }
    }
}
