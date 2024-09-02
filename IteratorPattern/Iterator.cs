/******************************************************************************
* Filename    = Iterator.cs
*
* Author      = Mohammad Adnan
*
* Product     = SoftwareDesignPatterns
* 
* Project     = IteratorDesignPattern
*
* Description = Defines an interface for an iterator that provides methods to traverse a collection of Employee objects, including accessing the first element, 
* moving to the next element, and checking if the iteration is complete.
*****************************************************************************/


namespace IteratorDesignPattern
{
    public interface Iterator
    {
        Employee? First(); // Get the first employee
        Employee? Next(); // Get the next employee
        bool IsCompleted { get; } // Check if iteration is complete
    }
}
