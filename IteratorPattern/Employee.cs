/******************************************************************************
* Filename    = Employee.cs
*
* Author      = Mohammad Adnan
*
* Product     = SoftwareDesignPatterns
* 
* Project     = IteratorDesignPattern
*
* Description = Represents an entity with attributes and behaviors related to an employee, such as ID and Name.
*****************************************************************************/

namespace IteratorDesignPattern
{
    public class Employee
    {
        public string Name { get; set; } // Employee's name
        public int ID { get; set; } // Employee's ID

        public Employee(string name, int id)
        {
            Name = name; // Initialize name
            ID = id; // Initialize ID
        }
    }
}
