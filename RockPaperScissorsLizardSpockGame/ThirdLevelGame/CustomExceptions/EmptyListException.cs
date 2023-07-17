namespace ThirdLevelGame.CustomExceptions
{
    public class EmptyListException : Exception
    {
        public EmptyListException() : base("There should be more than one player.")
        {
            
        }
    }
}
