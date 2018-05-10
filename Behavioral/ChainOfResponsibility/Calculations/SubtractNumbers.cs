namespace ChainOfResponsibility.Calculations
{
    public class SubtractNumbers : CalculationChainBase
    {
        public override double Calculate(Numbers numbers)
        {
            if (numbers.CalculationType == CalculationType.SUBTRACTION)
                return numbers.Number1 - numbers.Number2;
            
            return _successor.Calculate(numbers);
        }
    }
}