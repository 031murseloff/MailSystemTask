namespace CostomerException
{
    public class NullArgumentException:Exception
    {
        public NullArgumentException() { }

       public NullArgumentException(string message) : base(message) { }

    }
}