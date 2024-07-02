namespace CostomerException;

public class NoTFoundPostException:Exception
{

    public NoTFoundPostException() { }
    public NoTFoundPostException(string message) : base(message) { }

}
