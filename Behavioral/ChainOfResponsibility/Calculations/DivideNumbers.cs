using System;

namespace ChainOfResponsibility.Calculations
{
    public class DivideNumbers : CalculationChainBase
    {
        public override double Calculate(Numbers numbers)
        {
            if (numbers.CalculationType == CalculationType.DIVISION)
                return MakeDivision(numbers);

            return (_successor ?? CalculationChainBase.Null).Calculate(numbers);
        }

        private double MakeDivision(Numbers numbers)
        {
            if (numbers.Number2 == 0)
                throw new DivideByZeroException("oh no...");

            return (double)numbers.Number1 / numbers.Number2;
        }
    }
}