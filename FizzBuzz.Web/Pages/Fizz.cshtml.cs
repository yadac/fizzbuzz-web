using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzz;
using Microsoft.AspNetCore.Mvc;

public class FizzModel : PageModel
{
    [BindProperty]
    public int InputNumber { get; set; }

    public string? Result { get; set; }

    public void OnPost()
    {
        // Console.WriteLine($"InputNumber: {InputNumber}");
        var logic = new FizzBuzzLogic();
        Result = logic.GetResult(InputNumber);
    }
}
