using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BogKlub
{
    public class BookTest
    {


        [Theory]
        [InlineData(1,50,50)]
        [InlineData(10,50,500)]
        [InlineData(20, 100, 2000)]
        public void Calulate_Reading_time_in_minutes_should_return_correct_reading_time(
            int readingSpeedInMinutesPerPage,
            int numberOfPages,
            int expectedResult)
        {
            //arrange
            Book sut = new Book("title", "author", numberOfPages, "genre");

            //act
            int result = sut.CalculateReadingTimeInMinutes(readingSpeedInMinutesPerPage);

            //assert
            result.Should().Be(expectedResult);
        }

        //readingSpeedInMinutesPerPage can not be 0 or below
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Reading_Speed_minuts_can_not_be_0_or_below(int readingSpeedInMinutesPerPage)
        {
            //arrange
            Book sut = new Book("title", "author", 100, "genre");

            //act
            int result = sut.CalculateReadingTimeInMinutes(readingSpeedInMinutesPerPage);

            //assert
            result.Should().Be(-1);
        }




        [Fact]
        public void When_a_book_is_returned_its_borrowed_status_is_false()
        {
            //arrange
            Book sut = new Book("title", "author", 100, "genre");
            sut.BorrowBook();

            //act
            sut.ReturnBook();

            //assert
          sut.IsBorrowed.Should().BeFalse();
        }

        [Fact]
        public void When_a_book_is_borrowed_its_borrowed_status_is_true()
        {
            //arrange
            Book sut = new Book("title", "author", 100, "genre");

            //act
            sut.BorrowBook();

            //assert
            sut.IsBorrowed.Should().BeTrue();
        }



        [Fact]
        public void Book_Can_Not_Be_Rated_Below_1_Stars()
        {
            //araange
            Book sut = new Book("title", "author", 100, "genre");

            //act
            bool result = sut.RateBook(-1);

            //assert
            result.Should().BeFalse();
          

        }


        [Fact]
        public void Book_Can_Not_Be_Rated_Above_5_Stars()
        {
            //araange
            Book sut = new Book("title", "author", 100, "genre");

            //act
            bool result = sut.RateBook(6);

            //assert
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void Book_Can_Be_Rated_Between_1_And_5_Stars(double rating)
        {
            //araange
            Book sut = new Book("title", "author", 100, "genre");

            //act
            bool result = sut.RateBook(rating);

            //assert
            result.Should().BeTrue();   
        }




    }
}
