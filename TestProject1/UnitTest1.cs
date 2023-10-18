using System;
using Xunit;
using lab1;
using ClassLibrary1;
using System.Linq;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddLast_IncreasesCount()
        {
            // Arrange
            var deque = new DequeClass<int>();

            // Act
            deque.AddLast(1);

            // Assert
            Assert.Equal(1, deque.Count);
        }

        [Fact]
        public void RemoveFirst_DecreaseCount()
        {
            //Arrange
            DequeClass<int> deque = new DequeClass<int>();
            deque.AddLast(1);

            //Act
            deque.RemoveFirst();

            //Assert
            Assert.Equal(0, deque.Count);
        }

        [Fact]
        public void First_ThrowsExceptionWhenEmpty()
        {
            // Arrange
            var deque = new DequeClass<int>();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => deque.First);
        }

        [Fact]
        public void Last_ThrowsExceptionWhenEmpty()
        {
            // Arrange
            var deque = new DequeClass<int>();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => deque.Last);
        }

        [Fact]
        public void AddLastAndRemoveFirst_ReturnsCorrectElements()
        {
            // Arrange
            var deque = new DequeClass<int>();

            // Act
            deque.AddLast(1);
            deque.AddLast(2);
            deque.AddLast(3);

            int element1 = deque.RemoveFirst();
            int element2 = deque.RemoveFirst();
            int element3 = deque.RemoveFirst();

            // Assert
            Assert.Equal(1, element1);
            Assert.Equal(2, element2);
            Assert.Equal(3, element3);
        }

        [Fact]
        public void Clear_EmptiesTheDeque()
        {
            // Arrange
            var deque = new DequeClass<char>();
            deque.AddLast('A');
            deque.AddLast('B');

            // Act
            deque.Clear();

            // Assert
            Assert.True(deque.IsEmpty);
            Assert.Equal(0, deque.Count);
        }

        [Fact]
        public void Contains_ReturnsTrueForExistingElement()
        {
            // Arrange
            var deque = new DequeClass<int>();
            deque.AddLast(10);
            deque.AddLast(20);
            deque.AddLast(30);

            // Act and Assert
            Assert.True(deque.Contains(20));
        }

        [Fact]
        public void Contains_ReturnsFalseForNonExistingElement()
        {
            // Arrange
            var deque = new DequeClass<string>();
            deque.AddLast("Apple");
            deque.AddLast("Banana");
            deque.AddLast("Cherry");

            // Act and Assert
            Assert.False(deque.Contains("Grapes"));
        }
    }
}
