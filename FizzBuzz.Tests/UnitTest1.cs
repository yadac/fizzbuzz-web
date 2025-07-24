namespace FizzBuzz.Tests;

public class UnitTest1
{
    [Fact]
    public void GetResultReturnsFizzFor3()
    {
        var logic = new FizzBuzzLogic();
        var result = logic.GetResult(3);
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void GetResultReturnsFizzFor5()
    {
        var logic = new FizzBuzzLogic();
        var result = logic.GetResult(5);
        Assert.Equal("Buzz", result);
    }

    [Fact]
    public void GetResultReturnsFizzFor15()
    {
        var logic = new FizzBuzzLogic();
        var result = logic.GetResult(15);
        Assert.Equal("FizzBuzz", result);
    }

    [Fact]
    public void GetResultReturnsNotFizzBuzz()
    {
        var logic = new FizzBuzzLogic();
        var result = logic.GetResult(1);
        Assert.Equal("1", result);
    }
}
