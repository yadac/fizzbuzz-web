using Xunit;
using FizzBuzz;

namespace FizzBuzz.Tests;

public class UnitTest1
{
    [Fact]
    public void GetResult_ReturnsFizz_For3()
    {
        var logic = new FizzBuzzLogic();
        var result = logic.GetResult(3);
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void GetResult_ReturnsFizz_For5()
    {
        var logic = new FizzBuzzLogic();
        var result = logic.GetResult(5);
        Assert.Equal("Buzz", result);
    }
}