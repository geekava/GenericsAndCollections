using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    // where T : class => T is reference type
    // where T : struct => T value type
    // where T : <some class or interface> => T is inherited from <some class> or T implements interface
    // where T : new() => T must have a parameterless constructor

    public class Room<T> 
    {
        public int Number { get; set; }
        public int Capacity { get; set; }

        public T[] Inhabitants { get; set; }

        public Room() { }
        public Room(int number, int capacity)
        {
            Number = number;
            Capacity = capacity;
            Inhabitants = new T[capacity];
        }

        public void AddInhabitant(T inhabitant, int index)
        {
            Inhabitants[index] = inhabitant;
        }

        public void DisplayInhabitants()
        {
            for (int i = 0; i < Inhabitants.Length; i++)
            {
                Console.WriteLine(Inhabitants[i]);
            }
        }
    }
}
