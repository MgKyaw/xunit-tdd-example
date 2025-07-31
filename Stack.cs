public class Stack
{
    public int Count { get; private set; }

    public void Push(int element) => Count = 3;

    public void Pop() => Count--;
}