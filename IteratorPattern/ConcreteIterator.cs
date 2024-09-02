/******************************************************************************
* Filename    = ConcreteIterator.cs
*
* Author      = Mohammad Adnan
*
* Product     = SoftwareDesignPatterns
* 
* Project     = IteratorDesignPattern
*
* Description = Specific implementation of an iterator that provides the functionality to traverse and access elements within a ConcreteCollection.
*****************************************************************************/
namespace IteratorDesignPattern
{
    public class ConcreteIterator : Iterator
    {
        private readonly ConcreteCollection _collection; // Collection to iterate over
        private int _currentIndex = 0; // Current position in the collection

        public ConcreteIterator(ConcreteCollection collection)
        {
            _collection = collection; // Initialize with the collection
        }

        public Employee? First()
        {
            _currentIndex = 0; // Reset index to start
            return _collection.GetEmployee(_currentIndex); // Return first employee
        }

        public Employee? Next()
        {
            _currentIndex++; // Move to the next index
            // Return employee at current index or null if completed
            return !IsCompleted ? _collection.GetEmployee(_currentIndex) : null;
        }

        public bool IsCompleted
        {
            get { return _currentIndex >= _collection.Count; } // Check if end is reached
        }
    }
}
