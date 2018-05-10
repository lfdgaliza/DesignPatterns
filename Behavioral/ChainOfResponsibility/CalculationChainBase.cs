namespace ChainOfResponsibility
{
    public abstract class CalculationChainBase
    {
        protected CalculationChainBase _successor = CalculationChainBase.Null;
        public void SetSucessor(CalculationChainBase successor) => _successor = successor;

        public abstract double Calculate(Numbers numbers);

        #region NullObject
        public static readonly  CalculationChainBase Null = new NullCalculationChainBase();

        private class NullCalculationChainBase : CalculationChainBase
        {
            // What do you want to do when there is no more CalculationChain item?
            public override double Calculate(Numbers numbers) => 0;
        }
        #endregion
    }
}