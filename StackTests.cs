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
}
