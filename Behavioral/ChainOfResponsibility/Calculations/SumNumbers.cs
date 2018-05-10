namespace ChainOfResponsibility.Calculations
{
    public class SumNumbers : CalculationChainBase
    {
        public override double Calculate(Numbers numbers)
        {
            if (numbers.CalculationType == CalculationType.SUM)
                return numbers.Number1 + numbers.Number2;
            
            return _successor.Calculate(numbers);
        }
    }
}