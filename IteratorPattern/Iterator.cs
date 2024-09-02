namespace IteratorDesignPattern
{
    public interface Iterator
    {
        Employee? First();
        Employee? Next();
        bool IsCompleted { get; }
    }
}
