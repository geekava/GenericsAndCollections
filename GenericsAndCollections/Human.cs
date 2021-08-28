using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    public class Human 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human() { }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}";
        }
    }
}
