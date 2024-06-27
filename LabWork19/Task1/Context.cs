namespace Task1
{
    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int number1, int number2) => strategy.DoOperation(number1, number2);
    }
}
