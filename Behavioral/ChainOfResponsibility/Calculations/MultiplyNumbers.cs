namespace ChainOfResponsibility.Calculations
{
    public class MultiplyNumbers : CalculationChainBase
    {
        public override double Calculate(Numbers numbers)
        {
            if (numbers.CalculationType == CalculationType.MULTIBLICATION)
                return numbers.Number1 * numbers.Number2;
            
            return (_successor ?? CalculationChainBase.Null).Calculate(numbers);
        }
    }
}