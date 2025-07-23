namespace FizzBuzz;

public class FizzBuzzLogic
{
	public static string GetResult(int number)
	{
		if (number % 3 == 0)
		{
			return "Fizz";
		}

		return number % 5 == 0 ? "Buzz" : "Fizz";
	}
}
