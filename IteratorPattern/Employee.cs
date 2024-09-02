namespace IteratorDesignPattern
{
    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
