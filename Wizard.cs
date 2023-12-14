using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprog_Lisbeth_Miguel
{
    public class Wizard
    {
        public Wizard(string name, string house, string[] inventory)
        {
            Name = name;
            House = house;
            Inventory = inventory;
        }

        public string Name { get; set; }
        public string House { get; set; }
        public string[] Inventory { get; set; }

    }
}
