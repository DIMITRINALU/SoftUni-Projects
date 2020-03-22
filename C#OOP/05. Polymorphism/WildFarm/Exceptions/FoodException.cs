namespace WildFarm.Exceptions
{
    using System;

    class FoodException : Exception
    {        
        public FoodException(string message)
            : base(message)
        {

        }
    }
}
