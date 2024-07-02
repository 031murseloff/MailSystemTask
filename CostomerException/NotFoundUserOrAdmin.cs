namespace CostomerException;

public class NotFoundUserOrAdmin:Exception
{
    public NotFoundUserOrAdmin() { }
   public NotFoundUserOrAdmin(string message) :base(message){ }

}
