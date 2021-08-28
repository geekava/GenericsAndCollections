using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    public class WildAnimal : Animal
    {
        public WildAnimal()
        {
        }

        public WildAnimal(string name) : base(name)
        {
        }
    }
}
