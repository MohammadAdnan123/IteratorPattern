namespace IteratorDesignPattern
{
    public class ConcreteCollection : IAbstractCollection
    {
        private List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public int Count
        {
            get { return _employees.Count; }
        }

        public Employee? GetEmployee(int index)
        {
            if (index < _employees.Count)
            {
                return _employees[index];
            }
            else
            {
                return null;
            }
        }

        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
