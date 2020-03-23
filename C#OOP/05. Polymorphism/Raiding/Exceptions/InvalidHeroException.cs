namespace Raiding.Exceptions
{
    using System;

    public class InvalidHeroException : Exception
    {
        private const string INVALID_HERO_TYPE_MESSAGE = "Invalid hero!";

        public InvalidHeroException()
            : base(INVALID_HERO_TYPE_MESSAGE)
        {

        }

        public InvalidHeroException(string message)
            : base(message)
        {

        }
    }
}