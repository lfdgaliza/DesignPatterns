using System;
using ChainOfResponsibility.Calculations;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculationChainBase chain = CreateChain();

            Numbers numbers;

            numbers = new Numbers(2, 4, CalculationType.SUM);
            Console.WriteLine($"2 + 4 = {chain.Calculate(numbers)}");

            numbers = new Numbers(2, 4, CalculationType.SUBTRACTION);
            Console.WriteLine($"2 - 4 = {chain.Calculate(numbers)}");

            numbers = new Numbers(2, 4, CalculationType.MULTIBLICATION);
            Console.WriteLine($"2 * 4 = {chain.Calculate(numbers)}");

            numbers = new Numbers(2, 4, CalculationType.DIVISION);
            Console.WriteLine($"2 / 4 = {chain.Calculate(numbers)}");

            // It is better to test if it is a "divide by 0" rather than use try/catch
            // I did it only to show that it works fine.
            try
            {
                Console.Write("2 / 0 = ");
                numbers = new Numbers(2, 0, CalculationType.DIVISION);
                Console.WriteLine(chain.Calculate(numbers));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static CalculationChainBase CreateChain()
        {
            var sum = new SumNumbers();
            var subtract = new SubtractNumbers();
            var multiply = new MultiplyNumbers();
            var divide = new DivideNumbers();

            sum.SetSucessor(subtract);
            subtract.SetSucessor(multiply);
            multiply.SetSucessor(divide);

            return sum;
        }
    }
}
