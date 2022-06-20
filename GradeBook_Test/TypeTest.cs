using GradeBook;
using System;
using Xunit;

namespace GradeBook_Test
{
    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTest
    {
        [Fact]
        public void WriteDeligateCanPointToMethod()
        {
            WriteLogDelegate log;
            log = new WriteLogDelegate(ReturnMessage);
            var resultr = log("Hello!");
            Assert.Equal("Hello!", resultr);
        }
        string ReturnMessage(string message)
        {
            return message; 
        }

      
        [Fact]
        public void GetBooktReturnsDifferentObjects()
        {//Arrange

            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            //act


            //assert

            Assert.Equal("Book 1",book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);

        }

        [Fact]
        public void TwovariablesCanReferenceSameObject()
        {//Arrange

            var book1 = GetBook("Book 1");
            var book2 = book1;
            //act


            //assert
            Assert.Same(book1, book2);
            Assert.True(object.ReferenceEquals(book1, book2));  
            //Assert.Equal("Book 1", book1.Name);
            //Assert.Equal("Book 1", book2.Name);

        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
