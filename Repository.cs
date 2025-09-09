namespace FirstProject;

// new() constraint ensures T has a parameterless constructor
// where T : IRepositoryEntity ensures T implements IRepositoryEntity
public class Repository<T> where T : IRepositoryEntity, new() {
    
    private readonly List<T> _items = [];

    public void Add(T item) {
        _items.Add(item);
    }

    public bool Remove(T item) {
        return _items.Remove(item);
    }

    public T? GetByIndex(int index) {
        if (index < 0 || index >= _items.Count) {
            return default;
        }

        return _items[index];
    }
    
    public T? GetById(int id) {
        return _items.FirstOrDefault(item => item.Id == id);
    }

    public List<T> GetAll() {
        return new List<T>(_items);
    }

    public int Count() {
        return _items.Count;
    }
}

public class Repository<TKey, TValue> where TKey : notnull where TValue : notnull {
    
    private readonly Dictionary<TKey, TValue> _items = new Dictionary<TKey, TValue>();

    public void Add(TKey key, TValue value) {
        _items[key] = value;
    }

    public bool Remove(TKey key) {
        return _items.Remove(key);
    }

    public TValue? GetByKey(TKey key) {
        return _items.GetValueOrDefault(key);
    }

    public List<TValue> GetAll() {
        return _items.Values.ToList();
    }

    public int Count() {
        return _items.Count;
    }
}