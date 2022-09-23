using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class StackWithOneElement
    {
        Stack<int> stack;
        const int pushedValue = 42;


        public StackWithOneElement()
        {
            stack = new Stack<int>();
            stack.Push(pushedValue);
            Thread.Sleep(2000);
        }


        [Fact]
        public async void Pop_CountShouldBeZero()
        {
            stack.Pop();

            int count = stack.Count;

            await Task.Delay(5000);
            //Thread.Sleep(5000);
            Assert.Equal(0, count);
        }

        [Fact]
        public void Count_ShouldBeOne()
        {
            int count = stack.Count;

            Thread.Sleep(5000);
            Assert.Equal(1, count);
        }

        [Fact]
        public void Peek_CountShouldBeOne()
        {
            stack.Peek();

            int count = stack.Count;

            Thread.Sleep(5000);
            Assert.Equal(1, count);
        }

        [Fact]
        public void Pop_ShouldReturnPushedValue()
        {
            int actual = stack.Pop();

            Thread.Sleep(5000);
            Assert.Equal(pushedValue, actual);
        }

        [Fact]
        public void Peek_ShouldReturnPushedValue()
        {
            int actual = stack.Peek();

            Thread.Sleep(5000);
            Assert.Equal(pushedValue, actual);
        }
    }
}
