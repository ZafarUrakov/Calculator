using Calculator.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("name: ");
        string name = Console.ReadLine()!;

        Calculate calculate = new Calculate(name);

        Console.Write("first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine()!);

        calculate.Addition(firstNumber, secondNumber);
    }
}