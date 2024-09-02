namespace IteratorDesignPattern
{
    public class ConcreteIterator : Iterator
    {
        private readonly ConcreteCollection _collection;
        private int _currentIndex = 0;

        public ConcreteIterator(ConcreteCollection collection)
        {
            _collection = collection;
        }

        public Employee? First()
        {
            _currentIndex = 0;
            return _collection.GetEmployee(_currentIndex);
        }

        public Employee? Next()
        {
            _currentIndex++;
            if (!IsCompleted)
            {
                return _collection.GetEmployee(_currentIndex);
            }
            else
            {
                return null;
            }
        }

        public bool IsCompleted
        {
            get { return _currentIndex >= _collection.Count; }
        }
    }
}
