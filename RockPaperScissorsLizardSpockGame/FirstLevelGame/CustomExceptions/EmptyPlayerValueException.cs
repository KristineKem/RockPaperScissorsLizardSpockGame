﻿namespace FirstLevelGame.CustomExceptions
{
    public class EmptyPlayerValueException : Exception
    {
        public EmptyPlayerValueException() : base("Player should contain a value.")
        {
            
        }
    }
}
