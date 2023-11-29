using Calculator.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to calculator!");

        Console.Write("Your name: ");
        string name = Console.ReadLine()!;

        Console.Write("First number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Function [+ | - | / | * | prc]: ");
        string function = Console.ReadLine()!;

        Console.Write("Second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine()!);

        if(function == "prc")
        {
            AdvancedCalculate advancedCalculate = 
                new AdvancedCalculate(name, firstNumber, function, secondNumber);

                advancedCalculate.CalcuateAllFunctions();
        }
        else
        {
            ICalculate calculate = new Calculate(name, firstNumber, function, secondNumber);
            calculate.CalcuateAllFunctions();
        }
    }
}