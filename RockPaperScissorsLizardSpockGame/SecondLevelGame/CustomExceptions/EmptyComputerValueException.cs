namespace SecondLevelGame.CustomExceptions
{
    public class EmptyComputerValueException : Exception
    {
        public EmptyComputerValueException() : base("Computer should contain a value.")
        {
            
        }
    }
}
