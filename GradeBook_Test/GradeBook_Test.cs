using GradeBook;
using System;
using Xunit;

namespace GradeBook_Test
{
    public class GradeBook_Test
    {
        [Fact]
        public void BookCalculateAnAverageGrade()
        {//Arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(39.1);
            book.AddGrade(77.3);


            //act

           var result = book.GetStatistics();
            //assert


            Assert.Equal(68.5, result.Average, 1);
            Assert.Equal(89.1, result.High, 1);
            Assert.Equal(39.1, result.Low, 1);
            Assert.Equal('F', result.Letter);
        }
    }
}
