namespace FizzBuzz;

public class FizzBuzzLogic
{
    public static string GetResult(int number)
    {
        return number % 3 == 0 ? "Fizz" : number % 5 == 0 ? "Buzz" : "Fizz";
    }
}
