namespace FizzBuzz.Tests;

public class UnitTest1
{
    [Fact]
    public void GetResultReturnsFizzFor3()
    {
        _ = new FizzBuzzLogic();
        var result = FizzBuzzLogic.GetResult(3);
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void GetResultReturnsFizzFor5()
    {
        _ = new FizzBuzzLogic();
        var result = FizzBuzzLogic.GetResult(5);
        Assert.Equal("Buzz", result);
    }

    [Fact]
    public void GetResultReturnsFizzFor15()
    {
        _ = new FizzBuzzLogic();
        var result = FizzBuzzLogic.GetResult(15);
        Assert.Equal("FizzBuzz", result);
    }

    [Fact]
    public void GetResultReturnsNotFizzBuzz()
    {
        _ = new FizzBuzzLogic();
        var result = FizzBuzzLogic.GetResult(1);
        Assert.Equal("1", result);
    }
}
