using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal() { }

        public Animal(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Animal: {Name} ";
        }
    }
}
