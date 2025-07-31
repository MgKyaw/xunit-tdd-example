public class Stack
{
    readonly List<int> storage = new();

    public int Count => storage.Count;

    public void Push(int element)
    {
        storage.Add(element);
    }

    public int Pop()
    {
        if (Count == 0)
            throw new InvalidOperationException("The stack is empty");

        var lastIndex = Count - 1;
        var result = storage[lastIndex];
        storage.RemoveAt(lastIndex);

        return result;
    }
}
