namespace Telephony
{
    using System.Linq;

    public class Smartphone : ICallable, IBrowseable
    {
        public Smartphone()
        {

        }

        public string Call(string number)
        {
            if (!number.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidNumberException();
            }

            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if (url.Any(ch => char.IsDigit(ch)))
            {
                throw new InvalidUrlException();
            }

            return $"Browsing: {url}!";
        }
    }
}