using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    public class GenericMethodsProvider
    {
        // where T : class => T is reference type
        // where T : struct => T value type
        // where T : <some class or interface> => T is inherited from <some class> or T implements interface
        // where T : new() => T must have a parameterless constructor

        public static void PrintArgumentInfo<T>(T obj) 
        {
            Console.WriteLine($"{obj} is of type {obj.GetType()}");
        }

        public static bool IsNull<T>(T obj) where T : class
        {
            return obj == null;
        }

        public static T Min<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) < 0 ? a : b;
        }
    }
}
