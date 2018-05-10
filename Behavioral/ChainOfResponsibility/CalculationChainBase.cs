namespace ChainOfResponsibility
{
    public abstract class CalculationChainBase
    {
        protected CalculationChainBase _successor;
        public void SetSucessor(CalculationChainBase successor) => _successor = successor;

        public abstract double Calculate(Numbers numbers);

        #region NullObject
        public static readonly  CalculationChainBase Null = new NullCalculationChainBase();

        private class NullCalculationChainBase : CalculationChainBase
        {
            public override double Calculate(Numbers numbers) => 0;
        }
        #endregion
    }
}