using System;
using System.Collections.Generic;

namespace GenericsAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Tom", "Jones");
            Human human2 = new Human("Anna", "Green");
            Human human3 = new Human("Jack", "Smith");
            Human human4 = new Human("Lola", "Jenkins");
            Human human5 = null;

            Animal dog = new Animal("dog");
            Animal cat = new Animal("cat");

            Room<Animal> animalRoom = new Room<Animal>(1, 4);
            animalRoom.AddInhabitant(dog, 0);
            animalRoom.AddInhabitant(cat, 1);

            Console.WriteLine("Animals room...");
            animalRoom.DisplayInhabitants();

            Room<Human> humanRoom = new Room<Human>(1, 4);
            humanRoom.AddInhabitant(human1, 0);
            humanRoom.AddInhabitant(human2, 1);
            humanRoom.AddInhabitant(human3, 2);

            Console.WriteLine("Humans room...");
            humanRoom.DisplayInhabitants();


            DomesticAnimal cow = new DomesticAnimal("cow");
            WildAnimal lion = new WildAnimal("lion");

            animalRoom.AddInhabitant(cow, 2);
            animalRoom.AddInhabitant(lion, 3);

            Console.WriteLine("\nAnimal room after adding domestic and wild animals...");
            animalRoom.DisplayInhabitants();

            Animal cowRef = cow;
            Room<DomesticAnimal> domesticRoom = new Room<DomesticAnimal>(3, 5);
            domesticRoom.AddInhabitant(cow, 0);

            // This will not work...
            //Room<Animal> domAnimalRef = domesticRoom;

            // Ok
            //Animal[] animals = new DomesticAnimal[2];

            //Room<int> intRoom = new Room<int>(5, 888);

            Console.WriteLine("\nCreating Animals list....");
            List<Animal> animals = new List<Animal>();
            animals.Add(lion);
            animals.Add(dog);
            animals.Add(cat);

            Console.WriteLine($"\nPrinting animals in the {nameof(animals)} list...");
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAnimals number in the list...");
            Console.WriteLine(animals.Count);

            List<Animal> animals2 = new List<Animal> { dog, cow };

            Console.WriteLine($"\nPrinting animals in the {nameof(animals2)} list..."); 
            foreach (var item in animals2)
            {
                Console.WriteLine(item);
            }

            Stack<Human> humansStack = new Stack<Human>();
            humansStack.Push(human1);
            humansStack.Push(human2);
            humansStack.Push(human3);
            humansStack.Push(human4);

            Console.WriteLine("\nStack of humans...");
            foreach (var item in humansStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPopped element of stack: " + humansStack.Pop());

            Console.WriteLine("\nStack of humans after Pop()...");
            foreach (var item in humansStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPeek el: " + humansStack.Peek());

            Console.WriteLine("\nStack of humans after Peek()...");
            foreach (var item in humansStack)
            {
                Console.WriteLine(item);
            }

            Queue<Animal> animalsQueue = new Queue<Animal>();
            animalsQueue.Enqueue(cat);
            animalsQueue.Enqueue(lion);
            animalsQueue.Enqueue(dog);
            animalsQueue.Enqueue(cow);

            Console.WriteLine("\nQueue of animals...");
            foreach (var item in animalsQueue)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> numberToStringDict = new Dictionary<int, string>();
            numberToStringDict.Add(1, "One");
            numberToStringDict.Add(2, "Two");
            numberToStringDict.Add(3, "Three");

            Console.WriteLine("\nPrint dictionary key value pairs...");
            foreach (var item in numberToStringDict)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nPrint dictionary...");
            foreach (var item in numberToStringDict)
            {
                Console.WriteLine(item.Key + ": " + item.Value );
            }

            Console.WriteLine("\nPrint KeyCollection...");
            Console.WriteLine(numberToStringDict.Keys);

            Console.WriteLine("\nPrint keys...");
            foreach (var item in numberToStringDict.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nUsing ContainsKey....");
            Console.WriteLine(numberToStringDict.ContainsKey(555));
            Console.WriteLine(numberToStringDict.ContainsKey(3));

            Console.WriteLine("\nGetting the value by the key...");
            Console.WriteLine(numberToStringDict[2]);

            Console.WriteLine("\nCalling a generic method....");
            GenericMethodsProvider.PrintArgumentInfo<int>(3);
            GenericMethodsProvider.PrintArgumentInfo<double>(2.6);
            GenericMethodsProvider.PrintArgumentInfo<string>("Hello");
            GenericMethodsProvider.PrintArgumentInfo("world");

            Console.WriteLine($"\nIs {nameof(human5)} null: {GenericMethodsProvider.IsNull<Human>(human5)}");
            Console.WriteLine($"Is {nameof(human2)} null: {GenericMethodsProvider.IsNull<Human>(human2)}");

            int a = 5;
            int b = 3;
            Console.WriteLine($"Min of {a} and {b}: {GenericMethodsProvider.Min<int>(a, b)}");
            

        }
    }
}
