using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprog_Lisbeth_Miguel
{
    internal class Pet : Item
    {
        public string AnimalKind { get; set; }
        public Pet(string animalKind) :base(animalKind)
        {
            AnimalKind = animalKind;
        }
    }
}
