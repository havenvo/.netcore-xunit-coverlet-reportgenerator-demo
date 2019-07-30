using System;
using Xunit;

namespace SimpleStack.Tests {
    public class StackTests {
        [Fact]
        public void PushAndPeekShouldWork () {
            IStack stack = new Stack ();
            stack.Push ("A");
            Assert.Equal ("A", stack.Peek ());
            Assert.Equal ("A", stack.Peek ());
        }

        [Fact]
        public void PopAndIsEmptyShouldWork () {
            IStack stack = new Stack ();
            stack.Push ("A");
            Assert.Equal ("A", stack.Pop ());
            Assert.True (stack.IsEmpty ());
            Assert.Throws<StackEmptyException> (() => stack.Pop ());
        }

        [Fact]
        public void ClearShouldWork () {
            IStack stack = new Stack ();
            stack.Push ("A");
            stack.Clear ();
            Assert.True (stack.IsEmpty ());
        }
    }
}