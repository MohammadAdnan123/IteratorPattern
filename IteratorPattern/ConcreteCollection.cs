/******************************************************************************
* Filename    = ConcreteCollection.cs
*
* Author      = Mohammad Adnan
*
* Product     = SoftwareDesignPatterns
* 
* Project     = IteratorDesignPattern
*
* Description = Concrete implementation of a collection that supports adding Employee, checking count, etc.
*****************************************************************************/

namespace IteratorDesignPattern
{
    public class ConcreteCollection : IAbstractCollection
    {
        private List<Employee> _employees = new List<Employee>(); // List to hold employees

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee); // Add employee to collection
        }

        public int Count
        {
            get { return _employees.Count; } // Get number of employees
        }

        public Employee? GetEmployee(int index)
        {
            // Return employee at index or null if out of bounds
            return index < _employees.Count ? _employees[index] : null;
        }

        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this); // Create and return iterator
        }
    }
}
