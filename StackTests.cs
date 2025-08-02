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

    [Fact]
    public void PushThree_CountIsThree()
    {
        var stack = new Stack();
        stack.Push(2112);
        stack.Push(42);
        stack.Push(2600);

        var count = stack.Count;

        Assert.Equal(3, count);
    }

    [Fact]
    public void PushOne_PopOne_CountIsZero()
    {
        var stack = new Stack();
        stack.Push(42);

        stack.Pop();
        var count = stack.Count;

        Assert.Equal(0, count);
    }

    [Fact]
    public void PushOne_PopOne_ReturnsPushedItem()
    {
        var stack = new Stack();
        stack.Push(42);

        var result = stack.Pop();

        Assert.Equal(42, result);
    }

    [Fact]
    public void PushThree_PopThree_ItemsReturnedLastFirst()
    {
        var stack = new Stack();
        stack.Push(2112);
        stack.Push(42);
        stack.Push(2600);

        var first = stack.Pop();
        var second = stack.Pop();
        var third = stack.Pop();

        Assert.Equal(2600, first);
        Assert.Equal(42, second);
        Assert.Equal(2112, third);
    }

    [Fact]
    public void EmptyStack_PopThrows()
    {
        var stack = new Stack();

        var ex = Record.Exception(() => stack.Pop());

        Assert.IsType<InvalidOperationException>(ex);
        Assert.Equal("The stack is empty", ex.Message);
    }

    [Fact]
    public void PushOne_Peek_CountIsOne()
    {
        var stack = new Stack();
        stack.Push(42);

        stack.Peek();
        var count = stack.Count;

        Assert.Equal(1, count);
    }

    [Fact]
    public void PushOne_Peek_ReturnsPushedItem()
    {
        var stack = new Stack();
        stack.Push(42);

        var result = stack.Peek();

        Assert.Equal(42, result);
    }

    [Fact]
    public void PushThree_PeekThree_OnlyReturnsLastPushedItem()
    {
        var stack = new Stack();
        stack.Push(2112);
        stack.Push(42);
        stack.Push(2600);

        var first = stack.Peek();
        var second = stack.Peek();
        var third = stack.Peek();

        Assert.Equal(2600, first);
        Assert.Equal(2600, second);
        Assert.Equal(2600, third);
    }

    
}
