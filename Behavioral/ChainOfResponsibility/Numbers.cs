namespace ChainOfResponsibility
{
    public class Numbers
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public CalculationType CalculationType;

        public Numbers(int number1, int number2, CalculationType calculationType)
        {
            Number1 = number1;
            Number2 = number2;
            CalculationType = calculationType;
        } 
    }
}