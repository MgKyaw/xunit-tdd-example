public class Stack
{
    readonly List<int> storage = new();

    public int Count => storage.Count;

    public void Push(int element)
    {
        storage.Add(element);
    }

    public int Pop() => GetValue(remove: true);

    public int Peek() => GetValue(remove: false);

    int GetValue(bool remove)
    {
        if (Count == 0)
            throw new InvalidOperationException("The stack is empty");

        var lastIndex = Count - 1;
        var result = storage[lastIndex];

        if (remove)
            storage.RemoveAt(lastIndex);

        return result;
    }
}
