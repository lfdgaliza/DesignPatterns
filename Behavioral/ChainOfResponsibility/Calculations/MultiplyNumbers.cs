namespace ChainOfResponsibility.Calculations
{
    public class MultiplyNumbers : CalculationChainBase
    {
        public override double Calculate(Numbers numbers)
        {
            if (numbers.CalculationType == CalculationType.MULTIPLICATION)
                return numbers.Number1 * numbers.Number2;
            
            return _successor.Calculate(numbers);
        }
    }
}