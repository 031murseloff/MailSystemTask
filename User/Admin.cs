
using Posts;

namespace Admins;


public class Admin
{
  

   

    public Guid AdminId { get; set; }
    public string AdminUserName { get; set; } = string.Empty;
    public string AdminPassword { get; set; }
    public string AdminEmail { get; set; }
    public Post Post { get; set; }

    public Notification AdminNotification { get; set; }

    public Admin(string adminUserName, string adminPassword, string adminEmail, Notification adminNotification,Post post)
    {
        AdminId= Guid.NewGuid();
        AdminUserName = adminUserName;
        AdminPassword = adminPassword;
        AdminEmail = adminEmail;
        AdminNotification = adminNotification;
        Post = post;
    }




}