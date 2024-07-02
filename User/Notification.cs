using System.Reflection.Metadata;
using Users;

namespace Admins;

public class Notification
{
   

    public Guid NotificationID { get; set; }
    public string Text { get; set; }
    public DateTime DateTime { get; set; }
    public User  FromUser { get; set; }

    public Notification(string text, DateTime dateTime, User fromUser)
    {
        NotificationID = Guid.NewGuid();
        Text = text;
        DateTime = dateTime;
        FromUser = fromUser;
    }


}
