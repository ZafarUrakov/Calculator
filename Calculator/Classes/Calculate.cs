using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}