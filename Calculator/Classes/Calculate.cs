using System.Security.Cryptography;

namespace Calculator.Classes
{
    public class Calculate : ICalculate
    {
       public string Name {get; set;}
       public double FirstNumber{get; set;}
       public double SecondNumber{get; set;}
       public string Function { get; set; }

        public Calculate(string name, double firstNumber, string function, double secondNumber)
        {
            Name = name;
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Function = function;
        }

        public virtual void CalcuateAllFunctions()
        {
            double result = this.Function switch
            {
                "+" => Addition(this.FirstNumber, this.SecondNumber),
                "-" => Subtraction(this.FirstNumber, this.SecondNumber),
                "/" => Division(this.FirstNumber, this.SecondNumber),
                "*" => Multiplication(this.FirstNumber, this.SecondNumber),
                _ =>0
            };

            Console.WriteLine($"result: {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}");
        }

        private double Addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private double Subtraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private double Division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        private double Multiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}