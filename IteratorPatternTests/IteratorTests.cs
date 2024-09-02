using NUnit.Framework;
using IteratorDesignPattern;

[TestFixture]
public class IteratorTests
{
    private ConcreteCollection _collection;
    private Iterator _iterator;

    [SetUp]
    public void Setup()
    {
        // Arrange: Initialize the collection and add employees
        _collection = new ConcreteCollection();
        _collection.AddEmployee(new Employee("Anurag", 100));
        _collection.AddEmployee(new Employee("Pranaya", 101));
        _collection.AddEmployee(new Employee("Santosh", 102));
        _collection.AddEmployee(new Employee("Priyanka", 103));
        _collection.AddEmployee(new Employee("Abinash", 104));
        _collection.AddEmployee(new Employee("Preety", 105));

        // Create the iterator
        _iterator = _collection.CreateIterator();
    }

    [Test]
    public void Iterator_First_ShouldReturnFirstEmployee()
    {
        // Act: Get the first employee using the iterator
        var firstEmployee = _iterator.First();
        // Assert: Verify that the first employee is correct
        Assert.IsNotNull(firstEmployee, "The first employee should not be null.");
        Assert.That(firstEmployee.ID, Is.EqualTo(100));
        Assert.That(firstEmployee.Name, Is.EqualTo("Anurag"));
    }

    [Test]
    public void Iterator_Next_ShouldIterateOverAllEmployees()
    {
        // Act & Assert: Iterate through all employees and verify
        var employee = _iterator.First();
        Assert.IsNotNull(employee, "The initial employee should not be null.");
        Assert.That(employee.ID, Is.EqualTo(100));
        Assert.That(employee.Name, Is.EqualTo("Anurag"));

        employee = _iterator.Next();
        Assert.IsNotNull(employee, "The next employee should not be null.");
        Assert.That(employee.ID, Is.EqualTo(101));
        Assert.That(employee.Name, Is.EqualTo("Pranaya"));

        employee = _iterator.Next();
        Assert.IsNotNull(employee, "The next employee should not be null.");
        Assert.That(employee.ID, Is.EqualTo(102));
        Assert.That(employee.Name, Is.EqualTo("Santosh"));

        employee = _iterator.Next();
        Assert.IsNotNull(employee, "The next employee should not be null.");
        Assert.That(employee.ID, Is.EqualTo(103));
        Assert.That(employee.Name, Is.EqualTo("Priyanka"));

        employee = _iterator.Next();
        Assert.IsNotNull(employee, "The next employee should not be null.");
        Assert.That(employee.ID, Is.EqualTo(104));
        Assert.That(employee.Name, Is.EqualTo("Abinash"));

        employee = _iterator.Next();
        Assert.IsNotNull(employee, "The next employee should not be null.");
        Assert.That(employee.ID, Is.EqualTo(105));
        Assert.That(employee.Name, Is.EqualTo("Preety"));
    }

    [Test]
    public void Iterator_IsCompleted_ShouldReturnTrueAtEnd()
    {
        // Act: Iterate to the end
        while (!_iterator.IsCompleted)
        {
            _iterator.Next();
        }
        // Assert: Verify that IsCompleted is true at the end
        Assert.That(_iterator.IsCompleted, Is.True);
    }
    [Test]
    public void Iterator_Next_ShouldReturnNullAfterLastEmployee()
    {
        // Act: Iterate through all employees
        Employee? employee = null;
        do
        {
            employee = _iterator.Next();
        } while (employee != null && !_iterator.IsCompleted);
        // Act: Attempt to get the next employee after the last one
        var afterLastEmployee = _iterator.Next();
        // Assert: Verify that the next employee is null
        Assert.IsNull(afterLastEmployee, "The iterator should return null after the last employee.");
    }
    [Test]
    public void GetEmployee_OutOfBoundsIndex_ShouldReturnNull()
    {
        // Act: Try to get an employee with an index that is out of bounds
        var employee = _collection.GetEmployee(_collection.Count); // This should return null because index is equal to Count

        // Assert: Verify that the result is null
        Assert.IsNull(employee, "GetEmployee should return null when the index is out of bounds.");
    }
}
