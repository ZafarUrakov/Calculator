namespace Calculator.Classes
{
    public class Calculate
    {
       private string name;

        public Calculate(string name)
        {
            this.name = name;
        }

        public void Addition(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            
            Console.WriteLine($"Name: {name} | firsNumber: {firstNumber} , secondNumber: {secondNumber}\n" + 
            $"Result: {result}");
        }

        public void Subtraction(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            
            Console.WriteLine($"Name: {name} | firsNumber: {firstNumber} , secondNumber: {secondNumber}\n" + 
            $"Result: {result}");
        }

        public void Division(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            
            Console.WriteLine($"Name: {name} | firsNumber: {firstNumber} , secondNumber: {secondNumber}\n" + 
            $"Result: {result}");
        }

        public void Multiplication(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            
            Console.WriteLine($"Name: {name} | firsNumber: {firstNumber} , secondNumber: {secondNumber}\n" + 
            $"Result: {result}");
        }
    }
}