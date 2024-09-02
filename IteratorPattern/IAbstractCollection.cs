/******************************************************************************
* Filename    = IAbstractCollection.cs
*
* Author      = Mohammad Adnan
*
* Product     = SoftwareDesignPatterns
* 
* Project     = IteratorDesignPattern
*
* Description = Defines an interface for a collection that provides a method to create an iterator, enabling traversal of its elements.
*****************************************************************************/

namespace IteratorDesignPattern
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator(); // Method to create an iterator for the collection
    }
}
