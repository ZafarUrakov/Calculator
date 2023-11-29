namespace Calculator.Classes
{
    public class AdvancedCalculate : Calculate, IAdvancedCalculate
    {
        public AdvancedCalculate(string name, double firstNumber, string function, double secondNumber)
            :base(name, firstNumber, function, secondNumber)
            { }

        public double Percentage(double firstNumber, double secondNumber)
        {
            double result = (firstNumber / 100) * secondNumber;

            return result;
        }

        public override void CalcuateAllFunctions()
        {
            double result = Percentage(this.FirstNumber, this.SecondNumber);

            Console.WriteLine($"result: {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}");
        }
    }
}