using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    [TestFixture]
    public class MyStackTests
    {
        [Test]
        public void IsEmpty_EmptyStack_returnsTrue()
        {
            var stack = new MyStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }
        [Test]
        public void Count_PushOneItem_ReturnsOne()
        {
            var stack = new MyStack<int>();
            stack.Push(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }
        [Test]
        public void Pop_EmptyStack_ThrowsException()
        {
            var stack = new MyStack<int>();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }
        [Test]
        public void Peek_PushTwoItes_ReturnsHeadItem()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Peek());
        }
    }
}
