using System;
using Xunit;

namespace Calculator.Tests
{
    public class adding_numbers_from_user_input
    {
        [Theory]
        [InlineData("2+2", 4)]
        [InlineData("2+5", 7)]
        [InlineData("2+10", 12)]
        [InlineData("9+22", 31)]
        [InlineData("9+22+7", 38)]
        public void adding_any_set_of_numbers_should_return_the_result(string input, int expectedResult)
        {
            //Arrange -- context -- Given from Userstory
            var calculator = new CalculationEngine();
     
            //Act -- Do the thing -- When from Userstory
            var actualResult = calculator.DoMath(input);

            //Assert --Checking the result -- Then
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void addition_with_only_one_number_throws_an_invalid_input_exception()
        {
            //Arrange
            var calculator = new CalculationEngine();
            var input = "2+";

            //Assert
            Assert.Throws<InvalidInputException>(() => /*act*/calculator.DoMath(input));
        }

        //[Fact]
        //public void adding_3_numbers_they_should_be_added_successfully()
        //{
        //    //Arrange -- context -- Given from Userstory
        //    var calculator = new CalculationEngine();
        //    var input = "2+5+10";
        //    var expectedResult = 17;

        //    //Act -- Do the thing -- When from Userstory
        //    var actualResult = calculator.DoMath(input);

        //    //Assert --Checking the result -- Then
        //    Assert.Equal(expectedResult, actualResult);
        //}
    }
}
