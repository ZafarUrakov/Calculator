using Calculator.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to calculator!");

        Console.Write("Your name: ");
        string name = Console.ReadLine()!;

        Calculate calculate = new Calculate(name);

        Console.Write("First number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Function [+ | - | / | *]: ");
        string function = Console.ReadLine()!;

        Console.Write("Second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine()!);

        switch(function)
        {
            case "+":
                calculate.Addition(firstNumber, secondNumber);
                break;
            case "-":
                calculate.Subtraction(firstNumber, secondNumber);
                break;
            case "/":
                calculate.Division(firstNumber, secondNumber);
                break;
            case "*":
                calculate.Multiplication(firstNumber, secondNumber);
                break;
        }
    }
}