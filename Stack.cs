public class Stack
{
    public int Count { get; private set; }

    public void Push(int element) => Count++;

    public void Pop() => Count--;
}