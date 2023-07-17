namespace ThirdLevelGame.CustomExceptions
{
    public class ZeroRoundsException : Exception
    {
        public ZeroRoundsException() : base("Number of round should be 1 - 5.")
        {
            
        }
    }
}
