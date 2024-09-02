using System;

namespace IteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize the collection
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Employee("Anurag", 100));
            collection.AddEmployee(new Employee("Pranaya", 101));
            collection.AddEmployee(new Employee("Santosh", 102));
            collection.AddEmployee(new Employee("Priyanka", 103));
            collection.AddEmployee(new Employee("Abinash", 104));
            collection.AddEmployee(new Employee("Preety", 105));

            // Create the iterator
            Iterator iterator = collection.CreateIterator();

            // Iterate through the collection
            Console.WriteLine("Iterating over collection:");

            for (Employee? emp = iterator.First(); emp != null && !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}");
            }

            Console.ReadLine(); // Keep console window open
        }
    }
}
