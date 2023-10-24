using System;
using Xunit;
using lab1;
using ClassLibrary1;
using System.Linq;
using System.Collections.Generic;

namespace TestProject1
{
    public class UnitTest1
    {
         [Fact]
        public void AddLast_IncreasesCount()
        {
            var deque = new DequeClass<int>();

            deque.AddLast(1);

            Assert.Equal(1, deque.Count);
        } 

        [Fact]
        public void RemoveFirst_DecreaseCount()
        {
            DequeClass<int> deque = new DequeClass<int>();
            deque.AddLast(1);

            deque.RemoveFirst();

            Assert.Equal(0, deque.Count);
        }

        [Fact]
        public void First_ThrowsExceptionWhenEmpty()
        {
            var deque = new DequeClass<int>();

            Assert.Throws<InvalidOperationException>(() => deque.First);
        }

        [Fact]
        public void Last_ThrowsExceptionWhenEmpty()
        {
            var deque = new DequeClass<int>();

            Assert.Throws<InvalidOperationException>(() => deque.Last);
        }

        [Fact]
        public void Clear_EmptiesTheDeque()
        {
            var deque = new DequeClass<char>();
            deque.AddLast('A');
            deque.AddLast('B');

            deque.Clear();

            Assert.True(deque.IsEmpty);
            Assert.Equal(0, deque.Count);
        }

        [Fact]
        public void Contains_ReturnsTrueForExistingElement()
        {
            var deque = new DequeClass<int>();
            deque.AddLast(10);
            deque.AddLast(20);
            deque.AddLast(30);

            Assert.True(deque.Contains(20));
        }

        [Fact]
        public void Contains_ReturnsFalseForNonExistingElement()
        {
            var deque = new DequeClass<string>();
            deque.AddFirst("Apple");
            deque.AddFirst("Banana");
            deque.AddFirst("Cherry");

            Assert.False(deque.Contains("Grapes"));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(10, 20, 30, 40, 50)]
        public void AddLastAndRemoveFirst_ReturnsCorrectElements(params int[] elements)
        {
            var deque = new DequeClass<int>();

            foreach (var element in elements)
            {
                deque.AddLast(element);
            }

            foreach (var element in elements)
            {
                Assert.Equal(element, deque.RemoveFirst());
            }
        }

        [Theory]
        [InlineData("a", "b", "c")]
        [InlineData("w", "q", "y", "x", "z")]
        public void AddFirstAndRemoveLast_ReturnsCorrectElements(params string[] elements)
        {
            var deque = new DequeClass<string>();

            foreach (var element in elements)
            {
                deque.AddFirst(element);
            }

            foreach (var element in elements)
            {
                Assert.Equal(element, deque.RemoveLast());
            }
        }

        [Fact]
        public void GetEnumerator_ReturnsAllElements()
        {
            var deque = new DequeClass<int>();
            deque.AddLast(1);
            deque.AddLast(2);
            deque.AddLast(3);

            var elements = deque.ToList(); 

            Assert.Equal(new List<int> { 1, 2, 3 }, elements);
        }

        [Fact]
        public void GetEnumerator_EmptyDeque_ReturnsEmptyEnumeration()
        {
            var deque = new DequeClass<string>();

            var elements = deque.ToList();

            Assert.Empty(elements);
        }
    }
}
