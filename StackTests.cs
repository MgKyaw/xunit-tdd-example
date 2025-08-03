public class StackTests
{
    public class EmptyStack
    {
        readonly Stack stack = new();

        [Fact]
        public void CountIsZero()
        {
            var count = stack.Count;

            Assert.Equal(0, count);
        }

        [Fact]
        public void PopThrows()
        {
            var ex = Record.Exception(() => stack.Pop());

            Assert.IsType<InvalidOperationException>(ex);
            Assert.Equal("The stack is empty", ex.Message);
        }

        [Fact]
        public void PeekThrows()
        {
            var ex = Record.Exception(() => stack.Peek());

            Assert.IsType<InvalidOperationException>(ex);
            Assert.Equal("The stack is empty", ex.Message);
        }
    }

    public class OneItemStack
    {
        readonly Stack stack = new();

        public OneItemStack() => stack.Push(42);

        [Fact]
        public void CountIsOne()
        {
            var count = stack.Count;

            Assert.Equal(1, count);
        }

        [Fact]
        public void PopOne_CountIsZero()
        {
            stack.Pop();
            var count = stack.Count;

            Assert.Equal(0, count);
        }

        [Fact]
        public void PopOne_ReturnsPushedItem()
        {
            var result = stack.Pop();

            Assert.Equal(42, result);
        }

        [Fact]
        public void PeekOne_CountIsOne()
        {
            stack.Peek();
            var count = stack.Count;

            Assert.Equal(1, count);
        }

        [Fact]
        public void PeekOne_ReturnsPushedItem()
        {
            var result = stack.Peek();

            Assert.Equal(42, result);
        }
    }

    public class ThreeItemStack
    {
        readonly Stack stack = new();

        public ThreeItemStack()
        {
            stack.Push(2112);
            stack.Push(42);
            stack.Push(2600);
        }

        [Fact]
        public void CountIsThree()
        {
            var count = stack.Count;

            Assert.Equal(3, count);
        }

        [Fact]
        public void PopThree_ItemsReturnedLastFirst()
        {
            var first = stack.Pop();
            var second = stack.Pop();
            var third = stack.Pop();

            Assert.Equal(2600, first);
            Assert.Equal(42, second);
            Assert.Equal(2112, third);
        }

        [Fact]
        public void PeekThree_OnlyReturnsLastPushedItem()
        {
            var first = stack.Peek();
            var second = stack.Peek();
            var third = stack.Peek();

            Assert.Equal(2600, first);
            Assert.Equal(2600, second);
            Assert.Equal(2600, third);
        }
    }
}
