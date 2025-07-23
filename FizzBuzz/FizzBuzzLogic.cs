namespace FizzBuzz;

public class FizzBuzzLogic
{
	public string GetResult(int number)
	{
		if (number % 3 == 0) return "Fizz";
		if (number % 5 == 0) return "Buzz";
		return "Fizz";
	}
}