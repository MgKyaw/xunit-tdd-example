using Xunit;

public class StackTests
{
    [Fact]
    public void EmptyStack_CountIsZero()
    {
        var stack = new Stack();

        var count = stack.Count;

        Assert.Equal(0, count);
    }

    [Fact]
    public void PushOne_CountIsOne()
    {
        var stack = new Stack();
        stack.Push(42);

        var count = stack.Count;

        Assert.Equal(1, count);
    }
}
